using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Partida_de_Motor_Trifasico_com_Reverso
{
    public partial class Form1 : Form
    {
        int Data = 0;
        int Add = 888;

        public Form1()
        {
            InitializeComponent();
            textBox3.Text="Motor Desligado!";
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                AppControl.Output(Add, Data);
            }
            catch
            {
                MessageBox.Show("Inpout32.dll não encontrada!", "App Crash");
                System.Environment.Exit(-1);
            }
        }

       private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.BackColor == Color.Red && textBox2.BackColor==Color.Red)
            {
                Data += 1;
                textBox1.BackColor = Color.Green;
                textBox3.Text = "Motor Ligado Sentido Horário!";
                button1.Text = "Desligar";
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
            }
            else if (textBox1.BackColor == Color.Green && textBox2.BackColor == Color.Red)
            {
                Data -= 1;
                textBox1.BackColor = Color.Red;
                textBox3.Text = "Motor Desligado!";
                button1.Text = "Horário";
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }

            else if (textBox2.BackColor == Color.Green && textBox1.BackColor == Color.Red)
            {
                MessageBox.Show("Desligue o Motor primeiro!", "PERIGO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                              
            }

            AppControl.Output(Add, Data);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.BackColor == Color.Red && textBox1.BackColor == Color.Red)
            {
                Data += 2;
                textBox2.BackColor = Color.Green;
                textBox3.Text = "Motor Ligado sentido Anti-horário!";
                button2.Text = "Desligar";
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;

            }
            else if (textBox2.BackColor == Color.Green && textBox1.BackColor == Color.Red)
            {
                Data -= 2;
                textBox2.BackColor = Color.Red;
                textBox3.Text = "Motor Desligado!";
                button2.Text = "Anti-horário";
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }

            else if (textBox1.BackColor == Color.Green && textBox2.BackColor == Color.Red)
            {
                MessageBox.Show("Desligue o Motor Primeiro!", "PERIGO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
            }

            AppControl.Output(Add, Data);

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data = 0;
            textBox1.BackColor = Color.Red;
            textBox2.BackColor = Color.Red;

            DialogResult atencao;
            MessageBoxButtons bot = MessageBoxButtons.OKCancel;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            atencao = MessageBox.Show("Deseja realmente sair?", "ATENÇÃO!", bot, icon);
            switch (atencao)
            {
                case DialogResult.OK:
                    Application.Exit();
                    break;
                case DialogResult.Cancel:
                    break;
            }
                      
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newForm3 = new Form3();
            newForm3.Show();
        }

        private void diagramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm2 = new Form2();
            newForm2.Show();
        }
    }
}
