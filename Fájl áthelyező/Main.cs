using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using System.IO;

namespace Fájl_áthelyező
{
    public partial class Main : Form
    {

        System.Timers.Timer t;
        int m = Properties.Settings.Default.freqM;
        int s = Properties.Settings.Default.freqS;
        string sourceFile = Properties.Settings.Default.sourceFile;
        string destinationFile = Path.Combine(Properties.Settings.Default.destinationDir, Path.GetFileName(Properties.Settings.Default.sourceFile));
        string sourceSemFile = Properties.Settings.Default.sourceSemFile;
        string destinationSemFile = Path.Combine(Properties.Settings.Default.destinationDir, Path.GetFileName(Properties.Settings.Default.sourceSemFile));

        string sourceBonyFile = Properties.Settings.Default.sourceBonyFile;
        string destinationBonyFile = Path.Combine(Properties.Settings.Default.destinationBonyDir, Path.GetFileName(Properties.Settings.Default.sourceBonyFile));
        string sourceBonySemFile = Properties.Settings.Default.sourceBonySemFile;
        string destinationBonySemFile = Path.Combine(Properties.Settings.Default.destinationBonyDir, Path.GetFileName(Properties.Settings.Default.sourceBonySemFile));

        public class FileLocker
        {

        }

        public bool IsFileLocked(string filename)
        {
            bool Locked = false;
            try
            {
                FileStream fs =
                    File.Open(filename, FileMode.OpenOrCreate,
                    FileAccess.ReadWrite, FileShare.None);
                fs.Close();
            }
            catch (IOException ex)
            {
                Locked = true;
            }
            return Locked;
        }

        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m = Properties.Settings.Default.freqM;
            s = Properties.Settings.Default.freqS;
            t.Start();
            DateTime now = DateTime.Now;
            string startMsg = now.Hour + ":" + now.Minute + ":" + now.Second + " - Áthelyező elindítva.";
            logger.AppendText(startMsg);
            logger.AppendText(Environment.NewLine);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            t.Stop();
            DateTime now = DateTime.Now;
            string stopMsg = now.Hour + ":" + now.Minute + ":" + now.Second + " - Áthelyező leállítva.";
            logger.AppendText(stopMsg);
            logger.AppendText(Environment.NewLine);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
        }

        public void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s--;
                if (s <= 0 && m != 0)
                {
                    s = 59;
                    m--;
                }
                if (s <= 0 && m <= 0)
                {
                    if(Properties.Settings.Default.send == true)
                    {
                        if (File.Exists(sourceSemFile) && !File.Exists(destinationSemFile) && !File.Exists(destinationFile))
                        {
                            DateTime now = DateTime.Now;
                            try
                            {
                                File.Move(sourceFile, destinationFile);
                            }
                            catch (Exception errmsg)
                            {
                                string errormsg = now.Hour + ":" + now.Minute + " - Hiba: " + errmsg.ToString() + Environment.NewLine;
                                logger.AppendText(errormsg);
                            }
                            finally
                            {
                                string successmsg = now.Hour + ":" + now.Minute + " -  A lelet fájl mozgatása sikeres." + Environment.NewLine;
                                logger.AppendText(successmsg);
                            }

                            try
                            {
                                File.Move(sourceSemFile, destinationSemFile);
                            }
                            catch (Exception errmsg)
                            {
                                string errormsg = now.Hour + ":" + now.Minute + " - Hiba: " + errmsg.ToString() + Environment.NewLine;
                                logger.AppendText(errormsg);
                            }
                            finally
                            {
                                string successmsg = now.Hour + ":" + now.Minute + " -  A semafor fájl mozgatása sikeres." + Environment.NewLine;
                                logger.AppendText(successmsg);
                            }
                        }
                    }
                    if(!Directory.Exists(@"s:\ToFonix"))
                    {
                        logger.AppendText("A célkönyvtár nem létezik." + Environment.NewLine);
                    }
                    if(Properties.Settings.Default.receive == true)
                    {
                        if (File.Exists(sourceBonySemFile) && File.Exists(sourceBonyFile) && !File.Exists(destinationBonyFile) && !File.Exists(destinationBonySemFile))
                        {
                            FileStream lockSemFile = null;
                            FileStream lockLabFile = null;
                            DateTime now = DateTime.Now;
                            try
                            {
                                lockSemFile = new FileStream(sourceBonySemFile, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Delete);
                            }
                            catch (Exception locksem)
                            {
                                string lockerrormsg = now.Hour + ":" + now.Minute + " - Sem fájl lockolása sikertelen - Hiba: " + locksem.ToString() + Environment.NewLine;
                                logger.AppendText(lockerrormsg);
                            }
                            finally
                            {
                                try
                                {
                                    lockLabFile = new FileStream(sourceBonySemFile, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Delete);
                                }
                                catch (Exception locklab)
                                {
                                    string lockerrormsg = now.Hour + ":" + now.Minute + " - Lab fájl lockolása sikertelen - Hiba: " + locklab.ToString() + Environment.NewLine;
                                    logger.AppendText(lockerrormsg);

                                }
                                finally
                                {
                                    try
                                    {
                                        File.Move(sourceBonyFile, destinationBonyFile);
                                    }
                                    catch (Exception labmoveex)
                                    {
                                        string lockerrormsg = now.Hour + ":" + now.Minute.ToString().PadLeft(2, '0') + " - Lab fájl mozgatása sikertelen - Hiba: " + labmoveex.ToString() + Environment.NewLine;
                                        logger.AppendText(lockerrormsg);
                                    }
                                    finally
                                    {
                                        string successmsg = now.Hour + ":" + now.Minute + " -  A labor kérő fájl mozgatása sikeres." + Environment.NewLine;
                                        logger.AppendText(successmsg);
                                    }
                                    try
                                    {
                                        File.Move(sourceBonySemFile, destinationBonySemFile);
                                    }
                                    catch (Exception labsemmoveex)
                                    {
                                        string movesemerrormsg = now.Hour + ":" + now.Minute.ToString().PadLeft(2, '0') + " - Lab fájl mozgatása sikertelen - Hiba: " + labsemmoveex.ToString() + Environment.NewLine;
                                        logger.AppendText(movesemerrormsg);
                                    }
                                    finally
                                    {
                                        string successsemmsg = now.Hour + ":" + now.Minute + " -  A labor kérő semafor fájl mozgatása sikeres." + Environment.NewLine;
                                        logger.AppendText(successsemmsg);
                                    }
                                }
                            }
                            if (lockSemFile != null)
                            {
                                lockSemFile.Dispose();
                            }
                            if (lockLabFile != null)
                            {
                                lockLabFile.Dispose();
                            }
                        }
                    }
                    if(File.Exists(destinationFile) && !File.Exists(destinationSemFile) && !IsFileLocked(destinationFile))
                    {
                        File.Create(destinationSemFile).Dispose();
                    }
                    m = Properties.Settings.Default.freqM;
                    s = Properties.Settings.Default.freqS;
                }
                textBox1.Text = string.Format("{0}:{1}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Beallitasok st = new Beallitasok();
            st.ShowDialog();
        }
    }
}
