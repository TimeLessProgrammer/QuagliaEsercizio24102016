namespace QuagliaEsercizio24102016
{
  partial class frm_Index
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
      this.btn_Es1 = new System.Windows.Forms.Button();
      this.btn_Es2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btn_Es1
      // 
      this.btn_Es1.Location = new System.Drawing.Point(12, 12);
      this.btn_Es1.Name = "btn_Es1";
      this.btn_Es1.Size = new System.Drawing.Size(148, 67);
      this.btn_Es1.TabIndex = 0;
      this.btn_Es1.Text = "Es Dizionario";
      this.btn_Es1.UseVisualStyleBackColor = true;
      // 
      // btn_Es2
      // 
      this.btn_Es2.Location = new System.Drawing.Point(166, 12);
      this.btn_Es2.Name = "btn_Es2";
      this.btn_Es2.Size = new System.Drawing.Size(148, 67);
      this.btn_Es2.TabIndex = 1;
      this.btn_Es2.Text = "Es Coda";
      this.btn_Es2.UseVisualStyleBackColor = true;
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(320, 12);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(148, 67);
      this.button3.TabIndex = 2;
      this.button3.Text = "Es Pila";
      this.button3.UseVisualStyleBackColor = true;
      // 
      // frm_Index
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1270, 549);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.btn_Es2);
      this.Controls.Add(this.btn_Es1);
      this.IsMdiContainer = true;
      this.Name = "frm_Index";
      this.Text = "Index";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Shown += new System.EventHandler(this.frm_Index_Shown);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btn_Es1;
    private System.Windows.Forms.Button btn_Es2;
    private System.Windows.Forms.Button button3;
  }
}