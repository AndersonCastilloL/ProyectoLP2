﻿using LogicaNegocio;
using ProyectoLP2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{

    public partial class GestionClientes : Form
    {
        ClienteBL clienteBL;
        Cliente cliente;
        public GestionClientes()
        {
            InitializeComponent();
            cargarClientes();
            
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            AgregarCliente aclientes = new AgregarCliente();

            aclientes.FormClosed += new System.Windows.Forms.FormClosedEventHandler(AgregarCliente_FormClosed);
            if (aclientes.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void AgregarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {

            cargarClientes();

        }

        private void cargarClientes()
        {
            clienteBL = new ClienteBL();
            BindingList<Cliente> clientes = new BindingList<Cliente>();
            clientes = clienteBL.listarCliente();
            //dgvClientes.AutoGenerateColumns = false;
            dgvClientes.DataSource = clientes;
           
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }

        private void btnModCliente_Click(object sender, EventArgs e)
        {
            ModificarCliente aclientes = new ModificarCliente();
            if (aclientes.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnElimCliente_Click(object sender, EventArgs e)
        {
            confirmarElimCliente eclientes = new confirmarElimCliente();
            if (eclientes.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
