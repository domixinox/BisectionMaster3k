namespace BisectionMaster3k
{
    partial class BisectionMaster3k
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPageData = new TabPage();
            label8 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel10 = new Panel();
            label3 = new Label();
            inputDeltaErrorMsg = new RichTextBox();
            label27 = new Label();
            textBox2 = new TextBox();
            label26 = new Label();
            panel2 = new Panel();
            ObliczMiejsceZerowe = new Button();
            panel13 = new Panel();
            label25 = new Label();
            inputIterationsErrorMsg = new RichTextBox();
            textBox1 = new TextBox();
            label28 = new Label();
            label29 = new Label();
            panel12 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label23 = new Label();
            inputRangeErrorMsg = new RichTextBox();
            inputRangeX2 = new TextBox();
            label24 = new Label();
            inputRangeX1 = new TextBox();
            label30 = new Label();
            panel14 = new Panel();
            label31 = new Label();
            label32 = new Label();
            label33 = new Label();
            inputPolynomialErrorMsg = new RichTextBox();
            inputPolynomial = new TextBox();
            panel1 = new Panel();
            label22 = new Label();
            tabPageWyniki = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel6 = new Panel();
            label7 = new Label();
            panel5 = new Panel();
            label6 = new Label();
            tabPageGraph = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            formsPlot1 = new ScottPlot.FormsPlot();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            label5 = new Label();
            label4 = new Label();
            CheckMz = new CheckBox();
            CheckPotential = new CheckBox();
            CheckFunction = new CheckBox();
            CheckRange = new CheckBox();
            CheckSpan = new CheckBox();
            CheckMzLine = new CheckBox();
            CheckLegend = new CheckBox();
            panel4 = new Panel();
            label21 = new Label();
            BtnSave = new Button();
            BtnReset = new Button();
            tabPageAbout = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel9 = new Panel();
            label18 = new Label();
            label17 = new Label();
            label14 = new Label();
            label11 = new Label();
            panel8 = new Panel();
            label19 = new Label();
            label16 = new Label();
            label13 = new Label();
            label10 = new Label();
            panel7 = new Panel();
            label20 = new Label();
            label15 = new Label();
            label12 = new Label();
            label9 = new Label();
            tabControl1.SuspendLayout();
            tabPageData.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel10.SuspendLayout();
            panel2.SuspendLayout();
            panel13.SuspendLayout();
            panel12.SuspendLayout();
            panel14.SuspendLayout();
            panel1.SuspendLayout();
            tabPageWyniki.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel6.SuspendLayout();
            tabPageGraph.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            tabPageAbout.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageData);
            tabControl1.Controls.Add(tabPageWyniki);
            tabControl1.Controls.Add(tabPageGraph);
            tabControl1.Controls.Add(tabPageAbout);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(10, 6);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1127, 853);
            tabControl1.TabIndex = 10;
            // 
            // tabPageData
            // 
            tabPageData.Controls.Add(label8);
            tabPageData.Controls.Add(tableLayoutPanel5);
            tabPageData.Location = new Point(4, 38);
            tabPageData.Margin = new Padding(3, 4, 3, 4);
            tabPageData.Name = "tabPageData";
            tabPageData.Padding = new Padding(3, 4, 3, 4);
            tabPageData.Size = new Size(1119, 811);
            tabPageData.TabIndex = 0;
            tabPageData.Text = "Dane";
            tabPageData.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(626, 397);
            label8.Name = "label8";
            label8.Size = new Size(0, 23);
            label8.TabIndex = 101;
            label8.Click += label8_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(panel10, 0, 4);
            tableLayoutPanel5.Controls.Add(panel2, 0, 5);
            tableLayoutPanel5.Controls.Add(panel13, 0, 3);
            tableLayoutPanel5.Controls.Add(panel12, 0, 2);
            tableLayoutPanel5.Controls.Add(panel14, 0, 1);
            tableLayoutPanel5.Controls.Add(panel1, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 6;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.Size = new Size(1113, 803);
            tableLayoutPanel5.TabIndex = 104;
            // 
            // panel10
            // 
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(label3);
            panel10.Controls.Add(inputDeltaErrorMsg);
            panel10.Controls.Add(label27);
            panel10.Controls.Add(textBox2);
            panel10.Controls.Add(label26);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(3, 563);
            panel10.Name = "panel10";
            panel10.Size = new Size(1107, 154);
            panel10.TabIndex = 0;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(-8, 40);
            label3.Name = "label3";
            label3.Size = new Size(1123, 11);
            label3.TabIndex = 5;
            // 
            // inputDeltaErrorMsg
            // 
            inputDeltaErrorMsg.ForeColor = Color.ForestGreen;
            inputDeltaErrorMsg.Location = new Point(586, 55);
            inputDeltaErrorMsg.Margin = new Padding(3, 4, 3, 4);
            inputDeltaErrorMsg.Name = "inputDeltaErrorMsg";
            inputDeltaErrorMsg.Size = new Size(508, 85);
            inputDeltaErrorMsg.TabIndex = 100;
            inputDeltaErrorMsg.TabStop = false;
            inputDeltaErrorMsg.Text = "Wszystko dobrze";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label27.Location = new Point(5, 5);
            label27.Name = "label27";
            label27.Size = new Size(358, 28);
            label27.TabIndex = 4;
            label27.Text = "Maksymalny błąd miesjca zerowego:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(140, 55);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(440, 30);
            textBox2.TabIndex = 5;
            textBox2.Text = "0.0001";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label26.Location = new Point(5, 58);
            label26.Name = "label26";
            label26.Size = new Size(140, 23);
            label26.TabIndex = 100;
            label26.Text = "rząd wielności =";
            // 
            // panel2
            // 
            panel2.Controls.Add(ObliczMiejsceZerowe);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 724);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1107, 75);
            panel2.TabIndex = 100;
            // 
            // ObliczMiejsceZerowe
            // 
            ObliczMiejsceZerowe.AutoSize = true;
            ObliczMiejsceZerowe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ObliczMiejsceZerowe.Location = new Point(860, 15);
            ObliczMiejsceZerowe.Margin = new Padding(3, 4, 3, 4);
            ObliczMiejsceZerowe.Name = "ObliczMiejsceZerowe";
            ObliczMiejsceZerowe.Size = new Size(239, 44);
            ObliczMiejsceZerowe.TabIndex = 4;
            ObliczMiejsceZerowe.Text = "Znajdź Miejsce Zerowe";
            ObliczMiejsceZerowe.UseVisualStyleBackColor = true;
            ObliczMiejsceZerowe.Click += ObliczMiejsceZerowe_Click;
            // 
            // panel13
            // 
            panel13.BorderStyle = BorderStyle.FixedSingle;
            panel13.Controls.Add(label25);
            panel13.Controls.Add(inputIterationsErrorMsg);
            panel13.Controls.Add(textBox1);
            panel13.Controls.Add(label28);
            panel13.Controls.Add(label29);
            panel13.Dock = DockStyle.Fill;
            panel13.Location = new Point(3, 403);
            panel13.Name = "panel13";
            panel13.Size = new Size(1107, 154);
            panel13.TabIndex = 1;
            // 
            // label25
            // 
            label25.BorderStyle = BorderStyle.Fixed3D;
            label25.Location = new Point(-8, 40);
            label25.Name = "label25";
            label25.Size = new Size(1123, 11);
            label25.TabIndex = 102;
            // 
            // inputIterationsErrorMsg
            // 
            inputIterationsErrorMsg.ForeColor = Color.ForestGreen;
            inputIterationsErrorMsg.Location = new Point(586, 55);
            inputIterationsErrorMsg.Margin = new Padding(3, 4, 3, 4);
            inputIterationsErrorMsg.Name = "inputIterationsErrorMsg";
            inputIterationsErrorMsg.Size = new Size(508, 85);
            inputIterationsErrorMsg.TabIndex = 100;
            inputIterationsErrorMsg.TabStop = false;
            inputIterationsErrorMsg.Text = "Wszystko dobrze";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(87, 55);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(493, 30);
            textBox1.TabIndex = 6;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label28.Location = new Point(5, 5);
            label28.Name = "label28";
            label28.Size = new Size(269, 28);
            label28.TabIndex = 101;
            label28.Text = "Maksymalna liczba iteracji:";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label29.Location = new Point(5, 58);
            label29.Name = "label29";
            label29.Size = new Size(86, 23);
            label29.TabIndex = 103;
            label29.Text = "iteracje =";
            // 
            // panel12
            // 
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.Controls.Add(label2);
            panel12.Controls.Add(label1);
            panel12.Controls.Add(label23);
            panel12.Controls.Add(inputRangeErrorMsg);
            panel12.Controls.Add(inputRangeX2);
            panel12.Controls.Add(label24);
            panel12.Controls.Add(inputRangeX1);
            panel12.Controls.Add(label30);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(3, 243);
            panel12.Name = "panel12";
            panel12.Size = new Size(1107, 154);
            panel12.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(308, 62);
            label2.Name = "label2";
            label2.Size = new Size(15, 23);
            label2.TabIndex = 108;
            label2.Text = ",";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(565, 58);
            label1.Name = "label1";
            label1.Size = new Size(16, 23);
            label1.TabIndex = 107;
            label1.Text = ")";
            // 
            // label23
            // 
            label23.BorderStyle = BorderStyle.Fixed3D;
            label23.Location = new Point(-8, 40);
            label23.Name = "label23";
            label23.Size = new Size(1123, 11);
            label23.TabIndex = 105;
            // 
            // inputRangeErrorMsg
            // 
            inputRangeErrorMsg.ForeColor = Color.ForestGreen;
            inputRangeErrorMsg.Location = new Point(586, 55);
            inputRangeErrorMsg.Margin = new Padding(3, 4, 3, 4);
            inputRangeErrorMsg.Name = "inputRangeErrorMsg";
            inputRangeErrorMsg.Size = new Size(508, 85);
            inputRangeErrorMsg.TabIndex = 100;
            inputRangeErrorMsg.TabStop = false;
            inputRangeErrorMsg.Text = "Wszystko dobrze";
            // 
            // inputRangeX2
            // 
            inputRangeX2.Location = new Point(325, 55);
            inputRangeX2.Margin = new Padding(3, 4, 3, 4);
            inputRangeX2.Name = "inputRangeX2";
            inputRangeX2.Size = new Size(240, 30);
            inputRangeX2.TabIndex = 7;
            inputRangeX2.Text = "100";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label24.Location = new Point(5, 5);
            label24.Name = "label24";
            label24.Size = new Size(244, 28);
            label24.TabIndex = 104;
            label24.Text = "Przedział sprawdzania x:";
            // 
            // inputRangeX1
            // 
            inputRangeX1.Location = new Point(65, 55);
            inputRangeX1.Margin = new Padding(3, 4, 3, 4);
            inputRangeX1.Name = "inputRangeX1";
            inputRangeX1.Size = new Size(240, 30);
            inputRangeX1.TabIndex = 8;
            inputRangeX1.Text = "0";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label30.Location = new Point(15, 58);
            label30.Name = "label30";
            label30.Size = new Size(48, 23);
            label30.TabIndex = 106;
            label30.Text = "x ∈ (";
            // 
            // panel14
            // 
            panel14.BorderStyle = BorderStyle.FixedSingle;
            panel14.Controls.Add(label31);
            panel14.Controls.Add(label32);
            panel14.Controls.Add(label33);
            panel14.Controls.Add(inputPolynomialErrorMsg);
            panel14.Controls.Add(inputPolynomial);
            panel14.Dock = DockStyle.Fill;
            panel14.Location = new Point(3, 83);
            panel14.Name = "panel14";
            panel14.Size = new Size(1107, 154);
            panel14.TabIndex = 3;
            // 
            // label31
            // 
            label31.BorderStyle = BorderStyle.Fixed3D;
            label31.Location = new Point(-8, 40);
            label31.Name = "label31";
            label31.Size = new Size(1123, 11);
            label31.TabIndex = 108;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label32.Location = new Point(5, 5);
            label32.Name = "label32";
            label32.Size = new Size(89, 28);
            label32.TabIndex = 107;
            label32.Text = "Funkcja:";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label33.Location = new Point(10, 58);
            label33.Name = "label33";
            label33.Size = new Size(55, 23);
            label33.TabIndex = 109;
            label33.Text = "f(x) =";
            // 
            // inputPolynomialErrorMsg
            // 
            inputPolynomialErrorMsg.ForeColor = Color.ForestGreen;
            inputPolynomialErrorMsg.Location = new Point(586, 55);
            inputPolynomialErrorMsg.Margin = new Padding(3, 4, 3, 4);
            inputPolynomialErrorMsg.Name = "inputPolynomialErrorMsg";
            inputPolynomialErrorMsg.Size = new Size(508, 85);
            inputPolynomialErrorMsg.TabIndex = 100;
            inputPolynomialErrorMsg.TabStop = false;
            inputPolynomialErrorMsg.Text = "Wszystko dobrze";
            // 
            // inputPolynomial
            // 
            inputPolynomial.Location = new Point(65, 55);
            inputPolynomial.Margin = new Padding(3, 4, 3, 4);
            inputPolynomial.Name = "inputPolynomial";
            inputPolynomial.Size = new Size(515, 30);
            inputPolynomial.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(label22);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1107, 74);
            panel1.TabIndex = 101;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(6, 10);
            label22.Name = "label22";
            label22.Size = new Size(715, 54);
            label22.TabIndex = 3;
            label22.Text = "Bisekcja - wprowadź potrzebne dane";
            // 
            // tabPageWyniki
            // 
            tabPageWyniki.Controls.Add(tableLayoutPanel4);
            tabPageWyniki.Location = new Point(4, 38);
            tabPageWyniki.Margin = new Padding(3, 4, 3, 4);
            tabPageWyniki.Name = "tabPageWyniki";
            tabPageWyniki.Padding = new Padding(3, 4, 3, 4);
            tabPageWyniki.Size = new Size(1119, 811);
            tabPageWyniki.TabIndex = 1;
            tabPageWyniki.Text = "Wyniki";
            tabPageWyniki.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(panel6, 0, 1);
            tableLayoutPanel4.Controls.Add(panel5, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.Size = new Size(1113, 803);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(label7);
            panel6.Controls.Add(label6);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 83);
            panel6.Name = "panel6";
            panel6.Size = new Size(1107, 315);
            panel6.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(87, 60);
            label7.Name = "label7";
            label7.Size = new Size(0, 23);
            label7.TabIndex = 9;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(1107, 74);
            panel5.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(658, 73);
            label6.Name = "label6";
            label6.Size = new Size(359, 115);
            label6.TabIndex = 8;
            label6.Text = "Wynik ma zwracać:\r\n- wartość Mz\r\n- liczbe iteracji wyznaczającej Mz\r\n- wartość f(x) dla Mz \r\nPS: Można zmienić nazwę zakładki na Wyniki?\r\n";
            // 
            // tabPageGraph
            // 
            tabPageGraph.Controls.Add(tableLayoutPanel1);
            tabPageGraph.Location = new Point(4, 38);
            tabPageGraph.Name = "tabPageGraph";
            tabPageGraph.Padding = new Padding(3);
            tabPageGraph.Size = new Size(1119, 811);
            tabPageGraph.TabIndex = 3;
            tabPageGraph.Text = "Wykres";
            tabPageGraph.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(formsPlot1, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Size = new Size(1113, 805);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // formsPlot1
            // 
            formsPlot1.Dock = DockStyle.Fill;
            formsPlot1.Location = new Point(7, 168);
            formsPlot1.Margin = new Padding(7);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(1099, 630);
            formsPlot1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 21F));
            tableLayoutPanel2.Controls.Add(panel3, 0, 1);
            tableLayoutPanel2.Controls.Add(panel4, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1107, 155);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(CheckMz);
            panel3.Controls.Add(CheckPotential);
            panel3.Controls.Add(CheckFunction);
            panel3.Controls.Add(CheckRange);
            panel3.Controls.Add(CheckSpan);
            panel3.Controls.Add(CheckMzLine);
            panel3.Controls.Add(CheckLegend);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 80);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(15);
            panel3.Size = new Size(1101, 72);
            panel3.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 0);
            label5.Name = "label5";
            label5.Size = new Size(191, 23);
            label5.TabIndex = 7;
            label5.Text = "Ustawienia wyświetlania";
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(-9, 69);
            label4.Name = "label4";
            label4.Size = new Size(1123, 11);
            label4.TabIndex = 3;
            // 
            // CheckMz
            // 
            CheckMz.AutoSize = true;
            CheckMz.Checked = true;
            CheckMz.CheckState = CheckState.Checked;
            CheckMz.Dock = DockStyle.Left;
            CheckMz.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            CheckMz.Location = new Point(858, 15);
            CheckMz.Name = "CheckMz";
            CheckMz.Padding = new Padding(15, 5, 15, 0);
            CheckMz.Size = new Size(183, 40);
            CheckMz.TabIndex = 6;
            CheckMz.Text = "Miejsce zerowe";
            CheckMz.UseVisualStyleBackColor = true;
            CheckMz.CheckedChanged += CheckMz_CheckedChanged;
            // 
            // CheckPotential
            // 
            CheckPotential.AutoSize = true;
            CheckPotential.Checked = true;
            CheckPotential.CheckState = CheckState.Checked;
            CheckPotential.Dock = DockStyle.Left;
            CheckPotential.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            CheckPotential.Location = new Point(642, 15);
            CheckPotential.Name = "CheckPotential";
            CheckPotential.Padding = new Padding(15, 5, 15, 0);
            CheckPotential.Size = new Size(216, 40);
            CheckPotential.TabIndex = 5;
            CheckPotential.Text = "Punkty potencjalne";
            CheckPotential.UseVisualStyleBackColor = true;
            CheckPotential.CheckedChanged += CheckPotential_CheckedChanged;
            // 
            // CheckFunction
            // 
            CheckFunction.AutoSize = true;
            CheckFunction.Checked = true;
            CheckFunction.CheckState = CheckState.Checked;
            CheckFunction.Dock = DockStyle.Left;
            CheckFunction.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            CheckFunction.Location = new Point(519, 15);
            CheckFunction.Name = "CheckFunction";
            CheckFunction.Padding = new Padding(15, 5, 15, 0);
            CheckFunction.Size = new Size(123, 40);
            CheckFunction.TabIndex = 4;
            CheckFunction.Text = "Funkcja";
            CheckFunction.UseVisualStyleBackColor = true;
            CheckFunction.CheckedChanged += CheckFunction_CheckedChanged;
            // 
            // CheckRange
            // 
            CheckRange.AutoSize = true;
            CheckRange.Checked = true;
            CheckRange.CheckState = CheckState.Checked;
            CheckRange.Dock = DockStyle.Left;
            CheckRange.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            CheckRange.Location = new Point(397, 15);
            CheckRange.Name = "CheckRange";
            CheckRange.Padding = new Padding(15, 5, 15, 0);
            CheckRange.Size = new Size(122, 40);
            CheckRange.TabIndex = 3;
            CheckRange.Text = "Granice";
            CheckRange.UseVisualStyleBackColor = true;
            CheckRange.CheckedChanged += CheckRange_CheckedChanged;
            // 
            // CheckSpan
            // 
            CheckSpan.AutoSize = true;
            CheckSpan.Checked = true;
            CheckSpan.CheckState = CheckState.Checked;
            CheckSpan.Dock = DockStyle.Left;
            CheckSpan.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            CheckSpan.Location = new Point(285, 15);
            CheckSpan.Name = "CheckSpan";
            CheckSpan.Padding = new Padding(15, 5, 15, 0);
            CheckSpan.Size = new Size(112, 40);
            CheckSpan.TabIndex = 2;
            CheckSpan.Text = "Siatka";
            CheckSpan.UseVisualStyleBackColor = true;
            CheckSpan.CheckedChanged += CheckSpan_CheckedChanged;
            // 
            // CheckMzLine
            // 
            CheckMzLine.AutoSize = true;
            CheckMzLine.Checked = true;
            CheckMzLine.CheckState = CheckState.Checked;
            CheckMzLine.Dock = DockStyle.Left;
            CheckMzLine.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            CheckMzLine.Location = new Point(130, 15);
            CheckMzLine.Name = "CheckMzLine";
            CheckMzLine.Padding = new Padding(15, 5, 15, 0);
            CheckMzLine.Size = new Size(155, 40);
            CheckMzLine.TabIndex = 1;
            CheckMzLine.Text = "Linia f(x)=0";
            CheckMzLine.UseVisualStyleBackColor = true;
            CheckMzLine.CheckedChanged += CheckMzLine_CheckedChanged;
            // 
            // CheckLegend
            // 
            CheckLegend.AutoSize = true;
            CheckLegend.Checked = true;
            CheckLegend.CheckState = CheckState.Checked;
            CheckLegend.Dock = DockStyle.Left;
            CheckLegend.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            CheckLegend.Location = new Point(15, 15);
            CheckLegend.Name = "CheckLegend";
            CheckLegend.Padding = new Padding(0, 5, 15, 0);
            CheckLegend.Size = new Size(115, 40);
            CheckLegend.TabIndex = 0;
            CheckLegend.Text = "Legenda";
            CheckLegend.UseVisualStyleBackColor = true;
            CheckLegend.CheckedChanged += CheckLegend_CheckedChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(label21);
            panel4.Controls.Add(BtnSave);
            panel4.Controls.Add(BtnReset);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(15);
            panel4.Size = new Size(1101, 71);
            panel4.TabIndex = 1;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(317, 5);
            label21.Name = "label21";
            label21.Size = new Size(452, 54);
            label21.TabIndex = 2;
            label21.Text = "Zarządzanie wykresem";
            // 
            // BtnSave
            // 
            BtnSave.AutoSize = true;
            BtnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSave.Location = new Point(865, 5);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(231, 51);
            BtnSave.TabIndex = 1;
            BtnSave.Text = "Zapisz jako obraz...";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnReset
            // 
            BtnReset.AutoSize = true;
            BtnReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnReset.Location = new Point(5, 5);
            BtnReset.Name = "BtnReset";
            BtnReset.Size = new Size(202, 51);
            BtnReset.TabIndex = 0;
            BtnReset.Text = "Reset ustawień";
            BtnReset.UseVisualStyleBackColor = true;
            BtnReset.Click += BtnReset_Click;
            // 
            // tabPageAbout
            // 
            tabPageAbout.Controls.Add(tableLayoutPanel3);
            tabPageAbout.Location = new Point(4, 38);
            tabPageAbout.Margin = new Padding(3, 4, 3, 4);
            tabPageAbout.Name = "tabPageAbout";
            tabPageAbout.Size = new Size(1119, 811);
            tabPageAbout.TabIndex = 2;
            tabPageAbout.Text = "O Programie";
            tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panel9, 0, 2);
            tableLayoutPanel3.Controls.Add(panel8, 0, 1);
            tableLayoutPanel3.Controls.Add(panel7, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(1119, 811);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.AutoSize = true;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(label18);
            panel9.Controls.Add(label17);
            panel9.Controls.Add(label14);
            panel9.Controls.Add(label11);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(3, 407);
            panel9.Name = "panel9";
            panel9.Size = new Size(1113, 401);
            panel9.TabIndex = 2;
            // 
            // label18
            // 
            label18.BorderStyle = BorderStyle.Fixed3D;
            label18.Location = new Point(-5, 0);
            label18.Name = "label18";
            label18.Size = new Size(1123, 11);
            label18.TabIndex = 5;
            // 
            // label17
            // 
            label17.BorderStyle = BorderStyle.Fixed3D;
            label17.Location = new Point(-15, 40);
            label17.Name = "label17";
            label17.Size = new Size(1123, 11);
            label17.TabIndex = 4;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(16, 51);
            label14.Name = "label14";
            label14.Size = new Size(208, 23);
            label14.TabIndex = 3;
            label14.Text = "ScottPlot.WinForms 4.1.70";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(5, 5);
            label11.Name = "label11";
            label11.Size = new Size(224, 28);
            label11.TabIndex = 2;
            label11.Text = "Bliblioteki zewnętrzne";
            // 
            // panel8
            // 
            panel8.AutoSize = true;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(label19);
            panel8.Controls.Add(label16);
            panel8.Controls.Add(label13);
            panel8.Controls.Add(label10);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(3, 205);
            panel8.Name = "panel8";
            panel8.Size = new Size(1113, 196);
            panel8.TabIndex = 1;
            // 
            // label19
            // 
            label19.BorderStyle = BorderStyle.Fixed3D;
            label19.Location = new Point(-5, 0);
            label19.Name = "label19";
            label19.Size = new Size(1123, 11);
            label19.TabIndex = 5;
            // 
            // label16
            // 
            label16.BorderStyle = BorderStyle.Fixed3D;
            label16.Location = new Point(-10, 40);
            label16.Name = "label16";
            label16.Size = new Size(1123, 11);
            label16.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(16, 51);
            label13.Name = "label13";
            label13.Size = new Size(511, 92);
            label13.TabIndex = 2;
            label13.Text = "WYDZIAŁ INŻYNIERII ŚRODOWISKA i INŻYNIERII MECHANICZNEJ\r\nInformatyka Stosowana, rok III\r\n\r\nBut Dominik, Malicki Kacper, Klak Aleksander";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(5, 5);
            label10.Name = "label10";
            label10.Size = new Size(186, 28);
            label10.TabIndex = 1;
            label10.Text = "Autorzy programu";
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label20);
            panel7.Controls.Add(label15);
            panel7.Controls.Add(label12);
            panel7.Controls.Add(label9);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(1113, 196);
            panel7.TabIndex = 0;
            // 
            // label20
            // 
            label20.BorderStyle = BorderStyle.Fixed3D;
            label20.Location = new Point(-5, 0);
            label20.Name = "label20";
            label20.Size = new Size(1123, 11);
            label20.TabIndex = 5;
            // 
            // label15
            // 
            label15.BorderStyle = BorderStyle.Fixed3D;
            label15.Location = new Point(-7, 40);
            label15.Name = "label15";
            label15.Size = new Size(1123, 11);
            label15.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 51);
            label12.Name = "label12";
            label12.Size = new Size(77, 23);
            label12.TabIndex = 1;
            label12.Text = "Bisekcja?";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(5, 5);
            label9.Name = "label9";
            label9.Size = new Size(445, 28);
            label9.TabIndex = 0;
            label9.Text = "Użyta metoda wyznaczania miejsca zerowego";
            // 
            // BisectionMaster3k
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 853);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BisectionMaster3k";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BisectionMaster3k";
            tabControl1.ResumeLayout(false);
            tabPageData.ResumeLayout(false);
            tabPageData.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPageWyniki.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            tabPageGraph.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tabPageAbout.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageData;
        private TabPage tabPageWyniki;
        private Button ObliczMiejsceZerowe;
        private TabPage tabPageAbout;
        private TextBox inputRangeX2;
        private TextBox inputRangeX1;
        private RichTextBox inputRangeErrorMsg;
        private Panel panel2;
        private TabPage tabPageGraph;
        private ScottPlot.FormsPlot formsPlot1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private Panel panel4;
        private CheckBox CheckLegend;
        private Button BtnReset;
        private CheckBox CheckMzLine;
        private CheckBox CheckSpan;
        private CheckBox CheckRange;
        private CheckBox CheckFunction;
        private CheckBox CheckPotential;
        private CheckBox CheckMz;
        private Button BtnSave;
        private Label label4;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel5;
        private Panel panel6;
        private Label label7;
        private Label label6;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel9;
        private Label label11;
        private Panel panel8;
        private Label label10;
        private Panel panel7;
        private Label label9;
        private Label label13;
        private Label label12;
        private Label label14;
        private Label label16;
        private Label label15;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private RichTextBox inputPolynomialErrorMsg;
        private TextBox inputPolynomial;
        private RichTextBox inputIterationsErrorMsg;
        private TextBox textBox1;
        private RichTextBox inputDeltaErrorMsg;
        private Label label26;
        private TextBox textBox2;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel10;
        private Label label3;
        private Label label27;
        private Panel panel13;
        private Label label25;
        private Label label28;
        private Label label29;
        private Panel panel12;
        private Label label23;
        private Label label24;
        private Label label30;
        private Panel panel14;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label21;
        private Label label22;
    }
}