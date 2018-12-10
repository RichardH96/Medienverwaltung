using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wifi.Media.Login
{
    public partial class FormLogin : Form
    {
        bool registermode = false;



        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            registermode = true;
            changeToRegister();

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (registermode)
            {

            }
            else
            {

            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (registermode)
            {
                registermode = false;
                changeToRegister();
            }
            else
            {
                this.Close();
            }
        }



        private void changeToRegister()
        {
            if (registermode)
            {
                this.textBoxPassword.Text = string.Empty;
                this.textBoxPasswordRepeat.Text = string.Empty;
                this.textBoxUsername.Text = string.Empty;

                this.textBoxPassword.UseSystemPasswordChar = false;

                this.labelPasswordRepeat.Visible = true;
                this.textBoxPasswordRepeat.Visible = true;
                this.labelLogin.Text = "REGISTRIEREN";
                this.Text = "Medienverwaltung - Registieren";

                this.buttonRegister.Visible = false;

                this.buttonLogin.Text = "Bestätigen";
                //this.buttonLogin.Top = 212;

                //this.buttonCancel.Top = 212;
            }
            else if (!registermode)
            {
                this.textBoxPassword.Text = string.Empty;
                this.textBoxPasswordRepeat.Text = string.Empty;
                this.textBoxUsername.Text = string.Empty;

                this.textBoxPassword.UseSystemPasswordChar = true;

                this.labelPasswordRepeat.Visible = false;
                this.textBoxPasswordRepeat.Visible = false;
                this.labelLogin.Text = "LOGIN";
                this.Text = "Medienverwaltung - Login";

                this.buttonRegister.Visible = true;

                this.buttonLogin.Text = "Einloggen";
                //this.buttonLogin.Top = 176;

                //this.buttonCancel.Top = 176;
            }

        }

    }
}
