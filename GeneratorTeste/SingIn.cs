using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace GeneratorTeste
{
    public partial class SingIn : Form
    {
        public SingIn()
        {
            InitializeComponent();
        }

        private void Signin_Click(object sender, EventArgs e)
        {
            using (testeEntities teste= new testeEntities()){
                var pass = new t_Passwords
                {
                    Pass = passwordSignin.Text.Trim()
                };
                var newusers = new t_Users
                {
                    username = usernameSignin.Text.Trim()
                    
                };
                teste.t_Passwords.Add(pass);
                teste.t_Users.Add(newusers);
               
                teste.SaveChanges();

            }
            
            this.Hide();
            Login f = new Login();
            f.ShowDialog();
            this.Close();
        }
    }
}
