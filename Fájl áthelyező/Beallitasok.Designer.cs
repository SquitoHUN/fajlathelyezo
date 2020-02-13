namespace Fájl_áthelyező
{
    partial class Beallitasok
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
            this.label1 = new System.Windows.Forms.Label();
            this.labTBox = new System.Windows.Forms.TextBox();
            this.labFName = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labSemTBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.destDirTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sendFreqTB = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.labFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.labSemFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.destFBD = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.labBonyTBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.labBonyDestTBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.labBonySemTBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labBonyFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.labBonySemFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.destBonyFBD = new System.Windows.Forms.FolderBrowserDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.sendCB = new System.Windows.Forms.CheckBox();
            this.receiveCB = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eredmény fájl:";
            // 
            // labTBox
            // 
            this.labTBox.Location = new System.Drawing.Point(89, 31);
            this.labTBox.Name = "labTBox";
            this.labTBox.ReadOnly = true;
            this.labTBox.Size = new System.Drawing.Size(195, 20);
            this.labTBox.TabIndex = 1;
            // 
            // labFName
            // 
            this.labFName.Location = new System.Drawing.Point(290, 28);
            this.labFName.Name = "labFName";
            this.labFName.Size = new System.Drawing.Size(75, 23);
            this.labFName.TabIndex = 2;
            this.labFName.Text = "Tallózás";
            this.labFName.UseVisualStyleBackColor = true;
            this.labFName.Click += new System.EventHandler(this.labFName_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Tallózás";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labSemTBox
            // 
            this.labSemTBox.Location = new System.Drawing.Point(89, 59);
            this.labSemTBox.Name = "labSemTBox";
            this.labSemTBox.ReadOnly = true;
            this.labSemTBox.Size = new System.Drawing.Size(195, 20);
            this.labSemTBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Semafor fájl";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(290, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Tallózás";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // destDirTBox
            // 
            this.destDirTBox.Location = new System.Drawing.Point(89, 89);
            this.destDirTBox.Name = "destDirTBox";
            this.destDirTBox.ReadOnly = true;
            this.destDirTBox.Size = new System.Drawing.Size(195, 20);
            this.destDirTBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cél könyvtár";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gyakoriság";
            // 
            // sendFreqTB
            // 
            this.sendFreqTB.Location = new System.Drawing.Point(87, 270);
            this.sendFreqTB.Name = "sendFreqTB";
            this.sendFreqTB.Size = new System.Drawing.Size(38, 20);
            this.sendFreqTB.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(11, 302);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "OK";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // labFileDialog
            // 
            this.labFileDialog.FileName = "labFileDialog";
            // 
            // labSemFileDialog
            // 
            this.labSemFileDialog.FileName = "openFileDialog2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Tallózás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labBonyTBox
            // 
            this.labBonyTBox.Location = new System.Drawing.Point(89, 142);
            this.labBonyTBox.Name = "labBonyTBox";
            this.labBonyTBox.ReadOnly = true;
            this.labBonyTBox.Size = new System.Drawing.Size(195, 20);
            this.labBonyTBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Eredmény fájl:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(290, 195);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "Tallózás";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // labBonyDestTBox
            // 
            this.labBonyDestTBox.Location = new System.Drawing.Point(89, 198);
            this.labBonyDestTBox.Name = "labBonyDestTBox";
            this.labBonyDestTBox.ReadOnly = true;
            this.labBonyDestTBox.Size = new System.Drawing.Size(195, 20);
            this.labBonyDestTBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cél könyvtár";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(290, 166);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 17;
            this.button6.Text = "Tallózás";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // labBonySemTBox
            // 
            this.labBonySemTBox.Location = new System.Drawing.Point(89, 168);
            this.labBonySemTBox.Name = "labBonySemTBox";
            this.labBonySemTBox.ReadOnly = true;
            this.labBonySemTBox.Size = new System.Drawing.Size(195, 20);
            this.labBonySemTBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Semafor fájl";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(128, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Szekszárd => Bonyhád";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(128, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Bonyhád => Szekszárd";
            // 
            // labBonyFileDialog
            // 
            this.labBonyFileDialog.FileName = "lab.msg";
            // 
            // labBonySemFileDialog
            // 
            this.labBonySemFileDialog.FileName = "lab.sem";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Eredmények küldése";
            // 
            // sendCB
            // 
            this.sendCB.AutoSize = true;
            this.sendCB.Location = new System.Drawing.Point(120, 235);
            this.sendCB.Name = "sendCB";
            this.sendCB.Size = new System.Drawing.Size(15, 14);
            this.sendCB.TabIndex = 24;
            this.sendCB.UseVisualStyleBackColor = true;
            // 
            // receiveCB
            // 
            this.receiveCB.AutoSize = true;
            this.receiveCB.Location = new System.Drawing.Point(269, 233);
            this.receiveCB.Name = "receiveCB";
            this.receiveCB.Size = new System.Drawing.Size(15, 14);
            this.receiveCB.TabIndex = 25;
            this.receiveCB.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(170, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Kérések fogadása";
            // 
            // Beallitasok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 337);
            this.ControlBox = false;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.receiveCB);
            this.Controls.Add(this.sendCB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.labBonyDestTBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.labBonySemTBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labBonyTBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.sendFreqTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.destDirTBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labSemTBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labFName);
            this.Controls.Add(this.labTBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Beallitasok";
            this.Text = "Beállítások";
            this.Load += new System.EventHandler(this.Beallitasok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox labTBox;
        private System.Windows.Forms.Button labFName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox labSemTBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox destDirTBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sendFreqTB;
        private System.Windows.Forms.Button button4;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.OpenFileDialog labFileDialog;
        private System.Windows.Forms.OpenFileDialog labSemFileDialog;
        private System.Windows.Forms.FolderBrowserDialog destFBD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox labBonyDestTBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox labBonySemTBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox labBonyTBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog labBonyFileDialog;
        private System.Windows.Forms.OpenFileDialog labBonySemFileDialog;
        private System.Windows.Forms.FolderBrowserDialog destBonyFBD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox receiveCB;
        private System.Windows.Forms.CheckBox sendCB;
        private System.Windows.Forms.Label label10;
    }
}