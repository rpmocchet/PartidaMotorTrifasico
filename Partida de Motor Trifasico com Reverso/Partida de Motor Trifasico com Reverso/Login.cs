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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
      

         private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Renan" && textBox2.Text == "12345")
            {
                Form0 newForm0 = new Form0();
                newForm0.Show();
                this.Visible = false;
            }

            else
            {
                MessageBox.Show("Loguin e/ou senha Incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
            }
         }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
