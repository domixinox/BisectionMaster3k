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
      ObliczMiejsceZerowe = new Button();
      tabPage2 = new TabPage();
      tabControl1.SuspendLayout();
      tabPage1.SuspendLayout();
      SuspendLayout();
      // 
      // tabControl1
      // 
      tabControl1.Controls.Add(tabPage1);
      tabControl1.Controls.Add(tabPage2);
      tabControl1.Dock = DockStyle.Fill;
      tabControl1.Location = new Point(0, 0);
      tabControl1.Name = "tabControl1";
      tabControl1.SelectedIndex = 0;
      tabControl1.Size = new Size(984, 961);
      tabControl1.TabIndex = 0;
      // 
      // tabPage1
      // 
      tabPage1.Controls.Add(ObliczMiejsceZerowe);
      tabPage1.Location = new Point(4, 24);
      tabPage1.Name = "tabPage1";
      tabPage1.Padding = new Padding(3);
      tabPage1.Size = new Size(976, 933);
      tabPage1.TabIndex = 0;
      tabPage1.Text = "Tu Obliczenia";
      tabPage1.UseVisualStyleBackColor = true;
      // 
      // ObliczMiejsceZerowe
      // 
      ObliczMiejsceZerowe.AutoSize = true;
      ObliczMiejsceZerowe.Location = new Point(8, 902);
      ObliczMiejsceZerowe.Name = "ObliczMiejsceZerowe";
      ObliczMiejsceZerowe.Size = new Size(135, 25);
      ObliczMiejsceZerowe.TabIndex = 0;
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
      tabPage2.Text = "O Programie";
      tabPage2.UseVisualStyleBackColor = true;
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
      tabPage1.PerformLayout();
      ResumeLayout(false);
    }

    #endregion

    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private Button ObliczMiejsceZerowe;
  }
}