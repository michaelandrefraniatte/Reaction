using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;

namespace ReactionResol
{
    public partial class Form1 : Form
    {
        private static Dictionary<string, List<int>> dictionaryindicelist = new Dictionary<string, List<int>>();
        private static List<int> indicelist = new List<int>();
        private static Dictionary<string, List<int>> dictionarypositionlist = new Dictionary<string, List<int>>();
        private static List<int> positionlist = new List<int>();
        private static double[] line1 = new double[9];
        private static double[] line2 = new double[9];
        private static double[] line3 = new double[9];
        private static double[] line4 = new double[9];
        private static double[] line5 = new double[9];
        private static double[] line6 = new double[9];
        private static double[] line7 = new double[9];
        private static double[] line8 = new double[9];
        private static double[] line9 = new double[9];
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            OnKeyDown(e.KeyData);
        }
        private void OnKeyDown(Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                const string message = "• Author: Michaël André Franiatte.\n\r\n\r• Contact: michael.franiatte@gmail.com.\n\r\n\r• Publisher: https://github.com/michaelandrefraniatte.\n\r\n\r• Copyrights: All rights reserved, no permissions granted.\n\r\n\r• License: Not open source, not free of charge to use.";
                const string caption = "About";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (keyData == Keys.Escape)
            {
                this.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CreateMatrix();
            FillMatrix();
            SolveMatrix();
        }
        private void CreateMatrix()
        {
            if (tbxka1.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbxka1.Text];
                    indicelist.Add(Convert.ToInt32(tbxki1.Text));
                    dictionaryindicelist[tbxka1.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbxki1.Text));
                        dictionaryindicelist.Add(tbxka1.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbxka1.Text];
                    positionlist.Add(0);
                    dictionarypositionlist[tbxka1.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(0);
                        dictionarypositionlist.Add(tbxka1.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbxka2.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbxka2.Text];
                    indicelist.Add(Convert.ToInt32(tbxki2.Text));
                    dictionaryindicelist[tbxka2.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbxki2.Text));
                        dictionaryindicelist.Add(tbxka2.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbxka2.Text];
                    positionlist.Add(0);
                    dictionarypositionlist[tbxka2.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(0);
                        dictionarypositionlist.Add(tbxka2.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbxka3.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbxka3.Text];
                    indicelist.Add(Convert.ToInt32(tbxki3.Text));
                    dictionaryindicelist[tbxka3.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbxki3.Text));
                        dictionaryindicelist.Add(tbxka3.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbxka3.Text];
                    positionlist.Add(0);
                    dictionarypositionlist[tbxka3.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(0);
                        dictionarypositionlist.Add(tbxka3.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbxka4.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbxka4.Text];
                    indicelist.Add(Convert.ToInt32(tbxki4.Text));
                    dictionaryindicelist[tbxka4.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbxki4.Text));
                        dictionaryindicelist.Add(tbxka4.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbxka4.Text];
                    positionlist.Add(0);
                    dictionarypositionlist[tbxka4.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(0);
                        dictionarypositionlist.Add(tbxka4.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbxka5.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbxka5.Text];
                    indicelist.Add(Convert.ToInt32(tbxki5.Text));
                    dictionaryindicelist[tbxka5.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbxki5.Text));
                        dictionaryindicelist.Add(tbxka5.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbxka5.Text];
                    positionlist.Add(0);
                    dictionarypositionlist[tbxka5.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(0);
                        dictionarypositionlist.Add(tbxka5.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbxka6.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbxka6.Text];
                    indicelist.Add(Convert.ToInt32(tbxki6.Text));
                    dictionaryindicelist[tbxka6.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbxki6.Text));
                        dictionaryindicelist.Add(tbxka6.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbxka6.Text];
                    positionlist.Add(0);
                    dictionarypositionlist[tbxka6.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(0);
                        dictionarypositionlist.Add(tbxka6.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbxka7.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbxka7.Text];
                    indicelist.Add(Convert.ToInt32(tbxki7.Text));
                    dictionaryindicelist[tbxka7.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbxki7.Text));
                        dictionaryindicelist.Add(tbxka7.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbxka7.Text];
                    positionlist.Add(0);
                    dictionarypositionlist[tbxka7.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(0);
                        dictionarypositionlist.Add(tbxka7.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbxka8.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbxka8.Text];
                    indicelist.Add(Convert.ToInt32(tbxki8.Text));
                    dictionaryindicelist[tbxka8.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbxki8.Text));
                        dictionaryindicelist.Add(tbxka8.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbxka8.Text];
                    positionlist.Add(0);
                    dictionarypositionlist[tbxka8.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(0);
                        dictionarypositionlist.Add(tbxka8.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbxka9.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbxka9.Text];
                    indicelist.Add(Convert.ToInt32(tbxki9.Text));
                    dictionaryindicelist[tbxka9.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbxki9.Text));
                        dictionaryindicelist.Add(tbxka9.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbxka9.Text];
                    positionlist.Add(0);
                    dictionarypositionlist[tbxka9.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(0);
                        dictionarypositionlist.Add(tbxka9.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx1a1.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx1a1.Text];
                    indicelist.Add(Convert.ToInt32(tbx1i1.Text));
                    dictionaryindicelist[tbx1a1.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx1i1.Text));
                        dictionaryindicelist.Add(tbx1a1.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx1a1.Text];
                    positionlist.Add(1);
                    dictionarypositionlist[tbx1a1.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(1);
                        dictionarypositionlist.Add(tbx1a1.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx1a2.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx1a2.Text];
                    indicelist.Add(Convert.ToInt32(tbx1i2.Text));
                    dictionaryindicelist[tbx1a2.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx1i2.Text));
                        dictionaryindicelist.Add(tbx1a2.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx1a2.Text];
                    positionlist.Add(1);
                    dictionarypositionlist[tbx1a2.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(1);
                        dictionarypositionlist.Add(tbx1a2.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx1a3.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx1a3.Text];
                    indicelist.Add(Convert.ToInt32(tbx1i3.Text));
                    dictionaryindicelist[tbx1a3.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx1i3.Text));
                        dictionaryindicelist.Add(tbx1a3.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx1a3.Text];
                    positionlist.Add(1);
                    dictionarypositionlist[tbx1a3.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(1);
                        dictionarypositionlist.Add(tbx1a3.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx1a4.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx1a4.Text];
                    indicelist.Add(Convert.ToInt32(tbx1i4.Text));
                    dictionaryindicelist[tbx1a4.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx1i4.Text));
                        dictionaryindicelist.Add(tbx1a4.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx1a4.Text];
                    positionlist.Add(1);
                    dictionarypositionlist[tbx1a4.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(1);
                        dictionarypositionlist.Add(tbx1a4.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx1a5.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx1a5.Text];
                    indicelist.Add(Convert.ToInt32(tbx1i5.Text));
                    dictionaryindicelist[tbx1a5.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx1i5.Text));
                        dictionaryindicelist.Add(tbx1a5.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx1a5.Text];
                    positionlist.Add(1);
                    dictionarypositionlist[tbx1a5.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(1);
                        dictionarypositionlist.Add(tbx1a5.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx1a6.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx1a6.Text];
                    indicelist.Add(Convert.ToInt32(tbx1i6.Text));
                    dictionaryindicelist[tbx1a6.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx1i6.Text));
                        dictionaryindicelist.Add(tbx1a6.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx1a6.Text];
                    positionlist.Add(1);
                    dictionarypositionlist[tbx1a6.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(1);
                        dictionarypositionlist.Add(tbx1a6.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx1a7.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx1a7.Text];
                    indicelist.Add(Convert.ToInt32(tbx1i7.Text));
                    dictionaryindicelist[tbx1a7.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx1i7.Text));
                        dictionaryindicelist.Add(tbx1a7.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx1a7.Text];
                    positionlist.Add(1);
                    dictionarypositionlist[tbx1a7.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(1);
                        dictionarypositionlist.Add(tbx1a7.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx1a8.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx1a8.Text];
                    indicelist.Add(Convert.ToInt32(tbx1i8.Text));
                    dictionaryindicelist[tbx1a8.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx1i8.Text));
                        dictionaryindicelist.Add(tbx1a8.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx1a8.Text];
                    positionlist.Add(1);
                    dictionarypositionlist[tbx1a8.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(1);
                        dictionarypositionlist.Add(tbx1a8.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx1a9.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx1a9.Text];
                    indicelist.Add(Convert.ToInt32(tbx1i9.Text));
                    dictionaryindicelist[tbx1a9.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx1i9.Text));
                        dictionaryindicelist.Add(tbx1a9.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx1a9.Text];
                    positionlist.Add(1);
                    dictionarypositionlist[tbx1a9.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(1);
                        dictionarypositionlist.Add(tbx1a9.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx2a1.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx2a1.Text];
                    indicelist.Add(Convert.ToInt32(tbx2i1.Text));
                    dictionaryindicelist[tbx2a1.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx2i1.Text));
                        dictionaryindicelist.Add(tbx2a1.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx2a1.Text];
                    positionlist.Add(2);
                    dictionarypositionlist[tbx2a1.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(2);
                        dictionarypositionlist.Add(tbx2a1.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx2a2.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx2a2.Text];
                    indicelist.Add(Convert.ToInt32(tbx2i2.Text));
                    dictionaryindicelist[tbx2a2.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx2i2.Text));
                        dictionaryindicelist.Add(tbx2a2.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx2a2.Text];
                    positionlist.Add(2);
                    dictionarypositionlist[tbx2a2.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(2);
                        dictionarypositionlist.Add(tbx2a2.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx2a3.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx2a3.Text];
                    indicelist.Add(Convert.ToInt32(tbx2i3.Text));
                    dictionaryindicelist[tbx2a3.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx2i3.Text));
                        dictionaryindicelist.Add(tbx2a3.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx2a3.Text];
                    positionlist.Add(2);
                    dictionarypositionlist[tbx2a3.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(2);
                        dictionarypositionlist.Add(tbx2a3.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx2a4.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx2a4.Text];
                    indicelist.Add(Convert.ToInt32(tbx2i4.Text));
                    dictionaryindicelist[tbx2a4.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx2i4.Text));
                        dictionaryindicelist.Add(tbx2a4.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx2a4.Text];
                    positionlist.Add(2);
                    dictionarypositionlist[tbx2a4.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(2);
                        dictionarypositionlist.Add(tbx2a4.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx2a5.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx2a5.Text];
                    indicelist.Add(Convert.ToInt32(tbx2i5.Text));
                    dictionaryindicelist[tbx2a5.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx2i5.Text));
                        dictionaryindicelist.Add(tbx2a5.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx2a5.Text];
                    positionlist.Add(2);
                    dictionarypositionlist[tbx2a5.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(2);
                        dictionarypositionlist.Add(tbx2a5.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx2a6.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx2a6.Text];
                    indicelist.Add(Convert.ToInt32(tbx2i6.Text));
                    dictionaryindicelist[tbx2a6.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx2i6.Text));
                        dictionaryindicelist.Add(tbx2a6.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx2a6.Text];
                    positionlist.Add(2);
                    dictionarypositionlist[tbx2a6.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(2);
                        dictionarypositionlist.Add(tbx2a6.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx2a7.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx2a7.Text];
                    indicelist.Add(Convert.ToInt32(tbx2i7.Text));
                    dictionaryindicelist[tbx2a7.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx2i7.Text));
                        dictionaryindicelist.Add(tbx2a7.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx2a7.Text];
                    positionlist.Add(2);
                    dictionarypositionlist[tbx2a7.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(2);
                        dictionarypositionlist.Add(tbx2a7.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx2a8.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx2a8.Text];
                    indicelist.Add(Convert.ToInt32(tbx2i8.Text));
                    dictionaryindicelist[tbx2a8.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx2i8.Text));
                        dictionaryindicelist.Add(tbx2a8.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx2a8.Text];
                    positionlist.Add(2);
                    dictionarypositionlist[tbx2a8.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(2);
                        dictionarypositionlist.Add(tbx2a8.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx2a9.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx2a9.Text];
                    indicelist.Add(Convert.ToInt32(tbx2i9.Text));
                    dictionaryindicelist[tbx2a9.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx2i9.Text));
                        dictionaryindicelist.Add(tbx2a9.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx2a9.Text];
                    positionlist.Add(2);
                    dictionarypositionlist[tbx2a9.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(2);
                        dictionarypositionlist.Add(tbx2a9.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx3a1.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx3a1.Text];
                    indicelist.Add(Convert.ToInt32(tbx3i1.Text));
                    dictionaryindicelist[tbx3a1.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx3i1.Text));
                        dictionaryindicelist.Add(tbx3a1.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx3a1.Text];
                    positionlist.Add(3);
                    dictionarypositionlist[tbx3a1.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(3);
                        dictionarypositionlist.Add(tbx3a1.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx3a2.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx3a2.Text];
                    indicelist.Add(Convert.ToInt32(tbx3i2.Text));
                    dictionaryindicelist[tbx3a2.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx3i2.Text));
                        dictionaryindicelist.Add(tbx3a2.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx3a2.Text];
                    positionlist.Add(3);
                    dictionarypositionlist[tbx3a2.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(3);
                        dictionarypositionlist.Add(tbx3a2.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx3a3.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx3a3.Text];
                    indicelist.Add(Convert.ToInt32(tbx3i3.Text));
                    dictionaryindicelist[tbx3a3.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx3i3.Text));
                        dictionaryindicelist.Add(tbx3a3.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx3a3.Text];
                    positionlist.Add(3);
                    dictionarypositionlist[tbx3a3.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(3);
                        dictionarypositionlist.Add(tbx3a3.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx3a4.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx3a4.Text];
                    indicelist.Add(Convert.ToInt32(tbx3i4.Text));
                    dictionaryindicelist[tbx3a4.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx3i4.Text));
                        dictionaryindicelist.Add(tbx3a4.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx3a4.Text];
                    positionlist.Add(3);
                    dictionarypositionlist[tbx3a4.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(3);
                        dictionarypositionlist.Add(tbx3a4.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx3a5.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx3a5.Text];
                    indicelist.Add(Convert.ToInt32(tbx3i5.Text));
                    dictionaryindicelist[tbx3a5.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx3i5.Text));
                        dictionaryindicelist.Add(tbx3a5.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx3a5.Text];
                    positionlist.Add(3);
                    dictionarypositionlist[tbx3a5.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(3);
                        dictionarypositionlist.Add(tbx3a5.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx3a6.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx3a6.Text];
                    indicelist.Add(Convert.ToInt32(tbx3i6.Text));
                    dictionaryindicelist[tbx3a6.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx3i6.Text));
                        dictionaryindicelist.Add(tbx3a6.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx3a6.Text];
                    positionlist.Add(3);
                    dictionarypositionlist[tbx3a6.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(3);
                        dictionarypositionlist.Add(tbx3a6.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx3a7.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx3a7.Text];
                    indicelist.Add(Convert.ToInt32(tbx3i7.Text));
                    dictionaryindicelist[tbx3a7.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx3i7.Text));
                        dictionaryindicelist.Add(tbx3a7.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx3a7.Text];
                    positionlist.Add(3);
                    dictionarypositionlist[tbx3a7.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(3);
                        dictionarypositionlist.Add(tbx3a7.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx3a8.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx3a8.Text];
                    indicelist.Add(Convert.ToInt32(tbx3i8.Text));
                    dictionaryindicelist[tbx3a8.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx3i8.Text));
                        dictionaryindicelist.Add(tbx3a8.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx3a8.Text];
                    positionlist.Add(3);
                    dictionarypositionlist[tbx3a8.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(3);
                        dictionarypositionlist.Add(tbx3a8.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx3a9.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx3a9.Text];
                    indicelist.Add(Convert.ToInt32(tbx3i9.Text));
                    dictionaryindicelist[tbx3a9.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx3i9.Text));
                        dictionaryindicelist.Add(tbx3a9.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx3a9.Text];
                    positionlist.Add(3);
                    dictionarypositionlist[tbx3a9.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(3);
                        dictionarypositionlist.Add(tbx3a9.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx4a1.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx4a1.Text];
                    indicelist.Add(Convert.ToInt32(tbx4i1.Text));
                    dictionaryindicelist[tbx4a1.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx4i1.Text));
                        dictionaryindicelist.Add(tbx4a1.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx4a1.Text];
                    positionlist.Add(4);
                    dictionarypositionlist[tbx4a1.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(4);
                        dictionarypositionlist.Add(tbx4a1.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx4a2.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx4a2.Text];
                    indicelist.Add(Convert.ToInt32(tbx4i2.Text));
                    dictionaryindicelist[tbx4a2.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx4i2.Text));
                        dictionaryindicelist.Add(tbx4a2.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx4a2.Text];
                    positionlist.Add(4);
                    dictionarypositionlist[tbx4a2.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(4);
                        dictionarypositionlist.Add(tbx4a2.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx4a3.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx4a3.Text];
                    indicelist.Add(Convert.ToInt32(tbx4i3.Text));
                    dictionaryindicelist[tbx4a3.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx4i3.Text));
                        dictionaryindicelist.Add(tbx4a3.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx4a3.Text];
                    positionlist.Add(4);
                    dictionarypositionlist[tbx4a3.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(4);
                        dictionarypositionlist.Add(tbx4a3.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx4a4.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx4a4.Text];
                    indicelist.Add(Convert.ToInt32(tbx4i4.Text));
                    dictionaryindicelist[tbx4a4.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx4i4.Text));
                        dictionaryindicelist.Add(tbx4a4.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx4a4.Text];
                    positionlist.Add(4);
                    dictionarypositionlist[tbx4a4.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(4);
                        dictionarypositionlist.Add(tbx4a4.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx4a5.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx4a5.Text];
                    indicelist.Add(Convert.ToInt32(tbx4i5.Text));
                    dictionaryindicelist[tbx4a5.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx4i5.Text));
                        dictionaryindicelist.Add(tbx4a5.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx4a5.Text];
                    positionlist.Add(4);
                    dictionarypositionlist[tbx4a5.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(4);
                        dictionarypositionlist.Add(tbx4a5.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx4a6.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx4a6.Text];
                    indicelist.Add(Convert.ToInt32(tbx4i6.Text));
                    dictionaryindicelist[tbx4a6.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx4i6.Text));
                        dictionaryindicelist.Add(tbx4a6.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx4a6.Text];
                    positionlist.Add(4);
                    dictionarypositionlist[tbx4a6.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(4);
                        dictionarypositionlist.Add(tbx4a6.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx4a7.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx4a7.Text];
                    indicelist.Add(Convert.ToInt32(tbx4i7.Text));
                    dictionaryindicelist[tbx4a7.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx4i7.Text));
                        dictionaryindicelist.Add(tbx4a7.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx4a7.Text];
                    positionlist.Add(4);
                    dictionarypositionlist[tbx4a7.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(4);
                        dictionarypositionlist.Add(tbx4a7.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx4a8.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx4a8.Text];
                    indicelist.Add(Convert.ToInt32(tbx4i8.Text));
                    dictionaryindicelist[tbx4a8.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx4i8.Text));
                        dictionaryindicelist.Add(tbx4a8.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx4a8.Text];
                    positionlist.Add(4);
                    dictionarypositionlist[tbx4a8.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(4);
                        dictionarypositionlist.Add(tbx4a8.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx4a9.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx4a9.Text];
                    indicelist.Add(Convert.ToInt32(tbx4i9.Text));
                    dictionaryindicelist[tbx4a9.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx4i9.Text));
                        dictionaryindicelist.Add(tbx4a9.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx4a9.Text];
                    positionlist.Add(4);
                    dictionarypositionlist[tbx4a9.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(4);
                        dictionarypositionlist.Add(tbx4a9.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx5a1.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx5a1.Text];
                    indicelist.Add(Convert.ToInt32(tbx5i1.Text));
                    dictionaryindicelist[tbx5a1.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx5i1.Text));
                        dictionaryindicelist.Add(tbx5a1.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx5a1.Text];
                    positionlist.Add(5);
                    dictionarypositionlist[tbx5a1.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(5);
                        dictionarypositionlist.Add(tbx5a1.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx5a2.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx5a2.Text];
                    indicelist.Add(Convert.ToInt32(tbx5i2.Text));
                    dictionaryindicelist[tbx5a2.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx5i2.Text));
                        dictionaryindicelist.Add(tbx5a2.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx5a2.Text];
                    positionlist.Add(5);
                    dictionarypositionlist[tbx5a2.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(5);
                        dictionarypositionlist.Add(tbx5a2.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx5a3.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx5a3.Text];
                    indicelist.Add(Convert.ToInt32(tbx5i3.Text));
                    dictionaryindicelist[tbx5a3.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx5i3.Text));
                        dictionaryindicelist.Add(tbx5a3.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx5a3.Text];
                    positionlist.Add(5);
                    dictionarypositionlist[tbx5a3.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(5);
                        dictionarypositionlist.Add(tbx5a3.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx5a4.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx5a4.Text];
                    indicelist.Add(Convert.ToInt32(tbx5i4.Text));
                    dictionaryindicelist[tbx5a4.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx5i4.Text));
                        dictionaryindicelist.Add(tbx5a4.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx5a4.Text];
                    positionlist.Add(5);
                    dictionarypositionlist[tbx5a4.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(5);
                        dictionarypositionlist.Add(tbx5a4.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx5a5.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx5a5.Text];
                    indicelist.Add(Convert.ToInt32(tbx5i5.Text));
                    dictionaryindicelist[tbx5a5.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx5i5.Text));
                        dictionaryindicelist.Add(tbx5a5.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx5a5.Text];
                    positionlist.Add(5);
                    dictionarypositionlist[tbx5a5.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(5);
                        dictionarypositionlist.Add(tbx5a5.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx5a6.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx5a6.Text];
                    indicelist.Add(Convert.ToInt32(tbx5i6.Text));
                    dictionaryindicelist[tbx5a6.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx5i6.Text));
                        dictionaryindicelist.Add(tbx5a6.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx5a6.Text];
                    positionlist.Add(5);
                    dictionarypositionlist[tbx5a6.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(5);
                        dictionarypositionlist.Add(tbx5a6.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx5a7.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx5a7.Text];
                    indicelist.Add(Convert.ToInt32(tbx5i7.Text));
                    dictionaryindicelist[tbx5a7.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx5i7.Text));
                        dictionaryindicelist.Add(tbx5a7.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx5a7.Text];
                    positionlist.Add(5);
                    dictionarypositionlist[tbx5a7.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(5);
                        dictionarypositionlist.Add(tbx5a7.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx5a8.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx5a8.Text];
                    indicelist.Add(Convert.ToInt32(tbx5i8.Text));
                    dictionaryindicelist[tbx5a8.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx5i8.Text));
                        dictionaryindicelist.Add(tbx5a8.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx5a8.Text];
                    positionlist.Add(5);
                    dictionarypositionlist[tbx5a8.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(5);
                        dictionarypositionlist.Add(tbx5a8.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx5a9.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx5a9.Text];
                    indicelist.Add(Convert.ToInt32(tbx5i9.Text));
                    dictionaryindicelist[tbx5a9.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(Convert.ToInt32(tbx5i9.Text));
                        dictionaryindicelist.Add(tbx5a9.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx5a9.Text];
                    positionlist.Add(5);
                    dictionarypositionlist[tbx5a9.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(5);
                        dictionarypositionlist.Add(tbx5a9.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx6a1.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx6a1.Text];
                    indicelist.Add(-1 * Convert.ToInt32(tbx6i1.Text));
                    dictionaryindicelist[tbx6a1.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(-1 * Convert.ToInt32(tbx6i1.Text));
                        dictionaryindicelist.Add(tbx6a1.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx6a1.Text];
                    positionlist.Add(6);
                    dictionarypositionlist[tbx6a1.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(6);
                        dictionarypositionlist.Add(tbx6a1.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx6a2.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx6a2.Text];
                    indicelist.Add(-1 * Convert.ToInt32(tbx6i2.Text));
                    dictionaryindicelist[tbx6a2.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(-1 * Convert.ToInt32(tbx6i2.Text));
                        dictionaryindicelist.Add(tbx6a2.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx6a2.Text];
                    positionlist.Add(6);
                    dictionarypositionlist[tbx6a2.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(6);
                        dictionarypositionlist.Add(tbx6a2.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx6a3.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx6a3.Text];
                    indicelist.Add(-1 * Convert.ToInt32(tbx6i3.Text));
                    dictionaryindicelist[tbx6a3.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(-1 * Convert.ToInt32(tbx6i3.Text));
                        dictionaryindicelist.Add(tbx6a3.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx6a3.Text];
                    positionlist.Add(6);
                    dictionarypositionlist[tbx6a3.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(6);
                        dictionarypositionlist.Add(tbx6a3.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx6a4.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx6a4.Text];
                    indicelist.Add(-1 * Convert.ToInt32(tbx6i4.Text));
                    dictionaryindicelist[tbx6a4.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(-1 * Convert.ToInt32(tbx6i4.Text));
                        dictionaryindicelist.Add(tbx6a4.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx6a4.Text];
                    positionlist.Add(6);
                    dictionarypositionlist[tbx6a4.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(6);
                        dictionarypositionlist.Add(tbx6a4.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx6a5.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx6a5.Text];
                    indicelist.Add(-1 * Convert.ToInt32(tbx6i5.Text));
                    dictionaryindicelist[tbx6a5.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(-1 * Convert.ToInt32(tbx6i5.Text));
                        dictionaryindicelist.Add(tbx6a5.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx6a5.Text];
                    positionlist.Add(6);
                    dictionarypositionlist[tbx6a5.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(6);
                        dictionarypositionlist.Add(tbx6a5.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx6a6.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx6a6.Text];
                    indicelist.Add(-1 * Convert.ToInt32(tbx6i6.Text));
                    dictionaryindicelist[tbx6a6.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(-1 * Convert.ToInt32(tbx6i6.Text));
                        dictionaryindicelist.Add(tbx6a6.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx6a6.Text];
                    positionlist.Add(6);
                    dictionarypositionlist[tbx6a6.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(6);
                        dictionarypositionlist.Add(tbx6a6.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx6a7.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx6a7.Text];
                    indicelist.Add(-1 * Convert.ToInt32(tbx6i7.Text));
                    dictionaryindicelist[tbx6a7.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(-1 * Convert.ToInt32(tbx6i7.Text));
                        dictionaryindicelist.Add(tbx6a7.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx6a7.Text];
                    positionlist.Add(6);
                    dictionarypositionlist[tbx6a7.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(6);
                        dictionarypositionlist.Add(tbx6a7.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx6a8.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx6a8.Text];
                    indicelist.Add(-1 * Convert.ToInt32(tbx6i8.Text));
                    dictionaryindicelist[tbx6a8.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(-1 * Convert.ToInt32(tbx6i8.Text));
                        dictionaryindicelist.Add(tbx6a8.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx6a8.Text];
                    positionlist.Add(6);
                    dictionarypositionlist[tbx6a8.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(6);
                        dictionarypositionlist.Add(tbx6a8.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx6a9.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx6a9.Text];
                    indicelist.Add(-1 * Convert.ToInt32(tbx6i9.Text));
                    dictionaryindicelist[tbx6a9.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(-1 * Convert.ToInt32(tbx6i9.Text));
                        dictionaryindicelist.Add(tbx6a9.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx6a9.Text];
                    positionlist.Add(6);
                    dictionarypositionlist[tbx6a9.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(6);
                        dictionarypositionlist.Add(tbx6a9.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx7a1.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx7a1.Text];
                    indicelist.Add(-1 * Convert.ToInt32(tbx7i1.Text));
                    dictionaryindicelist[tbx7a1.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(-1 * Convert.ToInt32(tbx7i1.Text));
                        dictionaryindicelist.Add(tbx7a1.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx7a1.Text];
                    positionlist.Add(7);
                    dictionarypositionlist[tbx7a1.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(7);
                        dictionarypositionlist.Add(tbx7a1.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx7a2.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx7a2.Text];
                    indicelist.Add(-1 * Convert.ToInt32(tbx7i2.Text));
                    dictionaryindicelist[tbx7a2.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(-1 * Convert.ToInt32(tbx7i2.Text));
                        dictionaryindicelist.Add(tbx7a2.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx7a2.Text];
                    positionlist.Add(7);
                    dictionarypositionlist[tbx7a2.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(7);
                        dictionarypositionlist.Add(tbx7a2.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx7a3.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx7a3.Text];
                    indicelist.Add(-1 * Convert.ToInt32(tbx7i3.Text));
                    dictionaryindicelist[tbx7a3.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(-1 * Convert.ToInt32(tbx7i3.Text));
                        dictionaryindicelist.Add(tbx7a3.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx7a3.Text];
                    positionlist.Add(7);
                    dictionarypositionlist[tbx7a3.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(7);
                        dictionarypositionlist.Add(tbx7a3.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx7a4.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx7a4.Text];
                    indicelist.Add(-1 * Convert.ToInt32(tbx7i4.Text));
                    dictionaryindicelist[tbx7a4.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(-1 * Convert.ToInt32(tbx7i4.Text));
                        dictionaryindicelist.Add(tbx7a4.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx7a4.Text];
                    positionlist.Add(7);
                    dictionarypositionlist[tbx7a4.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(7);
                        dictionarypositionlist.Add(tbx7a4.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx7a5.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx7a5.Text];
                    indicelist.Add(-1 * Convert.ToInt32(tbx7i5.Text));
                    dictionaryindicelist[tbx7a5.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(-1 * Convert.ToInt32(tbx7i5.Text));
                        dictionaryindicelist.Add(tbx7a5.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx7a5.Text];
                    positionlist.Add(7);
                    dictionarypositionlist[tbx7a5.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(7);
                        dictionarypositionlist.Add(tbx7a5.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx7a6.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx7a6.Text];
                    indicelist.Add(-1 * Convert.ToInt32(tbx7i6.Text));
                    dictionaryindicelist[tbx7a6.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(-1 * Convert.ToInt32(tbx7i6.Text));
                        dictionaryindicelist.Add(tbx7a6.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx7a6.Text];
                    positionlist.Add(7);
                    dictionarypositionlist[tbx7a6.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(7);
                        dictionarypositionlist.Add(tbx7a6.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx7a7.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx7a7.Text];
                    indicelist.Add(-1 * Convert.ToInt32(tbx7i7.Text));
                    dictionaryindicelist[tbx7a7.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(-1 * Convert.ToInt32(tbx7i7.Text));
                        dictionaryindicelist.Add(tbx7a7.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx7a7.Text];
                    positionlist.Add(7);
                    dictionarypositionlist[tbx7a7.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(7);
                        dictionarypositionlist.Add(tbx7a7.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx7a8.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx7a8.Text];
                    indicelist.Add(-1 * Convert.ToInt32(tbx7i8.Text));
                    dictionaryindicelist[tbx7a8.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(-1 * Convert.ToInt32(tbx7i8.Text));
                        dictionaryindicelist.Add(tbx7a8.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx7a8.Text];
                    positionlist.Add(7);
                    dictionarypositionlist[tbx7a8.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(7);
                        dictionarypositionlist.Add(tbx7a8.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx7a9.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx7a9.Text];
                    indicelist.Add(-1 * Convert.ToInt32(tbx7i9.Text));
                    dictionaryindicelist[tbx7a9.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(-1 * Convert.ToInt32(tbx7i9.Text));
                        dictionaryindicelist.Add(tbx7a9.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx7a9.Text];
                    positionlist.Add(7);
                    dictionarypositionlist[tbx7a9.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(7);
                        dictionarypositionlist.Add(tbx7a9.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx8a1.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx8a1.Text];
                    indicelist.Add(-1 * Convert.ToInt32(tbx8i1.Text));
                    dictionaryindicelist[tbx8a1.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(-1 * Convert.ToInt32(tbx8i1.Text));
                        dictionaryindicelist.Add(tbx8a1.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx8a1.Text];
                    positionlist.Add(8);
                    dictionarypositionlist[tbx8a1.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(8);
                        dictionarypositionlist.Add(tbx8a1.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx8a2.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx8a2.Text];
                    indicelist.Add(-1 * Convert.ToInt32(tbx8i2.Text));
                    dictionaryindicelist[tbx8a2.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(-1 * Convert.ToInt32(tbx8i2.Text));
                        dictionaryindicelist.Add(tbx8a2.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx8a2.Text];
                    positionlist.Add(8);
                    dictionarypositionlist[tbx8a2.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(8);
                        dictionarypositionlist.Add(tbx8a2.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx8a3.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx8a3.Text];
                    indicelist.Add(-1 * Convert.ToInt32(tbx8i3.Text));
                    dictionaryindicelist[tbx8a3.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(-1 * Convert.ToInt32(tbx8i3.Text));
                        dictionaryindicelist.Add(tbx8a3.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx8a3.Text];
                    positionlist.Add(8);
                    dictionarypositionlist[tbx8a3.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(8);
                        dictionarypositionlist.Add(tbx8a3.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx8a4.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx8a4.Text];
                    indicelist.Add(-1 * Convert.ToInt32(tbx8i4.Text));
                    dictionaryindicelist[tbx8a4.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(-1 * Convert.ToInt32(tbx8i4.Text));
                        dictionaryindicelist.Add(tbx8a4.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx8a4.Text];
                    positionlist.Add(8);
                    dictionarypositionlist[tbx8a4.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(8);
                        dictionarypositionlist.Add(tbx8a4.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx8a5.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx8a5.Text];
                    indicelist.Add(-1 * Convert.ToInt32(tbx8i5.Text));
                    dictionaryindicelist[tbx8a5.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(-1 * Convert.ToInt32(tbx8i5.Text));
                        dictionaryindicelist.Add(tbx8a5.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx8a5.Text];
                    positionlist.Add(8);
                    dictionarypositionlist[tbx8a5.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(8);
                        dictionarypositionlist.Add(tbx8a5.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx8a6.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx8a6.Text];
                    indicelist.Add(-1 * Convert.ToInt32(tbx8i6.Text));
                    dictionaryindicelist[tbx8a6.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(-1 * Convert.ToInt32(tbx8i6.Text));
                        dictionaryindicelist.Add(tbx8a6.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx8a6.Text];
                    positionlist.Add(8);
                    dictionarypositionlist[tbx8a6.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(8);
                        dictionarypositionlist.Add(tbx8a6.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx8a7.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx8a7.Text];
                    indicelist.Add(-1 * Convert.ToInt32(tbx8i7.Text));
                    dictionaryindicelist[tbx8a7.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(-1 * Convert.ToInt32(tbx8i7.Text));
                        dictionaryindicelist.Add(tbx8a7.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx8a7.Text];
                    positionlist.Add(8);
                    dictionarypositionlist[tbx8a7.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(8);
                        dictionarypositionlist.Add(tbx8a7.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx8a8.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx8a8.Text];
                    indicelist.Add(-1 * Convert.ToInt32(tbx8i8.Text));
                    dictionaryindicelist[tbx8a8.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(-1 * Convert.ToInt32(tbx8i8.Text));
                        dictionaryindicelist.Add(tbx8a8.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx8a8.Text];
                    positionlist.Add(8);
                    dictionarypositionlist[tbx8a8.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(8);
                        dictionarypositionlist.Add(tbx8a8.Text, positionlist);
                    }
                    catch { }
                }
            }
            if (tbx8a9.Text != "")
            {
                try
                {
                    indicelist = new List<int>();
                    indicelist = dictionaryindicelist[tbx8a9.Text];
                    indicelist.Add(-1 * Convert.ToInt32(tbx8i9.Text));
                    dictionaryindicelist[tbx8a9.Text] = indicelist;
                }
                catch
                {
                    try
                    {
                        indicelist = new List<int>();
                        indicelist.Add(-1 * Convert.ToInt32(tbx8i9.Text));
                        dictionaryindicelist.Add(tbx8a9.Text, indicelist);
                    }
                    catch { }
                }
                try
                {
                    positionlist = new List<int>();
                    positionlist = dictionarypositionlist[tbx8a9.Text];
                    positionlist.Add(8);
                    dictionarypositionlist[tbx8a9.Text] = positionlist;
                }
                catch
                {
                    try
                    {
                        positionlist = new List<int>();
                        positionlist.Add(8);
                        dictionarypositionlist.Add(tbx8a9.Text, positionlist);
                    }
                    catch { }
                }
            }
        }
        private void FillMatrix()
        {
            try
            {
                string atome = dictionaryindicelist.Keys.ElementAt(0);
                line1[dictionarypositionlist[atome][0]] = dictionaryindicelist[atome][0];
                line1[dictionarypositionlist[atome][1]] = dictionaryindicelist[atome][1];
                line1[dictionarypositionlist[atome][2]] = dictionaryindicelist[atome][2];
                line1[dictionarypositionlist[atome][3]] = dictionaryindicelist[atome][3];
                line1[dictionarypositionlist[atome][4]] = dictionaryindicelist[atome][4];
                line1[dictionarypositionlist[atome][5]] = dictionaryindicelist[atome][5];
                line1[dictionarypositionlist[atome][6]] = dictionaryindicelist[atome][6];
                line1[dictionarypositionlist[atome][7]] = dictionaryindicelist[atome][7];
                line1[dictionarypositionlist[atome][8]] = dictionaryindicelist[atome][8];
            }
            catch { }
            try
            {
                string atome = dictionaryindicelist.Keys.ElementAt(1);
                line2[dictionarypositionlist[atome][0]] = dictionaryindicelist[atome][0];
                line2[dictionarypositionlist[atome][1]] = dictionaryindicelist[atome][1];
                line2[dictionarypositionlist[atome][2]] = dictionaryindicelist[atome][2];
                line2[dictionarypositionlist[atome][3]] = dictionaryindicelist[atome][3];
                line2[dictionarypositionlist[atome][4]] = dictionaryindicelist[atome][4];
                line2[dictionarypositionlist[atome][5]] = dictionaryindicelist[atome][5];
                line2[dictionarypositionlist[atome][6]] = dictionaryindicelist[atome][6];
                line2[dictionarypositionlist[atome][7]] = dictionaryindicelist[atome][7];
                line2[dictionarypositionlist[atome][8]] = dictionaryindicelist[atome][8];
            }
            catch { }
            try
            {
                string atome = dictionaryindicelist.Keys.ElementAt(2);
                line3[dictionarypositionlist[atome][0]] = dictionaryindicelist[atome][0];
                line3[dictionarypositionlist[atome][1]] = dictionaryindicelist[atome][1];
                line3[dictionarypositionlist[atome][2]] = dictionaryindicelist[atome][2];
                line3[dictionarypositionlist[atome][3]] = dictionaryindicelist[atome][3];
                line3[dictionarypositionlist[atome][4]] = dictionaryindicelist[atome][4];
                line3[dictionarypositionlist[atome][5]] = dictionaryindicelist[atome][5];
                line3[dictionarypositionlist[atome][6]] = dictionaryindicelist[atome][6];
                line3[dictionarypositionlist[atome][7]] = dictionaryindicelist[atome][7];
                line3[dictionarypositionlist[atome][8]] = dictionaryindicelist[atome][8];
            }
            catch { }
            try
            {
                string atome = dictionaryindicelist.Keys.ElementAt(3);
                line4[dictionarypositionlist[atome][0]] = dictionaryindicelist[atome][0];
                line4[dictionarypositionlist[atome][1]] = dictionaryindicelist[atome][1];
                line4[dictionarypositionlist[atome][2]] = dictionaryindicelist[atome][2];
                line4[dictionarypositionlist[atome][3]] = dictionaryindicelist[atome][3];
                line4[dictionarypositionlist[atome][4]] = dictionaryindicelist[atome][4];
                line4[dictionarypositionlist[atome][5]] = dictionaryindicelist[atome][5];
                line4[dictionarypositionlist[atome][6]] = dictionaryindicelist[atome][6];
                line4[dictionarypositionlist[atome][7]] = dictionaryindicelist[atome][7];
                line4[dictionarypositionlist[atome][8]] = dictionaryindicelist[atome][8];
            }
            catch { }
            try
            {
                string atome = dictionaryindicelist.Keys.ElementAt(4);
                line5[dictionarypositionlist[atome][0]] = dictionaryindicelist[atome][0];
                line5[dictionarypositionlist[atome][1]] = dictionaryindicelist[atome][1];
                line5[dictionarypositionlist[atome][2]] = dictionaryindicelist[atome][2];
                line5[dictionarypositionlist[atome][3]] = dictionaryindicelist[atome][3];
                line5[dictionarypositionlist[atome][4]] = dictionaryindicelist[atome][4];
                line5[dictionarypositionlist[atome][5]] = dictionaryindicelist[atome][5];
                line5[dictionarypositionlist[atome][6]] = dictionaryindicelist[atome][6];
                line5[dictionarypositionlist[atome][7]] = dictionaryindicelist[atome][7];
                line5[dictionarypositionlist[atome][8]] = dictionaryindicelist[atome][8];
            }
            catch { }
            try
            {
                string atome = dictionaryindicelist.Keys.ElementAt(5);
                line6[dictionarypositionlist[atome][0]] = dictionaryindicelist[atome][0];
                line6[dictionarypositionlist[atome][1]] = dictionaryindicelist[atome][1];
                line6[dictionarypositionlist[atome][2]] = dictionaryindicelist[atome][2];
                line6[dictionarypositionlist[atome][3]] = dictionaryindicelist[atome][3];
                line6[dictionarypositionlist[atome][4]] = dictionaryindicelist[atome][4];
                line6[dictionarypositionlist[atome][5]] = dictionaryindicelist[atome][5];
                line6[dictionarypositionlist[atome][6]] = dictionaryindicelist[atome][6];
                line6[dictionarypositionlist[atome][7]] = dictionaryindicelist[atome][7];
                line6[dictionarypositionlist[atome][8]] = dictionaryindicelist[atome][8];
            }
            catch { }
            try
            {
                string atome = dictionaryindicelist.Keys.ElementAt(6);
                line7[dictionarypositionlist[atome][0]] = dictionaryindicelist[atome][0];
                line7[dictionarypositionlist[atome][1]] = dictionaryindicelist[atome][1];
                line7[dictionarypositionlist[atome][2]] = dictionaryindicelist[atome][2];
                line7[dictionarypositionlist[atome][3]] = dictionaryindicelist[atome][3];
                line7[dictionarypositionlist[atome][4]] = dictionaryindicelist[atome][4];
                line7[dictionarypositionlist[atome][5]] = dictionaryindicelist[atome][5];
                line7[dictionarypositionlist[atome][6]] = dictionaryindicelist[atome][6];
                line7[dictionarypositionlist[atome][7]] = dictionaryindicelist[atome][7];
                line7[dictionarypositionlist[atome][8]] = dictionaryindicelist[atome][8];
            }
            catch { }
            try
            {
                string atome = dictionaryindicelist.Keys.ElementAt(7);
                line8[dictionarypositionlist[atome][0]] = dictionaryindicelist[atome][0];
                line8[dictionarypositionlist[atome][1]] = dictionaryindicelist[atome][1];
                line8[dictionarypositionlist[atome][2]] = dictionaryindicelist[atome][2];
                line8[dictionarypositionlist[atome][3]] = dictionaryindicelist[atome][3];
                line8[dictionarypositionlist[atome][4]] = dictionaryindicelist[atome][4];
                line8[dictionarypositionlist[atome][5]] = dictionaryindicelist[atome][5];
                line8[dictionarypositionlist[atome][6]] = dictionaryindicelist[atome][6];
                line8[dictionarypositionlist[atome][7]] = dictionaryindicelist[atome][7];
                line8[dictionarypositionlist[atome][8]] = dictionaryindicelist[atome][8];
            }
            catch { }
            try
            {
                string atome = dictionaryindicelist.Keys.ElementAt(8);
                line9[dictionarypositionlist[atome][0]] = dictionaryindicelist[atome][0];
                line9[dictionarypositionlist[atome][1]] = dictionaryindicelist[atome][1];
                line9[dictionarypositionlist[atome][2]] = dictionaryindicelist[atome][2];
                line9[dictionarypositionlist[atome][3]] = dictionaryindicelist[atome][3];
                line9[dictionarypositionlist[atome][4]] = dictionaryindicelist[atome][4];
                line9[dictionarypositionlist[atome][5]] = dictionaryindicelist[atome][5];
                line9[dictionarypositionlist[atome][6]] = dictionaryindicelist[atome][6];
                line9[dictionarypositionlist[atome][7]] = dictionaryindicelist[atome][7];
                line9[dictionarypositionlist[atome][8]] = dictionaryindicelist[atome][8];
            }
            catch { }
        }
        private void SolveMatrix()
        {
            Matrix<double> A = Matrix<double>.Build.DenseOfArray(new double[,] {
                { line1[0], line1[1], line1[2], line1[3], line1[4], line1[6], line1[6], line1[7] },
                { line2[0], line2[1], line2[2], line2[3], line2[4], line2[6], line2[6], line2[7] },
                { line3[0], line3[1], line3[2], line3[3], line3[4], line3[6], line3[6], line3[7] },
                { line4[0], line4[1], line4[2], line4[3], line4[4], line4[6], line4[6], line4[7] },
                { line5[0], line5[1], line5[2], line5[3], line5[4], line5[6], line5[6], line5[7] },
                { line6[0], line6[1], line6[2], line6[3], line6[4], line6[6], line6[6], line6[7] },
                { line7[0], line7[1], line7[2], line7[3], line7[4], line7[6], line7[6], line7[7] },
                { line8[0], line8[1], line8[2], line8[3], line8[4], line8[6], line8[6], line8[7] },
                { line9[0], line9[1], line9[2], line9[3], line9[4], line9[6], line9[6], line9[7] },
            });
            if (tbx8a1.Text == "")
            {
                A = A.RemoveColumn(7);
            }
            if (tbx7a1.Text == "")
            {
                A = A.RemoveColumn(6);
            }
            if (tbx6a1.Text == "")
            {
                A = A.RemoveColumn(5);
            }
            if (tbx4a1.Text == "")
            {
                A = A.RemoveColumn(4);
            }
            if (tbx3a1.Text == "")
            {
                A = A.RemoveColumn(3);
            }
            if (tbx2a1.Text == "")
            {
                A = A.RemoveColumn(2);
            }
            if (tbx1a1.Text == "")
            {
                A = A.RemoveColumn(1);
            }
            if (tbxka1.Text == "")
            {
                A = A.RemoveColumn(0);
            }
            Vector<double> B = Vector<double>.Build.Dense(new double[] { line1[5], line2[5], line3[5], line4[5], line5[5], line6[5], line7[5], line8[5], line9[5] });
            var result = A.Solve(B);
            int n = 0;
            if (tbxka1.Text != "")
            {
                try
                {
                    tbxk.Text = result[n].ToString();
                    n++;
                }
                catch { }
            }
            if (tbx1a1.Text != "")
            {
                try
                {
                    tbx1.Text = result[n].ToString();
                    n++;
                }
                catch { }
            }
            if (tbx2a1.Text != "")
            {
                try
                {
                    tbx2.Text = result[n].ToString();
                    n++;
                }
                catch { }
            }
            if (tbx3a1.Text != "")
            {
                try
                {
                    tbx3.Text = result[n].ToString();
                    n++;
                }
                catch { }
            }
            if (tbx4a1.Text != "")
            {
                try
                {
                    tbx4.Text = result[n].ToString();
                    n++;
                }
                catch { }
            }
            if (tbx6a1.Text != "")
            {
                try
                {
                    tbx6.Text = result[n].ToString();
                    n++;
                }
                catch { }
            }
            if (tbx7a1.Text != "")
            {
                try
                {
                    tbx7.Text = result[n].ToString();
                    n++;
                }
                catch { }
            }
            if (tbx8a1.Text != "")
            {
                try
                {
                    tbx8.Text = result[n].ToString();
                }
                catch { }
            }
        }
    }
}