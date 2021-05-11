using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Microsoft.Data.Analysis;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using Newtonsoft.Json.Linq;
using System.Globalization;
using LiveCharts.Wpf;
using LiveCharts;
using System.Windows.Media;
using LiveCharts.Defaults;
using LiveCharts.Configurations;
//using Wpf.CartesianChart.Using_DateTime;
using System.Runtime.Serialization;

namespace Colordyne__Time_Series_Plotter_
{
    public partial class Form1 : Form
    {
        private readonly string apiKey = "QFE382XU44L33V84";    //? Maybe store in json or text file with encrption/lock?

        private readonly string apiKeyCrypto = "e9e6052c-51fc-4f8f-8cb6-bfe7753697e8";    //? Maybe store in json or text file with encrption/lock?

        static readonly HttpClient client = new HttpClient();

        static LiveCharts.SeriesCollection cryptoData = new LiveCharts.SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<DateTimePoint>
                    {
                    }
                }
            };

        Timer timer = new Timer();

        string cryptoTicker = "";

        public Form1()
        {
            InitializeComponent();

            timer.Interval = 60000;
            timer.Tick += timer_Tick;

            cartesianChart1.Series = cryptoData;

            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Time (EST)",
                LabelFormatter = value => new DateTime((long)value).ToString("h:mm:ss tt")
            });

            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Price\n(USD)",
                LabelFormatter = value => value.ToString("C")
            });
        }

        private async void timer_Tick(object sender, EventArgs e)
        {
            await this.GetCryptoDataAPICall(cryptoTicker);
        }

        private async void buttonRunTSPlot_Click(object sender, EventArgs e)
        {
            string ticker = this.tickerTSTextBox.Text;
            if (ticker == "")
                labelErrorMessage.Text = "Please provide a valid crypto ticker to retrieve crypto data.";
            else if (ticker == cryptoTicker)
                labelErrorMessage.Text = "Please provide a new crypto ticker to retrieve crypto data.";
            else
            {
                await this.GetCryptoDataTimeSeries(ticker);
                labelErrorMessage.Text = "";
            }
        }

        private async Task GetCryptoDataAPICall(string ticker)
        {
            try
            {
                // API Call
                string response = await client.GetStringAsync("https://" + $@"pro-api.coinmarketcap.com/v1/cryptocurrency/quotes/latest?CMC_PRO_API_KEY={this.apiKeyCrypto}&symbol={ticker}");
                
                // Coin Value
                string price = response.Substring(response.IndexOf("price"), 25);
                string[] priceParts = price.Split(new char[] { ':', ',' }, System.StringSplitOptions.RemoveEmptyEntries);
                double priceDouble = double.Parse(priceParts[1]);
                
                // Last Time coin data was updated
                string time = response.Substring(response.IndexOf("last_updated"), 40);
                string[] timeParts = time.Split(new char[] { '"', 'Z' }, System.StringSplitOptions.RemoveEmptyEntries);
                string timeString = timeParts[timeParts.Length - 1];
                DateTime dateTimeUTC = Convert.ToDateTime(timeString);
                DateTime dateTimeEST = TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"));

                cartesianChart1.Series[0].Values.Add(new DateTimePoint(dateTimeEST, priceDouble));
            }
            catch (HttpRequestException)
            {
                labelErrorMessage.Text = "Crypto Ticker provided was not found. Please check the entered text.";
            }
            catch (Exception)
            {
                labelErrorMessage.Text = "There was a problem retrieving the requested crypto data. Please try again.";
            }
        }

        private async Task GetCryptoDataTimeSeries(string ticker)
        {
            timer.Stop();
            cryptoTicker = ticker;
            cartesianChart1.Series[0].Values.Clear();

            await this.GetCryptoDataAPICall(ticker);

            timer.Start();
        }

        private async void buttonRunFundamentals_Click(object sender, EventArgs e)
        {
            string ticker1 = this.textBoxTicker1.Text;
            string ticker2 = this.textBoxTicker2.Text;

            if (ticker1 == "" || ticker2 == "")
            {
                labelErrorMessageFundamentals.Text = "Please provide two valid stock tickers to retrieve stock data.";
            }
            else
            {
                await this.GetStockDataFundamentals(ticker1, ticker2);
                labelErrorMessageFundamentals.Text = "";
            }
        }

        private async Task GetStockDataFundamentals(string ticker1, string ticker2)
        {
            try
            {
                // Overview Data
                string response1Overview = await client.GetStringAsync("https://" + $@"www.alphavantage.co/query?function=OVERVIEW&symbol={ticker1}&apikey={this.apiKey}");
                string response2Overview = await client.GetStringAsync("https://" + $@"www.alphavantage.co/query?function=OVERVIEW&symbol={ticker2}&apikey={this.apiKey}");

                // Balance Sheet Data
                string response1BS = await client.GetStringAsync("https://" + $@"www.alphavantage.co/query?function=BALANCE_SHEET&symbol={ticker1}&apikey={this.apiKey}");
                string response2BS = await client.GetStringAsync("https://" + $@"www.alphavantage.co/query?function=BALANCE_SHEET&symbol={ticker2}&apikey={this.apiKey}");

                // Ticker 1 PERatio and MarketCap
                dynamic response1Data = JObject.Parse(response1Overview);
                labelTicker1PE.Text = response1Data.PERatio;
                labelTicker1MC.Text = string.Format(new CultureInfo("en-US"), "{0:c}", (double)response1Data.MarketCapitalization);

                // Ticker 2 PERatio and MarketCap
                dynamic response2Data = JObject.Parse(response2Overview);
                labelTicker2PE.Text = response2Data.PERatio;
                labelTicker2MC.Text = string.Format(new CultureInfo("en-US"), "{0:c}", (double)response2Data.MarketCapitalization);

                // Ticker 1 Quick Ratio
                dynamic response1BSData = JObject.Parse(response1BS);                                                                                   
                double ticker1QR = ((double)response1BSData.annualReports[0].totalCurrentAssets - (double)response1BSData.annualReports[0].inventory) 
                    / (double)response1BSData.annualReports[0].totalCurrentLiabilities;
                labelTicker1QR.Text = String.Format("{0:0.000000}", ticker1QR);

                // Ticker 2 Quick Ratio
                dynamic response2BSData = JObject.Parse(response2BS);          
                double ticker2QR = ((double)response2BSData.annualReports[0].totalCurrentAssets - (double)response2BSData.annualReports[0].inventory) 
                    / (double)response2BSData.annualReports[0].totalCurrentLiabilities;
                labelTicker2QR.Text = String.Format("{0:0.000000}", ticker2QR);

                // % Difference Column
                if (response1Data.PERatio.ToString().Equals("None") || response2Data.PERatio.ToString().Equals("None"))
                    labelDiffPE.Text = "N/A";
                else
                    labelDiffPE.Text = String.Format("{0:0.000000}", ((double)response1Data.PERatio / (double)response2Data.PERatio));

                labelDiffMC.Text = String.Format("{0:0.000000}", ((double)response1Data.MarketCapitalization / (double)response2Data.MarketCapitalization));
                labelDiffQR.Text = String.Format("{0:0.000000}", (ticker1QR / ticker2QR));
            }
            catch (HttpRequestException)
            {
                labelErrorMessageFundamentals.Text = "There was a problem retrieving the requested stock data. Please try again.";
            }
            catch (Exception)
            {
                labelErrorMessageFundamentals.Text = "A Stock Ticker provided was not found. Please check the entered text.";
            }
        }

        private void buttonFundamentalsTab_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void buttonTimeSeriesTab_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }
    }
}
