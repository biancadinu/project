namespace GestiuneBirouri
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.rezervariTable = new System.Windows.Forms.DataGridView();
            this.nameOfRoomTextBox = new System.Windows.Forms.TextBox();
            this.numeSalaLabel = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.freeRoomsButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.getHour = new System.Windows.Forms.NumericUpDown();
            this.getMinutes = new System.Windows.Forms.NumericUpDown();
            this.bookRoomButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exportToExcelInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rezervariTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // rezervariTable
            // 
            this.rezervariTable.BackgroundColor = System.Drawing.Color.LightGreen;
            this.rezervariTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rezervariTable.GridColor = System.Drawing.SystemColors.Control;
            this.rezervariTable.Location = new System.Drawing.Point(12, 237);
            this.rezervariTable.Name = "rezervariTable";
            this.rezervariTable.ReadOnly = true;
            this.rezervariTable.Size = new System.Drawing.Size(860, 312);
            this.rezervariTable.TabIndex = 0;
            // 
            // nameOfRoomTextBox
            // 
            this.nameOfRoomTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOfRoomTextBox.Location = new System.Drawing.Point(192, 96);
            this.nameOfRoomTextBox.Name = "nameOfRoomTextBox";
            this.nameOfRoomTextBox.Size = new System.Drawing.Size(152, 31);
            this.nameOfRoomTextBox.TabIndex = 1;
            // 
            // numeSalaLabel
            // 
            this.numeSalaLabel.AutoSize = true;
            this.numeSalaLabel.BackColor = System.Drawing.Color.Transparent;
            this.numeSalaLabel.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeSalaLabel.Location = new System.Drawing.Point(12, 96);
            this.numeSalaLabel.Name = "numeSalaLabel";
            this.numeSalaLabel.Size = new System.Drawing.Size(174, 31);
            this.numeSalaLabel.TabIndex = 2;
            this.numeSalaLabel.Text = "Room Name:";
            // 
            // logInButton
            // 
            this.logInButton.BackColor = System.Drawing.Color.LightGreen;
            this.logInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInButton.FlatAppearance.BorderSize = 0;
            this.logInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInButton.Location = new System.Drawing.Point(24, 25);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(150, 38);
            this.logInButton.TabIndex = 3;
            this.logInButton.Text = "Back";
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(350, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Find Reservations";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // freeRoomsButton
            // 
            this.freeRoomsButton.BackColor = System.Drawing.Color.LightGreen;
            this.freeRoomsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.freeRoomsButton.FlatAppearance.BorderSize = 0;
            this.freeRoomsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.freeRoomsButton.Location = new System.Drawing.Point(350, 137);
            this.freeRoomsButton.Name = "freeRoomsButton";
            this.freeRoomsButton.Size = new System.Drawing.Size(110, 77);
            this.freeRoomsButton.TabIndex = 5;
            this.freeRoomsButton.Text = "Find Free Rooms";
            this.freeRoomsButton.UseVisualStyleBackColor = false;
            this.freeRoomsButton.Click += new System.EventHandler(this.freeRoomsButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(12, 185);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(332, 29);
            this.dateTimePicker.TabIndex = 8;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(12, 138);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(98, 31);
            this.timeLabel.TabIndex = 10;
            this.timeLabel.Text = "Hours:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Minutes:";
            // 
            // getHour
            // 
            this.getHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getHour.Location = new System.Drawing.Point(119, 140);
            this.getHour.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.getHour.Name = "getHour";
            this.getHour.Size = new System.Drawing.Size(47, 31);
            this.getHour.TabIndex = 14;
            // 
            // getMinutes
            // 
            this.getMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getMinutes.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.getMinutes.Location = new System.Drawing.Point(297, 141);
            this.getMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.getMinutes.Name = "getMinutes";
            this.getMinutes.Size = new System.Drawing.Size(47, 31);
            this.getMinutes.TabIndex = 15;
            // 
            // bookRoomButton
            // 
            this.bookRoomButton.BackColor = System.Drawing.Color.LightGreen;
            this.bookRoomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookRoomButton.FlatAppearance.BorderSize = 0;
            this.bookRoomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookRoomButton.Location = new System.Drawing.Point(466, 137);
            this.bookRoomButton.Name = "bookRoomButton";
            this.bookRoomButton.Size = new System.Drawing.Size(110, 77);
            this.bookRoomButton.TabIndex = 16;
            this.bookRoomButton.Text = "BookRom";
            this.bookRoomButton.UseVisualStyleBackColor = false;
            this.bookRoomButton.Click += new System.EventHandler(this.bookRoomButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(662, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 189);
            this.panel1.TabIndex = 17;
            // 
            // exportToExcelInfo
            // 
            this.exportToExcelInfo.BackColor = System.Drawing.Color.LightGreen;
            this.exportToExcelInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportToExcelInfo.FlatAppearance.BorderSize = 0;
            this.exportToExcelInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportToExcelInfo.Location = new System.Drawing.Point(466, 96);
            this.exportToExcelInfo.Name = "exportToExcelInfo";
            this.exportToExcelInfo.Size = new System.Drawing.Size(110, 32);
            this.exportToExcelInfo.TabIndex = 18;
            this.exportToExcelInfo.Text = "GetExcel";
            this.exportToExcelInfo.UseVisualStyleBackColor = false;
            this.exportToExcelInfo.Click += new System.EventHandler(this.exportToExcelInfo_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.exportToExcelInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bookRoomButton);
            this.Controls.Add(this.getMinutes);
            this.Controls.Add(this.getHour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.freeRoomsButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.numeSalaLabel);
            this.Controls.Add(this.nameOfRoomTextBox);
            this.Controls.Add(this.rezervariTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "MainMenuForm";
            ((System.ComponentModel.ISupportInitialize)(this.rezervariTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView rezervariTable;
        private System.Windows.Forms.TextBox nameOfRoomTextBox;
        private System.Windows.Forms.Label numeSalaLabel;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button freeRoomsButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown getHour;
        private System.Windows.Forms.NumericUpDown getMinutes;
        private System.Windows.Forms.Button bookRoomButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exportToExcelInfo;
    }
}