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
            tabPage1 = new TabPage();
            panel2 = new Panel();
            ObliczMiejsceZerowe = new Button();
            panel1 = new Panel();
            label1 = new Label();
            inputRangeErrorMsg = new RichTextBox();
            label2 = new Label();
            inputRangeX2 = new TextBox();
            inputRangeX1 = new TextBox();
            tabPage2 = new TabPage();
            tabPage4 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            formsPlot1 = new ScottPlot.FormsPlot();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            CheckLegend = new CheckBox();
            panel4 = new Panel();
            button1 = new Button();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tabPage4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1125, 852);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1117, 819);
            tabPage1.TabIndex = 0;
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(ObliczMiejsceZerowe);
            panel2.Location = new Point(24, 555);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(379, 185);
            panel2.TabIndex = 100;
            // 
            // ObliczMiejsceZerowe
            // 
            ObliczMiejsceZerowe.AutoSize = true;
            ObliczMiejsceZerowe.Location = new Point(18, 131);
            ObliczMiejsceZerowe.Margin = new Padding(3, 4, 3, 4);
            ObliczMiejsceZerowe.Name = "ObliczMiejsceZerowe";
            ObliczMiejsceZerowe.Size = new Size(193, 40);
            ObliczMiejsceZerowe.TabIndex = 1;
            ObliczMiejsceZerowe.Text = "Oblicz Miejsce Zerowe";
            ObliczMiejsceZerowe.UseVisualStyleBackColor = true;
            ObliczMiejsceZerowe.Click += ObliczMiejsceZerowe_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(inputRangeErrorMsg);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(inputRangeX2);
            panel1.Controls.Add(inputRangeX1);
            panel1.Location = new Point(9, 8);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 185);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 100;
            label1.Text = "ZAKRES";
            // 
            // inputRangeErrorMsg
            // 
            inputRangeErrorMsg.Location = new Point(3, 55);
            inputRangeErrorMsg.Margin = new Padding(3, 4, 3, 4);
            inputRangeErrorMsg.Name = "inputRangeErrorMsg";
            inputRangeErrorMsg.Size = new Size(359, 111);
            inputRangeErrorMsg.TabIndex = 100;
            inputRangeErrorMsg.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 20);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 100;
            label2.Text = "x ∈";
            // 
            // inputRangeX2
            // 
            inputRangeX2.Location = new Point(160, 16);
            inputRangeX2.Margin = new Padding(3, 4, 3, 4);
            inputRangeX2.Name = "inputRangeX2";
            inputRangeX2.Size = new Size(114, 27);
            inputRangeX2.TabIndex = 2;
            // 
            // inputRangeX1
            // 
            inputRangeX1.Location = new Point(39, 16);
            inputRangeX1.Margin = new Padding(3, 4, 3, 4);
            inputRangeX1.Name = "inputRangeX1";
            inputRangeX1.Size = new Size(114, 27);
            inputRangeX1.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(1117, 819);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "OUTPUT";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(tableLayoutPanel1);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1117, 819);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Wykres";
            tabPage4.UseVisualStyleBackColor = true;
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
            tableLayoutPanel1.Size = new Size(1111, 813);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // formsPlot1
            // 
            formsPlot1.Dock = DockStyle.Fill;
            formsPlot1.Location = new Point(5, 166);
            formsPlot1.Margin = new Padding(5, 4, 5, 4);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(1101, 643);
            formsPlot1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(panel3, 0, 1);
            tableLayoutPanel2.Controls.Add(panel4, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1105, 156);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(CheckLegend);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 81);
            panel3.Name = "panel3";
            panel3.Size = new Size(1099, 72);
            panel3.TabIndex = 0;
            // 
            // CheckLegend
            // 
            CheckLegend.AutoSize = true;
            CheckLegend.Checked = true;
            CheckLegend.CheckState = CheckState.Checked;
            CheckLegend.Location = new Point(944, 23);
            CheckLegend.Name = "CheckLegend";
            CheckLegend.Size = new Size(127, 24);
            CheckLegend.TabIndex = 0;
            CheckLegend.Text = "Pokaż legendę";
            CheckLegend.UseVisualStyleBackColor = true;
            CheckLegend.CheckedChanged += CheckLegend_CheckedChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(button1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(1099, 72);
            panel4.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(944, 22);
            button1.Name = "button1";
            button1.Size = new Size(127, 38);
            button1.TabIndex = 0;
            button1.Text = "Odśwież";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ObliczMiejsceZerowe_Click;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1117, 819);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "O Programie";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // BisectionMaster3k
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 852);
            Controls.Add(tabControl1);
            Name = "BisectionMaster3k";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BisectionMaster3k";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button ObliczMiejsceZerowe;
        private TabPage tabPage3;
        private TextBox inputRangeX2;
        private Label label1;
        private TextBox inputRangeX1;
        private Label label2;
        private RichTextBox inputRangeErrorMsg;
        private Panel panel1;
        private Panel panel2;
        private TabPage tabPage4;
        private ScottPlot.FormsPlot formsPlot1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private Panel panel4;
        private CheckBox CheckLegend;
        private Button button1;
    }
}