﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            String usr = txtusuario.Text;
            String psw = txtcontraseña.Text;

            if (usr=="administrador" & psw == "administrador")
            {
                Panel fb = new Panel();
                if (fb.ShowDialog() ==DialogResult.OK)
                {   

                }


            }else
            {
                MessageBox.Show("Ingrese un usuario correcto");
            }
        }

        private void lblcontraseña_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            // se va hacer el flujo de la pregunta (3 preguntas y se selecciona cual deseas contestas)
        }

       
    }
}
