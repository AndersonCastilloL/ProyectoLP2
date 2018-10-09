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
    public partial class ModificarUsuario : Form
    {
        public ModificarUsuario()
        {
            InitializeComponent();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El usuario se modifico satisfactoriamente");
            this.Dispose();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            txtcomision.Enabled = true;
            txtemail.Enabled = true;
            txtrazon.Enabled = true;
            txtruc.Enabled = true;
            txtsalario.Enabled = true;
            txttelf.Enabled = true;
            txtdni.Enabled = true;
            cmbrol.Enabled = true;
            datetimeFecha.Enabled = true;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
