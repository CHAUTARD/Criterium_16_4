namespace Criterium_16_4
{
    partial class FormParams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParams));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btValid = new System.Windows.Forms.Button();
            this.bt_abandon = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbIdParametre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(241, 420);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(273, 29);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(515, 240);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // btValid
            // 
            this.btValid.Image = ((System.Drawing.Image)(resources.GetObject("btValid.Image")));
            this.btValid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btValid.Location = new System.Drawing.Point(489, 351);
            this.btValid.Name = "btValid";
            this.btValid.Size = new System.Drawing.Size(140, 81);
            this.btValid.TabIndex = 2;
            this.btValid.Text = "&Valider";
            this.btValid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btValid.UseVisualStyleBackColor = true;
            this.btValid.Click += new System.EventHandler(this.btValid_Click);
            // 
            // bt_abandon
            // 
            this.bt_abandon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_abandon.Image = ((System.Drawing.Image)(resources.GetObject("bt_abandon.Image")));
            this.bt_abandon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_abandon.Location = new System.Drawing.Point(653, 351);
            this.bt_abandon.Name = "bt_abandon";
            this.bt_abandon.Size = new System.Drawing.Size(135, 80);
            this.bt_abandon.TabIndex = 3;
            this.bt_abandon.Text = "&Abandon";
            this.bt_abandon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_abandon.UseVisualStyleBackColor = true;
            this.bt_abandon.Click += new System.EventHandler(this.bt_abandon_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(273, 303);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(515, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Explication :";
            // 
            // lbIdParametre
            // 
            this.lbIdParametre.AutoSize = true;
            this.lbIdParametre.Location = new System.Drawing.Point(276, 351);
            this.lbIdParametre.Name = "lbIdParametre";
            this.lbIdParametre.Size = new System.Drawing.Size(64, 13);
            this.lbIdParametre.TabIndex = 6;
            this.lbIdParametre.Text = "IdParametre";
            this.lbIdParametre.Visible = false;
            // 
            // FormParams
            // 
            this.AcceptButton = this.btValid;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_abandon;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.lbIdParametre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_abandon);
            this.Controls.Add(this.btValid);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormParams";
            this.Text = "Les paramètres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btValid;
        private System.Windows.Forms.Button bt_abandon;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbIdParametre;
    }
}