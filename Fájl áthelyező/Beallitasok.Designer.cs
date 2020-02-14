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
            this.sendBCB = new System.Windows.Forms.CheckBox();
            this.receiveBCB = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.receivePCB = new System.Windows.Forms.CheckBox();
            this.sendPCB = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.destPLDirTBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.labPLSemTBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.labPLTBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.destPDirTBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.labPSemTBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.labPTBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.destPFBD = new System.Windows.Forms.FolderBrowserDialog();
            this.labPFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.labPSemFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.labPLFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.destPLFBD = new System.Windows.Forms.FolderBrowserDialog();
            this.labPLSemFileDialog = new System.Windows.Forms.OpenFileDialog();
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
            this.label4.Location = new System.Drawing.Point(347, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gyakoriság";
            // 
            // sendFreqTB
            // 
            this.sendFreqTB.Location = new System.Drawing.Point(426, 268);
            this.sendFreqTB.Name = "sendFreqTB";
            this.sendFreqTB.Size = new System.Drawing.Size(38, 20);
            this.sendFreqTB.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(350, 300);
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
            // sendBCB
            // 
            this.sendBCB.AutoSize = true;
            this.sendBCB.Location = new System.Drawing.Point(120, 235);
            this.sendBCB.Name = "sendBCB";
            this.sendBCB.Size = new System.Drawing.Size(15, 14);
            this.sendBCB.TabIndex = 24;
            this.sendBCB.UseVisualStyleBackColor = true;
            // 
            // receiveBCB
            // 
            this.receiveBCB.AutoSize = true;
            this.receiveBCB.Location = new System.Drawing.Point(269, 233);
            this.receiveBCB.Name = "receiveBCB";
            this.receiveBCB.Size = new System.Drawing.Size(15, 14);
            this.receiveBCB.TabIndex = 25;
            this.receiveBCB.UseVisualStyleBackColor = true;
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(612, 233);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "Kérések fogadása";
            // 
            // receivePCB
            // 
            this.receivePCB.AutoSize = true;
            this.receivePCB.Location = new System.Drawing.Point(711, 233);
            this.receivePCB.Name = "receivePCB";
            this.receivePCB.Size = new System.Drawing.Size(15, 14);
            this.receivePCB.TabIndex = 49;
            this.receivePCB.UseVisualStyleBackColor = true;
            // 
            // sendPCB
            // 
            this.sendPCB.AutoSize = true;
            this.sendPCB.Location = new System.Drawing.Point(562, 235);
            this.sendPCB.Name = "sendPCB";
            this.sendPCB.Size = new System.Drawing.Size(15, 14);
            this.sendPCB.TabIndex = 48;
            this.sendPCB.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(450, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 47;
            this.label13.Text = "Eredmények küldése";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(548, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 46;
            this.label14.Text = "Pécs => Szekszárd";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(548, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 13);
            this.label15.TabIndex = 45;
            this.label15.Text = "Szekszárd => Pécs";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(705, 86);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 44;
            this.button7.Text = "Tallózás";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // destPLDirTBox
            // 
            this.destPLDirTBox.Location = new System.Drawing.Point(504, 89);
            this.destPLDirTBox.Name = "destPLDirTBox";
            this.destPLDirTBox.ReadOnly = true;
            this.destPLDirTBox.Size = new System.Drawing.Size(195, 20);
            this.destPLDirTBox.TabIndex = 43;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(423, 91);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 13);
            this.label16.TabIndex = 42;
            this.label16.Text = "Cél könyvtár";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(705, 57);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 41;
            this.button8.Text = "Tallózás";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // labPLSemTBox
            // 
            this.labPLSemTBox.Location = new System.Drawing.Point(504, 59);
            this.labPLSemTBox.Name = "labPLSemTBox";
            this.labPLSemTBox.ReadOnly = true;
            this.labPLSemTBox.Size = new System.Drawing.Size(195, 20);
            this.labPLSemTBox.TabIndex = 40;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(423, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "Semafor fájl";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(705, 30);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 38;
            this.button9.Text = "Tallózás";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // labPLTBox
            // 
            this.labPLTBox.Location = new System.Drawing.Point(504, 33);
            this.labPLTBox.Name = "labPLTBox";
            this.labPLTBox.ReadOnly = true;
            this.labPLTBox.Size = new System.Drawing.Size(195, 20);
            this.labPLTBox.TabIndex = 37;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(423, 35);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "Eredmény fájl:";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(705, 196);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 35;
            this.button10.Text = "Tallózás";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // destPDirTBox
            // 
            this.destPDirTBox.Location = new System.Drawing.Point(504, 199);
            this.destPDirTBox.Name = "destPDirTBox";
            this.destPDirTBox.ReadOnly = true;
            this.destPDirTBox.Size = new System.Drawing.Size(195, 20);
            this.destPDirTBox.TabIndex = 34;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(423, 201);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 13);
            this.label19.TabIndex = 33;
            this.label19.Text = "Cél könyvtár";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(705, 167);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 32;
            this.button11.Text = "Tallózás";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // labPSemTBox
            // 
            this.labPSemTBox.Location = new System.Drawing.Point(504, 169);
            this.labPSemTBox.Name = "labPSemTBox";
            this.labPSemTBox.ReadOnly = true;
            this.labPSemTBox.Size = new System.Drawing.Size(195, 20);
            this.labPSemTBox.TabIndex = 31;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(423, 172);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 13);
            this.label20.TabIndex = 30;
            this.label20.Text = "Semafor fájl";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(705, 138);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 29;
            this.button12.Text = "Tallózás";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // labPTBox
            // 
            this.labPTBox.Location = new System.Drawing.Point(504, 141);
            this.labPTBox.Name = "labPTBox";
            this.labPTBox.ReadOnly = true;
            this.labPTBox.Size = new System.Drawing.Size(195, 20);
            this.labPTBox.TabIndex = 28;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(423, 144);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 13);
            this.label21.TabIndex = 27;
            this.label21.Text = "Eredmény fájl:";
            // 
            // labPFileDialog
            // 
            this.labPFileDialog.FileName = "szszard.msg";
            // 
            // labPSemFileDialog
            // 
            this.labPSemFileDialog.FileName = "szszard.sem";
            // 
            // labPLFileDialog
            // 
            this.labPLFileDialog.FileName = "szszard.sem";
            // 
            // labPLSemFileDialog
            // 
            this.labPLSemFileDialog.FileName = "szszard.msg";
            // 
            // Beallitasok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 335);
            this.ControlBox = false;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.receivePCB);
            this.Controls.Add(this.sendPCB);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.destPLDirTBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.labPLSemTBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.labPLTBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.destPDirTBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.labPSemTBox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.labPTBox);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.receiveBCB);
            this.Controls.Add(this.sendBCB);
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
        private System.Windows.Forms.CheckBox receiveBCB;
        private System.Windows.Forms.CheckBox sendBCB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox receivePCB;
        private System.Windows.Forms.CheckBox sendPCB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox destPLDirTBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox labPLSemTBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox labPLTBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox destPDirTBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox labPSemTBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox labPTBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.FolderBrowserDialog destPFBD;
        private System.Windows.Forms.OpenFileDialog labPFileDialog;
        private System.Windows.Forms.OpenFileDialog labPSemFileDialog;
        private System.Windows.Forms.OpenFileDialog labPLFileDialog;
        private System.Windows.Forms.FolderBrowserDialog destPLFBD;
        private System.Windows.Forms.OpenFileDialog labPLSemFileDialog;
    }
}