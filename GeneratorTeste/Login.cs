using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GeneratorTeste
{
    public partial class Login : Form
    {
        public static string passingstring3;
        public Login()
        {
            InitializeComponent();
            passingstring3 = username.Text;
        }

        private void Btn_signin_Click(object sender, EventArgs e)
        {

            this.Hide();
            SingIn f = new SingIn();
            f.ShowDialog();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void Username_TextChanged(object sender, EventArgs e)
        {

        }



        private void Button2_Click(object sender, EventArgs e)
        {
            using (testeEntities teste = new testeEntities())
            {
                bool verification = teste.t_Users.Any(x => x.username == username.Text.Trim());
                bool verifacation2 = teste.t_Passwords.Any(x => x.Pass == password.Text.Trim());

                if (verification == true && verifacation2== true)
                { 
                    this.Hide();
                    TestPicker t = new TestPicker();
                    t.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username sau parola gresita");
                }
            }
        }
    }
}
