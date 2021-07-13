using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading;

namespace WBS_Kplus_SN
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        int countdown = 5;
        string snText;
        string[] snArray;

        public Form1()
        {
            InitializeComponent();
            this.Text = "WBS KPlus Seriennummern Tool";
            timer.Tick += Timer_Tick;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            lbCountdown.Text = countdown.ToString();
            lbCountdown.Visible = true;
            timer.Interval = 1000;
            timer.Start();
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            countdown--;
            lbCountdown.Text = countdown.ToString();
            if(countdown <= 0)
            {
                timer.Stop();
                lbCountdown.Visible = false;
                countdown = 5;
                btnStart.Enabled = true;
                SimulateKeyInput(snArray);

            }
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            textSplit();
        }

        private void rbMitKomma_CheckedChanged(object sender, EventArgs e)
        {
            //textSplit();
        }

        private void rbOhneKomma_CheckedChanged(object sender, EventArgs e)
        {
            //textSplit();
        }

        //private void rbMitSn_CheckedChanged(object sender, EventArgs e)
        //{
        //    //textSplit();
        //}

        private void rbIndiv_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIndiv.Checked)
            {
                tbIndiv.Enabled = true;
            }
            else
            {
                tbIndiv.Enabled = false;
            }
        }

        private void rbMitKomma_Click(object sender, EventArgs e)
        {
            textSplit();
        }

        private void rbOhneKomma_Click(object sender, EventArgs e)
        {
            textSplit();
        }

        //nichtmehr in Verwendung
        //private void rbMitSn_Click(object sender, EventArgs e)
        //{
        //    textSplit();
        //}

        //ruft bei klick auf Obj Methode zum trennen der SN auf und übergibt das/die Trenzeichen
        private void rbIndiv_Click(object sender, EventArgs e)
        {
            textSplit(tbIndiv.Text.ToString());
        }

        private void tbIndiv_TextChanged(object sender, EventArgs e)
        {
            textSplit(tbIndiv.Text.ToString());
        }

        private void textSplit()
        {
            if (rbMitKomma.Checked == true)
            {
                snText = richTextBox1.Text;
                snText = Regex.Replace(snText, @"\s+|\(|\)", "");
                snArray = snText.Split(',');
                lbxVorschau.Items.Clear();
                lbxVorschau.Items.AddRange(snArray);
            }
            if (rbOhneKomma.Checked == true)
            {
                snText = richTextBox1.Text;
                snText = Regex.Replace(snText, @"\(|\)", "");
                snText = Regex.Replace(snText, @"\s+", " ");
                snArray = snText.Split(' ');
                lbxVorschau.Items.Clear();
                lbxVorschau.Items.AddRange(snArray);
            }
            //nichtmehr gebraucht
            //if (rbMitSn.Checked == true)
            //{
            //    snText = richTextBox1.Text;
            //    snText = Regex.Replace(snText, @"SN:", "");
            //    snText = Regex.Replace(snText, @"\s+|\(|\)", "");
            //    snArray = snText.Split(',');
            //    lbxVorschau.Items.Clear();
            //    lbxVorschau.Items.AddRange(snArray);
            //}
            lbAnzahl.Text = lbxVorschau.Items.Count.ToString();
        }

        //teilt den Text 
        private void textSplit(string splitText)
        {
            if (rbIndiv.Checked == true)
            {
                snText = richTextBox1.Text;
                //snText = Regex.Replace(snText, @"\n", " ");
                snText = Regex.Replace(snText, @"\s+", " ");
                splitText = Regex.Replace(splitText, @"\s+", " ");
                snText = Regex.Replace(snText, splitText, "§");
                snArray = snText.Split('§');
                lbxVorschau.Items.Clear();
                lbxVorschau.Items.AddRange(snArray);
            }
            lbAnzahl.Text = lbxVorschau.Items.Count.ToString();
        }

        public int SimulateKeyInput(string[] snArray)
        {
            if (snArray != null)
            {
                for (int i = 0; i < snArray.Length; i++)
                {
                    SendKeys.Send(snArray[i]);
                    Thread.Sleep(100);

                    //---nicht funktionierende Methoden:
                    //SendKeys.Send("{ENTER}");  //Fehlerhafte ausgabe von "M"
                    //SendKeys.Send("\n");       //wird nur als Zeilenumbruch gewertet
                    //SendKeys.Send("{TAB}");    //Fehlerhafte Ausgabe von "I" oder "l" (nicht ersichtlich)
                    //SendKeys.Send("%b");       // ALT+b funktioniert nur wenn man vorher in das Textfeld rechts daneben wechselt. (Tab geht ja aber nicht)
                    
                    //nutze hardware scan codes für Enter Taste, anstatt virteller ScanCode
                    InputSender.ClickKey(0x1c);
                    Thread.Sleep(500);
                }
            }
            this.Activate(); //Fokus auf Fenster setzen wenn fertig
            MessageBox.Show($"Fertig. \n{lbxVorschau.Items.Count.ToString()} SN eingefügt. \nBitte überprüfen Sie die Eingabe!");
            return 0;
        }
    }
}
