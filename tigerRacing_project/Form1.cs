using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tigerRacing_project
{
    public partial class Form1 : Form
    {
        String Name = "";
        int Chetah = 0;
        int winner = 0;
        int Jugraj = 200, Simon = 200, Harmen = 200;

        Better better = new Better();

        public Form1()
        {
            InitializeComponent();
        }
        // lock button coding
        private void btnLock_Click(object sender, EventArgs e)
        {
            if (Name.Equals("Jugraj") && Chetah > 0 && !Amount.Text.Equals("") && Convert.ToInt32(Amount.SelectedItem.ToString()) < Jugraj)
            {
                Better1.Text = "Jugraj selected " + Chetah + " with Amount $ " + Amount.SelectedItem.ToString();
                Chetah = 0;
                Name = "";
                btnRun.Enabled = true;
            }
            else if (Name.Equals("Simon") && Chetah > 0 && !Amount.Text.Equals("") && Convert.ToInt32(Amount.SelectedItem.ToString()) < Simon)
            {
                Better2.Text = "Simon selected " + Chetah + " with Amount $ " + Amount.SelectedItem.ToString();
                Chetah = 0;
                Name = "";
                btnRun.Enabled = true;
            }
            else if (Name.Equals("Harmen") && Chetah > 0 && !Amount.Text.Equals("") && Convert.ToInt32(Amount.SelectedItem.ToString()) < Harmen)
            {
                Better3.Text = "Harmen selected " + Chetah + " with Amount $ " + Amount.SelectedItem.ToString();
                Chetah = 0;
                Name = "";
                btnRun.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please Follow the Instruction to Play the Game ");
            }


        }
        // bettor  1 event giving to varaible 

        private void Betr1_CheckedChanged(object sender, EventArgs e)
        {
            if (Betr1.Checked == true)
            {
                Name = "Jugraj";
            }
        }
        // bettor  2 event giving to varaible

        private void Betr2_CheckedChanged(object sender, EventArgs e)
        {
            if (Betr2.Checked == true)
            {
                Name = "Simon";
            }
        }
        // bettor  3 event giving to varaible

        private void Chetah3_CheckedChanged(object sender, EventArgs e)
        {
            if (Chetah3.Checked == true)
            {
                Chetah = 3;
            }
        }

        // chetah  2 event giving to varaible

        private void Chetah2_CheckedChanged(object sender, EventArgs e)
        {
            if (Chetah2.Checked == true)
            {
                Chetah = 2;
            }
        }

        private void Chetah4_CheckedChanged(object sender, EventArgs e)
        {
            if (Chetah4.Checked == true)
            {
                Chetah = 4;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            pbChetah1.Left += better.moveChetah();
            pbChetah2.Left += better.moveChetah();
            pbChetah3.Left += better.moveChetah();
            pbChetah4.Left += better.moveChetah();

            if (pbChetah1.Left > better.lastPoint())
            {
                timer1.Enabled = false;

                winner = 1;
                FinalDec();
            }
            if (pbChetah2.Left > better.lastPoint())
            {
                timer1.Enabled = false;

                winner = 2;
                FinalDec();
            }
            if (pbChetah3.Left > better.lastPoint())
            {
                timer1.Enabled = false;

                winner = 3;
                FinalDec();
            }
            if (pbChetah4.Left > better.lastPoint())
            {
                timer1.Enabled = false;
                winner = 4;
                FinalDec();
            }

        }



        private void Betr3_CheckedChanged(object sender, EventArgs e)
        {
            if (Betr3.Checked == true)
            {
                Name = "Harmen";
            }
        }

        // running game 

        private void btnRun_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //gererate the Amount in the Drop down menu to select by the plaer for bet
            int x = 0;
            for (x = 1; x <= 50; x++)
            {
                //add the value in the drop down menu 
                Amount.Items.Add(x.ToString());
            }
            btnRun.Enabled = false;
        }

        private void Chetah1_CheckedChanged(object sender, EventArgs e)
        {
            if (Chetah1.Checked == true)
            {
                Chetah = 1;
            }
        }

        // function declation 

        public void FinalDec()
        {
            MessageBox.Show("Chetah " + winner + " Won the Race ");
            if (Better1.Text.Contains('$'))
            {
                Jugraj = better.winner(Better1.Text, winner, Jugraj);
            }
            if (Better2.Text.Contains('$'))
            {
                Simon = better.winner(Better2.Text, winner, Simon);
            }
            if (Better3.Text.Contains('$'))
            {
                Harmen = better.winner(Better3.Text, winner, Harmen);
            }

            MessageBox.Show("Jugraj has $" + Jugraj);
            MessageBox.Show("Simon has $" + Simon);
            MessageBox.Show("Harmen has $" + Harmen);
            Name = "";
            Chetah = 0;
            Amount.Text = "";
            pbChetah1.Left = 0;
            pbChetah2.Left = 0;
            pbChetah3.Left = 0;
            pbChetah4.Left = 0;
            Better1.Text = "Jugraj";
            Better2.Text = "Simon";
            Better3.Text = "Harmen";
        }


    }
}
