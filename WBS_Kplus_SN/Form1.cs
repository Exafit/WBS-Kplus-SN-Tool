using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WBS_Kplus_SN
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        //Listengenerator listengenerator = new Listengenerator();
        int countdown = 5;
        string snText;
        //List<string> snListe = new List<string>();
        string[] snArray;

        public Form1()
        {
            InitializeComponent();
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
                //listengenerator.TextZuListe(snArray);
                SimulateKeyInput(snArray);

            }
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            textSplit();
        }

        private void rbMitKomma_CheckedChanged(object sender, EventArgs e)
        {
            textSplit();
        }

        private void rbOhneKomma_CheckedChanged(object sender, EventArgs e)
        {

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
        }

        public int SimulateKeyInput(string[] snArray)
        {
            for (int i = 0; i < snArray.Length ; i++)
            {
                SendKeys.Send(snArray[i]);
                //SendKeys.Send("{ENTER}");  //Fehlerhafte ausgabe von "M"
                //SendKeys.Send("{TAB}");    //Fehlerhafte Ausgabe von "I" oder "l" (nicht ersichtlich)
                //SendKeys.Send("%b");       // ALT+b funktioniert nur wenn man vorher in das Textfeld rechts daneben wechselt. (Tab geht ja aber nicht)
                //evt SendKeys.SendWait??
                //SendKeys.Send("\n");
                Thread.Sleep(100);
                InputSender.ClickKey(0x1c);
                Thread.Sleep(500);
            }

            return 0;
        }
    }
}
