using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace Fájl_áthelyező
{
    public partial class Beallitasok : Form
    {
        public Beallitasok()
        {
            InitializeComponent();
        }

        private void labFName_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Path.GetDirectoryName(Properties.Settings.Default.sourceFile)))
            {
                labFileDialog.InitialDirectory = Path.GetDirectoryName(Properties.Settings.Default.sourceFile);
            }
            else
            {
                labFileDialog.InitialDirectory = @"C:\";
            }
            if (labFileDialog.ShowDialog() == DialogResult.OK)
            {
                labTBox.Text = labFileDialog.FileName;
                Properties.Settings.Default.sourceFile = labFileDialog.FileName;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Upgrade();
            }
        }

        private void Beallitasok_Load(object sender, EventArgs e)
        {
            //Bonyhád
            labTBox.Text = Properties.Settings.Default.sourceFile;
            labSemTBox.Text = Properties.Settings.Default.sourceSemFile;
            destDirTBox.Text = Properties.Settings.Default.destinationDir;

            labBonyTBox.Text = Properties.Settings.Default.sourceBonyFile;
            labBonySemTBox.Text = Properties.Settings.Default.sourceBonySemFile;
            labBonyDestTBox.Text = Properties.Settings.Default.destinationBonyDir;

            sendBCB.Checked = Properties.Settings.Default.send;
            receiveBCB.Checked = Properties.Settings.Default.receive;


            //Pécs
            labPTBox.Text = Properties.Settings.Default.sourcePecsFile;
            labPSemTBox.Text = Properties.Settings.Default.sourcePecsSemFile;
            destPDirTBox.Text = Properties.Settings.Default.destinationPecsDir;

            labPLTBox.Text = Properties.Settings.Default.sourcePecsLabFile;
            labPLSemTBox.Text = Properties.Settings.Default.sourcePecsLabSemFile;
            destPLDirTBox.Text = Properties.Settings.Default.destinationPecsLabDir;

            sendFreqTB.Text = Properties.Settings.Default.freqM.ToString().PadLeft(2, '0') + ":" + Properties.Settings.Default.freqS.ToString().PadLeft(2, '0');

            sendPCB.Checked = Properties.Settings.Default.psend;
            receivePCB.Checked = Properties.Settings.Default.preceive;

            //Gyakoriság
            sendFreqTB.Text = Properties.Settings.Default.freqM.ToString().PadLeft(2, '0') + ":" + Properties.Settings.Default.freqS.ToString().PadLeft(2, '0');
        }


        //Bonyhád

        private void button2_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Path.GetDirectoryName(Properties.Settings.Default.sourceSemFile)))
            {
                labSemFileDialog.InitialDirectory = Path.GetDirectoryName(Properties.Settings.Default.sourceSemFile);
            }
            else
            {
                labSemFileDialog.InitialDirectory = @"C:\";
            }
            if (labSemFileDialog.ShowDialog() == DialogResult.OK)
            {
                labTBox.Text = labSemFileDialog.FileName;
                Properties.Settings.Default.sourceSemFile = labSemFileDialog.FileName;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Upgrade();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Properties.Settings.Default.destinationDir))
            {
                destFBD.SelectedPath = Properties.Settings.Default.destinationDir;
            }
            else
            {
                destFBD.SelectedPath = @"C:\";
            }
            if (destFBD.ShowDialog() == DialogResult.OK)
            {
                destDirTBox.Text = destFBD.SelectedPath;
                Properties.Settings.Default.destinationDir = destFBD.SelectedPath;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Upgrade();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Path.GetDirectoryName(Properties.Settings.Default.sourceBonyFile)))
            {
                labBonyFileDialog.InitialDirectory = Path.GetDirectoryName(Properties.Settings.Default.sourceBonyFile);
            }
            else
            {
                labBonyFileDialog.InitialDirectory = @"C:\";
            }
            if (labBonyFileDialog.ShowDialog() == DialogResult.OK)
            {
                labTBox.Text = labBonyFileDialog.FileName;
                Properties.Settings.Default.sourceBonyFile = labBonyFileDialog.FileName;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Upgrade();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Path.GetDirectoryName(Properties.Settings.Default.sourceBonySemFile)))
            {
                labBonySemFileDialog.InitialDirectory = Path.GetDirectoryName(Properties.Settings.Default.sourceBonySemFile);
            }
            else
            {
                labBonySemFileDialog.InitialDirectory = @"C:\";
            }
            if (labBonySemFileDialog.ShowDialog() == DialogResult.OK)
            {
                labBonySemTBox.Text = labBonySemFileDialog.FileName;
                Properties.Settings.Default.sourceBonySemFile = labBonySemFileDialog.FileName;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Upgrade();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Properties.Settings.Default.destinationBonyDir))
            {
                destBonyFBD.SelectedPath = Properties.Settings.Default.destinationBonyDir;
            }
            else
            {
                destFBD.SelectedPath = @"C:\";
            }
            if (destBonyFBD.ShowDialog() == DialogResult.OK)
            {
                labBonyDestTBox.Text = destBonyFBD.SelectedPath;
                Properties.Settings.Default.destinationBonyDir = destBonyFBD.SelectedPath;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Upgrade();
            }
        }


        //Pécs

        private void button12_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Path.GetDirectoryName(Properties.Settings.Default.sourcePecsFile)))
            {
                labPFileDialog.InitialDirectory = Path.GetDirectoryName(Properties.Settings.Default.sourcePecsFile);
            }
            else
            {
                labPFileDialog.InitialDirectory = @"C:\";
            }
            if (labPFileDialog.ShowDialog() == DialogResult.OK)
            {
                labPTBox.Text = labPFileDialog.FileName;
                Properties.Settings.Default.sourcePecsFile = labPFileDialog.FileName;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Upgrade();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Path.GetDirectoryName(Properties.Settings.Default.sourcePecsSemFile)))
            {
                labPSemFileDialog.InitialDirectory = Path.GetDirectoryName(Properties.Settings.Default.sourcePecsSemFile);
            }
            else
            {
                labPFileDialog.InitialDirectory = @"C:\";
            }
            if (labPSemFileDialog.ShowDialog() == DialogResult.OK)
            {
                labPSemTBox.Text = labPLFileDialog.FileName;
                Properties.Settings.Default.sourcePecsSemFile = labPSemFileDialog.FileName;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Upgrade();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Properties.Settings.Default.destinationPecsDir))
            {
                destPFBD.SelectedPath = Properties.Settings.Default.destinationPecsDir;
            }
            else
            {
                destPFBD.SelectedPath = @"C:\";
            }
            if (destPFBD.ShowDialog() == DialogResult.OK)
            {
                destPDirTBox.Text = destPFBD.SelectedPath;
                Properties.Settings.Default.destinationPecsDir = destPFBD.SelectedPath;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Upgrade();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Path.GetDirectoryName(Properties.Settings.Default.sourcePecsLabFile)))
            {
                labPLFileDialog.InitialDirectory = Path.GetDirectoryName(Properties.Settings.Default.sourcePecsLabFile);
            }
            else
            {
                labPLFileDialog.InitialDirectory = @"C:\";
            }
            if (labPLFileDialog.ShowDialog() == DialogResult.OK)
            {
                labPLTBox.Text = labPLFileDialog.FileName;
                Properties.Settings.Default.sourcePecsLabFile = labPLFileDialog.FileName;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Upgrade();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Path.GetDirectoryName(Properties.Settings.Default.sourcePecsLabSemFile)))
            {
                labPLSemFileDialog.InitialDirectory = Path.GetDirectoryName(Properties.Settings.Default.sourcePecsLabSemFile);
            }
            else
            {
                labPLSemFileDialog.InitialDirectory = @"C:\";
            }
            if (labPLSemFileDialog.ShowDialog() == DialogResult.OK)
            {
                labPLSemTBox.Text = labPLSemFileDialog.FileName;
                Properties.Settings.Default.sourcePecsLabSemFile = labPLSemFileDialog.FileName;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Upgrade();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Properties.Settings.Default.destinationPecsLabDir))
            {
                destPLFBD.SelectedPath = Properties.Settings.Default.destinationPecsLabDir;
            }
            else
            {
                destPLFBD.SelectedPath = @"C:\";
            }
            if (destPLFBD.ShowDialog() == DialogResult.OK)
            {
                destPLDirTBox.Text = destPLFBD.SelectedPath;
                Properties.Settings.Default.destinationPecsLabDir = destPLFBD.SelectedPath;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Upgrade();
            }
        }

        //Gyakoriság

        private void button4_Click(object sender, EventArgs e)
        {
            string[] ms = sendFreqTB.Text.Split(':');
            if (ms.Length == 2)
            {
                string sendFreq = "00:" + ms[0].ToString().PadLeft(2, '0') + ":" + ms[1];
                TimeSpan ts;
                if (TimeSpan.TryParse(sendFreq, out ts))
                {
                    int intval = int.Parse(ms[0]);
                    Properties.Settings.Default.freqM = intval;
                    intval = int.Parse(ms[1]);
                    Properties.Settings.Default.freqS = intval;
                }
                else
                {
                    MessageBox.Show("Rossz idő formátum! (mm:ss)");
                }
            }
            else
            {
                MessageBox.Show("Rossz idő formátum! (mm:ss)");
            }
            Properties.Settings.Default.send = sendBCB.Checked;
            Properties.Settings.Default.receive = receiveBCB.Checked;
            Properties.Settings.Default.psend = sendPCB.Checked;
            Properties.Settings.Default.preceive = receivePCB.Checked;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();
            this.Close();
        }

    }
}
