namespace GestiuneBirouri
{
    partial class ExportToExcelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportToExcelForm));
            this.exportEverythingButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // exportEverythingButton
            // 
            this.exportEverythingButton.BackColor = System.Drawing.Color.LightGreen;
            this.exportEverythingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportEverythingButton.FlatAppearance.BorderSize = 0;
            this.exportEverythingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportEverythingButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exportEverythingButton.Location = new System.Drawing.Point(93, 302);
            this.exportEverythingButton.Name = "exportEverythingButton";
            this.exportEverythingButton.Size = new System.Drawing.Size(200, 38);
            this.exportEverythingButton.TabIndex = 3;
            this.exportEverythingButton.Text = "ExportEverything";
            this.exportEverythingButton.UseVisualStyleBackColor = false;
            this.exportEverythingButton.Click += new System.EventHandler(this.exportEverythingButton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGreen;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(93, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 38);
            this.button3.TabIndex = 10;
            this.button3.Text = "Export My Rezervations";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGreen;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(93, 195);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 38);
            this.button4.TabIndex = 11;
            this.button4.Text = "Export Rooms I didn\'t use";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(129, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 150);
            this.panel1.TabIndex = 12;
            // 
            // ExportToExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.exportEverythingButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExportToExcelForm";
            this.Text = "ExportToExcel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exportEverythingButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
    }
}