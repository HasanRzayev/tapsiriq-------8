using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tapsiriq_______8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<PlayerUC> players = new List<PlayerUC>();
        string[] numbers = new string[11];
  
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form_football sahe = new Form_football();
        
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ////////////////////////////
            int a=1;
            var list = CultureInfo.GetCultures(CultureTypes.SpecificCultures).
              Select(p => new RegionInfo(p.Name).EnglishName).
              Distinct().OrderBy(s => s).ToList();
            comboBox_country.DataSource = list;
            ///////////////////////////////////////

            comboBox_position.Items.Add("4–3–3");
            comboBox_position.Items.Add("4–4–2");

            comboBox_position.Items.Add("5–3–2");
            comboBox_position.Items.Add("3–4–3");
            //////////////////////////////////////////////
            PlayerUC b = new PlayerUC (players);
            players.Add(playerUC1 );
            players.Add(playerUC2 );
            players.Add(playerUC3 );
            players.Add(playerUC4 );
            players.Add(playerUC5 );
            players.Add(playerUC6 );
            players.Add(playerUC7 );
            players.Add(playerUC8 );
            players.Add(playerUC9 );
            players.Add(playerUC10);
            players.Add(playerUC11);
            //////////////////////////////////////////////
            playerUC1.playerss=players;
            playerUC2.playerss=players;
            playerUC3.playerss=players;
            playerUC4.playerss=players;
            playerUC5.playerss=players;
            playerUC6.playerss=players;
            playerUC7.playerss=players;
            playerUC8.playerss=players;
            playerUC9.playerss=players;
            playerUC10.playerss=players;
            playerUC11.playerss = players;
            //////////////////////////////////////////////
            playerUC1.numberss = numbers;
            playerUC2.numberss = numbers;
            playerUC3.numberss = numbers;
            playerUC4.numberss = numbers;
            playerUC5.numberss = numbers;
            playerUC6.numberss = numbers;
            playerUC7.numberss = numbers;
            playerUC8.numberss = numbers;
            playerUC9.numberss = numbers;
            playerUC10.numberss = numbers;
            playerUC11.numberss = numbers;
            //////////////////////////////////////////////
            playerUC1 .label1.Text=(a++).ToString();
            playerUC2 .label1.Text=(a++).ToString();
            playerUC3 .label1.Text=(a++).ToString();
            playerUC4 .label1.Text=(a++).ToString();
            playerUC5 .label1.Text=(a++).ToString();
            playerUC6 .label1.Text=(a++).ToString();
            playerUC7 .label1.Text=(a++).ToString();
            playerUC8 .label1.Text=(a++).ToString();
            playerUC9 .label1.Text=(a++).ToString();
            playerUC10.label1.Text=(a++).ToString();
            playerUC11.label1.Text = (a++).ToString();




          
                Controls.Add(playerUC1);
                Controls.Add(playerUC2);
                Controls.Add(playerUC3);
                Controls.Add(playerUC4);
                Controls.Add(playerUC5);
                Controls.Add(playerUC6);
                Controls.Add(playerUC7);
                Controls.Add(playerUC8);
                Controls.Add(playerUC9);
                Controls.Add(playerUC10);
                Controls.Add(playerUC11);
  
        }

        private void comboBox_position_SelectedIndexChanged(object sender, EventArgs e)
        {
            string option=comboBox_position.Items[comboBox_position.SelectedIndex].ToString();
            if(comboBox_position.SelectedItem != null)
            {
                for (int i = 0; i <int.Parse(option[4].ToString()); i++)
                {

                    players[i].textBox1.Text = "F";
                }
                for (int i = int.Parse(option[4].ToString()); i < int.Parse(option[4].ToString())+ int.Parse(option[2].ToString()); i++)
                {

                    players[i].textBox1.Text = "MD";
                }
                for (int i = int.Parse(option[4].ToString()) + int.Parse(option[2].ToString()); i < int.Parse(option[4].ToString()) + int.Parse(option[2].ToString())+ int.Parse(option[0].ToString()); i++)
                {

                    players[i].textBox1.Text = "DD";
                }
            }
            players[10].textBox1.Text = "GK";


           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox_position.SelectedItem != null)
            {
                string option = comboBox_position.Items[comboBox_position.SelectedIndex].ToString();
                Form_football sahe = new Form_football(option);
                sahe.pictureBox1.Load($@"https://www.sciencekids.co.nz/images/pictures/flags680/{comboBox_country.SelectedItem}.jpg");
                //sahe.pictureBox1.Load($@"https://ru.m.wikipedia.org/wiki/%D0%A4%D0%B0%D0%B9%D0%BB:Flag_of_{comboBox_country.Text}.svg");
                sahe.BackgroundImageLayout = ImageLayout.Zoom;
                sahe.playerss = players;




                sahe.ShowDialog();

                if (sahe.DialogResult == DialogResult.OK)
                {

                }
            }
           

        }

        private void playerUC1_Validated(object sender, EventArgs e)
        {

            foreach (var item in players)
            {
                if (item.label1.Text == null || item.textBox1.Text == null || item.textBox2.Text == null || item.textBox3.Text == null)
                {
                    button1.Enabled = false;
                    return;
                }
            }
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            foreach (var item in players)
            {
             
              
                item.textBox2.Text =r.Next(10,100).ToString();
                item.textBox3.Text = "hasan";

            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            int count = 0;
            foreach (var item in players)
            {
                if ( string.IsNullOrWhiteSpace( item.textBox1.Text  ) || string.IsNullOrWhiteSpace(item.textBox2.Text) || string.IsNullOrWhiteSpace(item.textBox3.Text) )
                {
                    //button1.Enabled = false;
                    count++;
                }
            }
            if(count==0)button1.Enabled = true;
        }
    }
}
