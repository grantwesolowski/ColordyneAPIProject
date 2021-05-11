namespace Colordyne__Time_Series_Plotter_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tickerTSTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRunTSPlot = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.buttonFundamentalsTab = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelErrorMessageFundamentals = new System.Windows.Forms.Label();
            this.tableFundamentals = new System.Windows.Forms.TableLayoutPanel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.labelDiffMC = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.labelTicker2MC = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.labelMarketCap = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.labelDiffQR = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.labelTicker2QR = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.labelTicker1QR = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelTicker1PE = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.labelQuickRatio = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.labelDiffPE = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.labelTicker2PE = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelPE = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelPercentDiff = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTicker2Table = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTicker1Table = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.labelTicker1MC = new System.Windows.Forms.Label();
            this.labelTicker2 = new System.Windows.Forms.Label();
            this.textBoxTicker2 = new System.Windows.Forms.TextBox();
            this.buttonRunFundamentals = new System.Windows.Forms.Button();
            this.labelTicker1 = new System.Windows.Forms.Label();
            this.textBoxTicker1 = new System.Windows.Forms.TextBox();
            this.buttonTimeSeriesTab = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableFundamentals.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // tickerTSTextBox
            // 
            this.tickerTSTextBox.Location = new System.Drawing.Point(680, 65);
            this.tickerTSTextBox.Name = "tickerTSTextBox";
            this.tickerTSTextBox.Size = new System.Drawing.Size(100, 20);
            this.tickerTSTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(698, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ticker";
            // 
            // buttonRunTSPlot
            // 
            this.buttonRunTSPlot.Location = new System.Drawing.Point(702, 91);
            this.buttonRunTSPlot.Name = "buttonRunTSPlot";
            this.buttonRunTSPlot.Size = new System.Drawing.Size(58, 24);
            this.buttonRunTSPlot.TabIndex = 3;
            this.buttonRunTSPlot.Text = "RUN";
            this.buttonRunTSPlot.UseVisualStyleBackColor = true;
            this.buttonRunTSPlot.Click += new System.EventHandler(this.buttonRunTSPlot_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, -20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 472);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPage1.Controls.Add(this.cartesianChart1);
            this.tabPage1.Controls.Add(this.labelErrorMessage);
            this.tabPage1.Controls.Add(this.buttonFundamentalsTab);
            this.tabPage1.Controls.Add(this.buttonRunTSPlot);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tickerTSTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(794, 446);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cartesianChart1.Location = new System.Drawing.Point(12, 22);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(662, 300);
            this.cartesianChart1.TabIndex = 5;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.AutoSize = true;
            this.labelErrorMessage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.labelErrorMessage.Location = new System.Drawing.Point(10, 342);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Size = new System.Drawing.Size(0, 24);
            this.labelErrorMessage.TabIndex = 5;
            // 
            // buttonFundamentalsTab
            // 
            this.buttonFundamentalsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFundamentalsTab.Location = new System.Drawing.Point(638, 379);
            this.buttonFundamentalsTab.Name = "buttonFundamentalsTab";
            this.buttonFundamentalsTab.Size = new System.Drawing.Size(139, 27);
            this.buttonFundamentalsTab.TabIndex = 4;
            this.buttonFundamentalsTab.Text = "Fundamentals";
            this.buttonFundamentalsTab.UseVisualStyleBackColor = true;
            this.buttonFundamentalsTab.Click += new System.EventHandler(this.buttonFundamentalsTab_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPage2.Controls.Add(this.labelErrorMessageFundamentals);
            this.tabPage2.Controls.Add(this.tableFundamentals);
            this.tabPage2.Controls.Add(this.labelTicker2);
            this.tabPage2.Controls.Add(this.textBoxTicker2);
            this.tabPage2.Controls.Add(this.buttonRunFundamentals);
            this.tabPage2.Controls.Add(this.labelTicker1);
            this.tabPage2.Controls.Add(this.textBoxTicker1);
            this.tabPage2.Controls.Add(this.buttonTimeSeriesTab);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(794, 438);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // labelErrorMessageFundamentals
            // 
            this.labelErrorMessageFundamentals.AutoSize = true;
            this.labelErrorMessageFundamentals.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelErrorMessageFundamentals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorMessageFundamentals.ForeColor = System.Drawing.Color.Red;
            this.labelErrorMessageFundamentals.Location = new System.Drawing.Point(10, 342);
            this.labelErrorMessageFundamentals.Name = "labelErrorMessageFundamentals";
            this.labelErrorMessageFundamentals.Size = new System.Drawing.Size(0, 24);
            this.labelErrorMessageFundamentals.TabIndex = 10;
            // 
            // tableFundamentals
            // 
            this.tableFundamentals.BackColor = System.Drawing.SystemColors.Control;
            this.tableFundamentals.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableFundamentals.ColumnCount = 4;
            this.tableFundamentals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableFundamentals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableFundamentals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableFundamentals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableFundamentals.Controls.Add(this.panel16, 3, 3);
            this.tableFundamentals.Controls.Add(this.panel15, 2, 3);
            this.tableFundamentals.Controls.Add(this.panel13, 0, 3);
            this.tableFundamentals.Controls.Add(this.panel12, 3, 2);
            this.tableFundamentals.Controls.Add(this.panel11, 2, 2);
            this.tableFundamentals.Controls.Add(this.panel10, 1, 2);
            this.tableFundamentals.Controls.Add(this.panel6, 1, 1);
            this.tableFundamentals.Controls.Add(this.panel9, 0, 2);
            this.tableFundamentals.Controls.Add(this.panel8, 3, 1);
            this.tableFundamentals.Controls.Add(this.panel7, 2, 1);
            this.tableFundamentals.Controls.Add(this.panel5, 0, 1);
            this.tableFundamentals.Controls.Add(this.panel4, 3, 0);
            this.tableFundamentals.Controls.Add(this.panel3, 2, 0);
            this.tableFundamentals.Controls.Add(this.panel2, 1, 0);
            this.tableFundamentals.Controls.Add(this.panel1, 0, 0);
            this.tableFundamentals.Controls.Add(this.panel14, 1, 3);
            this.tableFundamentals.Location = new System.Drawing.Point(9, 105);
            this.tableFundamentals.Name = "tableFundamentals";
            this.tableFundamentals.RowCount = 4;
            this.tableFundamentals.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableFundamentals.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableFundamentals.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableFundamentals.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableFundamentals.Size = new System.Drawing.Size(776, 152);
            this.tableFundamentals.TabIndex = 9;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel16.Controls.Add(this.labelDiffMC);
            this.panel16.Location = new System.Drawing.Point(583, 115);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(189, 32);
            this.panel16.TabIndex = 11;
            // 
            // labelDiffMC
            // 
            this.labelDiffMC.AutoSize = true;
            this.labelDiffMC.BackColor = System.Drawing.Color.Transparent;
            this.labelDiffMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiffMC.ForeColor = System.Drawing.Color.Black;
            this.labelDiffMC.Location = new System.Drawing.Point(3, 3);
            this.labelDiffMC.Name = "labelDiffMC";
            this.labelDiffMC.Size = new System.Drawing.Size(0, 25);
            this.labelDiffMC.TabIndex = 18;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel15.Controls.Add(this.labelTicker2MC);
            this.panel15.Location = new System.Drawing.Point(390, 115);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(186, 32);
            this.panel15.TabIndex = 11;
            // 
            // labelTicker2MC
            // 
            this.labelTicker2MC.AutoSize = true;
            this.labelTicker2MC.BackColor = System.Drawing.Color.Transparent;
            this.labelTicker2MC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicker2MC.ForeColor = System.Drawing.Color.Black;
            this.labelTicker2MC.Location = new System.Drawing.Point(3, 3);
            this.labelTicker2MC.Name = "labelTicker2MC";
            this.labelTicker2MC.Size = new System.Drawing.Size(0, 24);
            this.labelTicker2MC.TabIndex = 18;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel13.Controls.Add(this.labelMarketCap);
            this.panel13.Location = new System.Drawing.Point(4, 115);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(186, 32);
            this.panel13.TabIndex = 11;
            // 
            // labelMarketCap
            // 
            this.labelMarketCap.AutoSize = true;
            this.labelMarketCap.BackColor = System.Drawing.Color.Transparent;
            this.labelMarketCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarketCap.ForeColor = System.Drawing.Color.Black;
            this.labelMarketCap.Location = new System.Drawing.Point(3, 3);
            this.labelMarketCap.Name = "labelMarketCap";
            this.labelMarketCap.Size = new System.Drawing.Size(123, 25);
            this.labelMarketCap.TabIndex = 15;
            this.labelMarketCap.Text = "Market Cap";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel12.Controls.Add(this.labelDiffQR);
            this.panel12.Location = new System.Drawing.Point(583, 78);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(189, 30);
            this.panel12.TabIndex = 11;
            // 
            // labelDiffQR
            // 
            this.labelDiffQR.AutoSize = true;
            this.labelDiffQR.BackColor = System.Drawing.Color.Transparent;
            this.labelDiffQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiffQR.ForeColor = System.Drawing.Color.Black;
            this.labelDiffQR.Location = new System.Drawing.Point(3, 3);
            this.labelDiffQR.Name = "labelDiffQR";
            this.labelDiffQR.Size = new System.Drawing.Size(0, 25);
            this.labelDiffQR.TabIndex = 17;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel11.Controls.Add(this.labelTicker2QR);
            this.panel11.Location = new System.Drawing.Point(390, 78);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(186, 30);
            this.panel11.TabIndex = 11;
            // 
            // labelTicker2QR
            // 
            this.labelTicker2QR.AutoSize = true;
            this.labelTicker2QR.BackColor = System.Drawing.Color.Transparent;
            this.labelTicker2QR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicker2QR.ForeColor = System.Drawing.Color.Black;
            this.labelTicker2QR.Location = new System.Drawing.Point(3, 3);
            this.labelTicker2QR.Name = "labelTicker2QR";
            this.labelTicker2QR.Size = new System.Drawing.Size(0, 25);
            this.labelTicker2QR.TabIndex = 17;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel10.Controls.Add(this.labelTicker1QR);
            this.panel10.Location = new System.Drawing.Point(197, 78);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(186, 30);
            this.panel10.TabIndex = 11;
            // 
            // labelTicker1QR
            // 
            this.labelTicker1QR.AutoSize = true;
            this.labelTicker1QR.BackColor = System.Drawing.Color.Transparent;
            this.labelTicker1QR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicker1QR.ForeColor = System.Drawing.Color.Black;
            this.labelTicker1QR.Location = new System.Drawing.Point(3, 3);
            this.labelTicker1QR.Name = "labelTicker1QR";
            this.labelTicker1QR.Size = new System.Drawing.Size(0, 25);
            this.labelTicker1QR.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel6.Controls.Add(this.labelTicker1PE);
            this.panel6.Location = new System.Drawing.Point(197, 41);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(186, 30);
            this.panel6.TabIndex = 11;
            // 
            // labelTicker1PE
            // 
            this.labelTicker1PE.AutoSize = true;
            this.labelTicker1PE.BackColor = System.Drawing.Color.Transparent;
            this.labelTicker1PE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicker1PE.ForeColor = System.Drawing.Color.Black;
            this.labelTicker1PE.Location = new System.Drawing.Point(3, 3);
            this.labelTicker1PE.Name = "labelTicker1PE";
            this.labelTicker1PE.Size = new System.Drawing.Size(0, 25);
            this.labelTicker1PE.TabIndex = 15;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel9.Controls.Add(this.labelQuickRatio);
            this.panel9.Location = new System.Drawing.Point(4, 78);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(186, 30);
            this.panel9.TabIndex = 11;
            // 
            // labelQuickRatio
            // 
            this.labelQuickRatio.AutoSize = true;
            this.labelQuickRatio.BackColor = System.Drawing.Color.Transparent;
            this.labelQuickRatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuickRatio.ForeColor = System.Drawing.Color.Black;
            this.labelQuickRatio.Location = new System.Drawing.Point(3, 3);
            this.labelQuickRatio.Name = "labelQuickRatio";
            this.labelQuickRatio.Size = new System.Drawing.Size(123, 25);
            this.labelQuickRatio.TabIndex = 14;
            this.labelQuickRatio.Text = "Quick Ratio";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel8.Controls.Add(this.labelDiffPE);
            this.panel8.Location = new System.Drawing.Point(583, 41);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(189, 30);
            this.panel8.TabIndex = 11;
            // 
            // labelDiffPE
            // 
            this.labelDiffPE.AutoSize = true;
            this.labelDiffPE.BackColor = System.Drawing.Color.Transparent;
            this.labelDiffPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiffPE.ForeColor = System.Drawing.Color.Black;
            this.labelDiffPE.Location = new System.Drawing.Point(3, 3);
            this.labelDiffPE.Name = "labelDiffPE";
            this.labelDiffPE.Size = new System.Drawing.Size(0, 25);
            this.labelDiffPE.TabIndex = 16;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel7.Controls.Add(this.labelTicker2PE);
            this.panel7.Location = new System.Drawing.Point(390, 41);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(186, 30);
            this.panel7.TabIndex = 11;
            // 
            // labelTicker2PE
            // 
            this.labelTicker2PE.AutoSize = true;
            this.labelTicker2PE.BackColor = System.Drawing.Color.Transparent;
            this.labelTicker2PE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicker2PE.ForeColor = System.Drawing.Color.Black;
            this.labelTicker2PE.Location = new System.Drawing.Point(3, 3);
            this.labelTicker2PE.Name = "labelTicker2PE";
            this.labelTicker2PE.Size = new System.Drawing.Size(0, 25);
            this.labelTicker2PE.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel5.Controls.Add(this.labelPE);
            this.panel5.Location = new System.Drawing.Point(4, 41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(186, 30);
            this.panel5.TabIndex = 11;
            // 
            // labelPE
            // 
            this.labelPE.AutoSize = true;
            this.labelPE.BackColor = System.Drawing.Color.Transparent;
            this.labelPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPE.ForeColor = System.Drawing.Color.Black;
            this.labelPE.Location = new System.Drawing.Point(3, 3);
            this.labelPE.Name = "labelPE";
            this.labelPE.Size = new System.Drawing.Size(46, 25);
            this.labelPE.TabIndex = 13;
            this.labelPE.Text = "P/E";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Controls.Add(this.labelPercentDiff);
            this.panel4.Location = new System.Drawing.Point(583, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(189, 30);
            this.panel4.TabIndex = 11;
            // 
            // labelPercentDiff
            // 
            this.labelPercentDiff.AutoSize = true;
            this.labelPercentDiff.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelPercentDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPercentDiff.ForeColor = System.Drawing.Color.White;
            this.labelPercentDiff.Location = new System.Drawing.Point(3, 1);
            this.labelPercentDiff.Name = "labelPercentDiff";
            this.labelPercentDiff.Size = new System.Drawing.Size(151, 29);
            this.labelPercentDiff.TabIndex = 13;
            this.labelPercentDiff.Text = "% Difference";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.labelTicker2Table);
            this.panel3.Location = new System.Drawing.Point(390, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(186, 30);
            this.panel3.TabIndex = 11;
            // 
            // labelTicker2Table
            // 
            this.labelTicker2Table.AutoSize = true;
            this.labelTicker2Table.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelTicker2Table.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicker2Table.ForeColor = System.Drawing.Color.White;
            this.labelTicker2Table.Location = new System.Drawing.Point(3, 1);
            this.labelTicker2Table.Name = "labelTicker2Table";
            this.labelTicker2Table.Size = new System.Drawing.Size(100, 29);
            this.labelTicker2Table.TabIndex = 13;
            this.labelTicker2Table.Text = "Ticker 2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.labelTicker1Table);
            this.panel2.Location = new System.Drawing.Point(197, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 30);
            this.panel2.TabIndex = 11;
            // 
            // labelTicker1Table
            // 
            this.labelTicker1Table.AutoSize = true;
            this.labelTicker1Table.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelTicker1Table.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicker1Table.ForeColor = System.Drawing.Color.White;
            this.labelTicker1Table.Location = new System.Drawing.Point(3, 1);
            this.labelTicker1Table.Name = "labelTicker1Table";
            this.labelTicker1Table.Size = new System.Drawing.Size(100, 29);
            this.labelTicker1Table.TabIndex = 12;
            this.labelTicker1Table.Text = "Ticker 1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 30);
            this.panel1.TabIndex = 10;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel14.Controls.Add(this.labelTicker1MC);
            this.panel14.Location = new System.Drawing.Point(197, 115);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(186, 32);
            this.panel14.TabIndex = 11;
            // 
            // labelTicker1MC
            // 
            this.labelTicker1MC.AutoSize = true;
            this.labelTicker1MC.BackColor = System.Drawing.Color.Transparent;
            this.labelTicker1MC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicker1MC.ForeColor = System.Drawing.Color.Black;
            this.labelTicker1MC.Location = new System.Drawing.Point(3, 3);
            this.labelTicker1MC.Name = "labelTicker1MC";
            this.labelTicker1MC.Size = new System.Drawing.Size(0, 24);
            this.labelTicker1MC.TabIndex = 17;
            // 
            // labelTicker2
            // 
            this.labelTicker2.AutoSize = true;
            this.labelTicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicker2.Location = new System.Drawing.Point(154, 29);
            this.labelTicker2.Name = "labelTicker2";
            this.labelTicker2.Size = new System.Drawing.Size(77, 24);
            this.labelTicker2.TabIndex = 8;
            this.labelTicker2.Text = "Ticker 2";
            // 
            // textBoxTicker2
            // 
            this.textBoxTicker2.Location = new System.Drawing.Point(140, 56);
            this.textBoxTicker2.Name = "textBoxTicker2";
            this.textBoxTicker2.Size = new System.Drawing.Size(100, 20);
            this.textBoxTicker2.TabIndex = 7;
            // 
            // buttonRunFundamentals
            // 
            this.buttonRunFundamentals.Location = new System.Drawing.Point(273, 53);
            this.buttonRunFundamentals.Name = "buttonRunFundamentals";
            this.buttonRunFundamentals.Size = new System.Drawing.Size(58, 24);
            this.buttonRunFundamentals.TabIndex = 6;
            this.buttonRunFundamentals.Text = "RUN";
            this.buttonRunFundamentals.UseVisualStyleBackColor = true;
            this.buttonRunFundamentals.Click += new System.EventHandler(this.buttonRunFundamentals_Click);
            // 
            // labelTicker1
            // 
            this.labelTicker1.AutoSize = true;
            this.labelTicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicker1.Location = new System.Drawing.Point(38, 29);
            this.labelTicker1.Name = "labelTicker1";
            this.labelTicker1.Size = new System.Drawing.Size(77, 24);
            this.labelTicker1.TabIndex = 5;
            this.labelTicker1.Text = "Ticker 1";
            // 
            // textBoxTicker1
            // 
            this.textBoxTicker1.Location = new System.Drawing.Point(24, 56);
            this.textBoxTicker1.Name = "textBoxTicker1";
            this.textBoxTicker1.Size = new System.Drawing.Size(100, 20);
            this.textBoxTicker1.TabIndex = 4;
            // 
            // buttonTimeSeriesTab
            // 
            this.buttonTimeSeriesTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimeSeriesTab.Location = new System.Drawing.Point(638, 379);
            this.buttonTimeSeriesTab.Name = "buttonTimeSeriesTab";
            this.buttonTimeSeriesTab.Size = new System.Drawing.Size(139, 27);
            this.buttonTimeSeriesTab.TabIndex = 0;
            this.buttonTimeSeriesTab.Text = "Time Series";
            this.buttonTimeSeriesTab.UseVisualStyleBackColor = true;
            this.buttonTimeSeriesTab.Click += new System.EventHandler(this.buttonTimeSeriesTab_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableFundamentals.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tickerTSTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRunTSPlot;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonFundamentalsTab;
        private System.Windows.Forms.Button buttonTimeSeriesTab;
        private System.Windows.Forms.Label labelTicker2;
        private System.Windows.Forms.TextBox textBoxTicker2;
        private System.Windows.Forms.Button buttonRunFundamentals;
        private System.Windows.Forms.Label labelTicker1;
        private System.Windows.Forms.TextBox textBoxTicker1;
        private System.Windows.Forms.Label labelErrorMessage;
        private System.Windows.Forms.TableLayoutPanel tableFundamentals;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label labelTicker1Table;
        private System.Windows.Forms.Label labelPercentDiff;
        private System.Windows.Forms.Label labelTicker2Table;
        private System.Windows.Forms.Label labelMarketCap;
        private System.Windows.Forms.Label labelQuickRatio;
        private System.Windows.Forms.Label labelPE;
        private System.Windows.Forms.Label labelDiffMC;
        private System.Windows.Forms.Label labelTicker2MC;
        private System.Windows.Forms.Label labelTicker1MC;
        private System.Windows.Forms.Label labelDiffQR;
        private System.Windows.Forms.Label labelTicker2QR;
        private System.Windows.Forms.Label labelTicker1QR;
        private System.Windows.Forms.Label labelTicker1PE;
        private System.Windows.Forms.Label labelDiffPE;
        private System.Windows.Forms.Label labelTicker2PE;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Label labelErrorMessageFundamentals;
    }
}

