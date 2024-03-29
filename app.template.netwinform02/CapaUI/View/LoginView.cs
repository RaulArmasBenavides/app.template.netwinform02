﻿using CapaNegocio.Controller;
using System;
using System.Windows.Forms;

namespace CapaUI.View
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }
        EmpleadoBLL obj = new EmpleadoBLL();

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (obj.EmpleadoValidar(txtUsuario.Text,txtClave.Text))
            {
                this.Hide();
                MDImenu f = new MDImenu();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Password es Incorrecto", "error");
                txtUsuario.Clear();
                txtClave.Clear();
                txtUsuario.Focus();
            }
        }
    }
}
