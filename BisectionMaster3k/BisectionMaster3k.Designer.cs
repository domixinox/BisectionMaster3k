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
      panel1 = new Panel();
      label1 = new Label();
      inputRangeErrorMsg = new RichTextBox();
      label2 = new Label();
      inputRangeX2 = new TextBox();
      inputRangeX1 = new TextBox();
      ObliczMiejsceZerowe = new Button();
      tabPage2 = new TabPage();
      tabPage3 = new TabPage();
      panel2 = new Panel();
      tabControl1.SuspendLayout();
      tabPage1.SuspendLayout();
      panel1.SuspendLayout();
      panel2.SuspendLayout();
      SuspendLayout();
      // 
      // tabControl1
      // 
      tabControl1.Controls.Add(tabPage1);
      tabControl1.Controls.Add(tabPage2);
      tabControl1.Controls.Add(tabPage3);
      tabControl1.Dock = DockStyle.Fill;
      tabControl1.Location = new Point(0, 0);
      tabControl1.Name = "tabControl1";
      tabControl1.SelectedIndex = 0;
      tabControl1.Size = new Size(984, 961);
      tabControl1.TabIndex = 0;
      // 
      // tabPage1
      // 
      tabPage1.Controls.Add(panel2);
      tabPage1.Controls.Add(panel1);
      tabPage1.Location = new Point(4, 24);
      tabPage1.Name = "tabPage1";
      tabPage1.Padding = new Padding(3);
      tabPage1.Size = new Size(976, 933);
      tabPage1.TabIndex = 0;
      tabPage1.UseVisualStyleBackColor = true;
      // 
      // panel1
      // 
      panel1.Controls.Add(label1);
      panel1.Controls.Add(inputRangeErrorMsg);
      panel1.Controls.Add(label2);
      panel1.Controls.Add(inputRangeX2);
      panel1.Controls.Add(inputRangeX1);
      panel1.Location = new Point(8, 6);
      panel1.Name = "panel1";
      panel1.Size = new Size(332, 139);
      panel1.TabIndex = 1;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(0, 0);
      label1.Name = "label1";
      label1.Size = new Size(48, 15);
      label1.TabIndex = 100;
      label1.Text = "ZAKRES";
      // 
      // inputRangeErrorMsg
      // 
      inputRangeErrorMsg.Location = new Point(3, 41);
      inputRangeErrorMsg.Name = "inputRangeErrorMsg";
      inputRangeErrorMsg.Size = new Size(315, 84);
      inputRangeErrorMsg.TabIndex = 100;
      inputRangeErrorMsg.Text = "";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(3, 15);
      label2.Name = "label2";
      label2.Size = new Size(25, 15);
      label2.TabIndex = 100;
      label2.Text = "x ∈";
      // 
      // inputRangeX2
      // 
      inputRangeX2.Location = new Point(140, 12);
      inputRangeX2.Name = "inputRangeX2";
      inputRangeX2.Size = new Size(100, 23);
      inputRangeX2.TabIndex = 2;
      // 
      // inputRangeX1
      // 
      inputRangeX1.Location = new Point(34, 12);
      inputRangeX1.Name = "inputRangeX1";
      inputRangeX1.Size = new Size(100, 23);
      inputRangeX1.TabIndex = 1;
      // 
      // ObliczMiejsceZerowe
      // 
      ObliczMiejsceZerowe.AutoSize = true;
      ObliczMiejsceZerowe.Location = new Point(3, 111);
      ObliczMiejsceZerowe.Name = "ObliczMiejsceZerowe";
      ObliczMiejsceZerowe.Size = new Size(135, 25);
      ObliczMiejsceZerowe.TabIndex = 1;
      ObliczMiejsceZerowe.Text = "Oblicz Miejsce Zerowe";
      ObliczMiejsceZerowe.UseVisualStyleBackColor = true;
      ObliczMiejsceZerowe.Click += ObliczMiejsceZerowe_Click;
      // 
      // tabPage2
      // 
      tabPage2.Location = new Point(4, 24);
      tabPage2.Name = "tabPage2";
      tabPage2.Padding = new Padding(3);
      tabPage2.Size = new Size(976, 933);
      tabPage2.TabIndex = 1;
      tabPage2.Text = "OUTPUT";
      tabPage2.UseVisualStyleBackColor = true;
      // 
      // tabPage3
      // 
      tabPage3.Location = new Point(4, 24);
      tabPage3.Name = "tabPage3";
      tabPage3.Size = new Size(976, 933);
      tabPage3.TabIndex = 2;
      tabPage3.Text = "O Programie";
      tabPage3.UseVisualStyleBackColor = true;
      // 
      // panel2
      // 
      panel2.Controls.Add(ObliczMiejsceZerowe);
      panel2.Location = new Point(8, 786);
      panel2.Name = "panel2";
      panel2.Size = new Size(332, 139);
      panel2.TabIndex = 100;
      // 
      // BisectionMaster3k
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(984, 961);
      Controls.Add(tabControl1);
      Margin = new Padding(3, 2, 3, 2);
      Name = "BisectionMaster3k";
      Text = "BisectionMaster3k";
      tabControl1.ResumeLayout(false);
      tabPage1.ResumeLayout(false);
      panel1.ResumeLayout(false);
      panel1.PerformLayout();
      panel2.ResumeLayout(false);
      panel2.PerformLayout();
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
  }
}