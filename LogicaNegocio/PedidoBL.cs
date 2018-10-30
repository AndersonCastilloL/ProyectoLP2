﻿using AccesoDatos;
using ProyectoLP2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class PedidoBL
    {
        public PedidoBL()
        {

        }

        public void agregarPedido(Pedido pedidoAgregar)
        {
            PedidoDA pedido = new PedidoDA();
            int idPedido = pedido.agregar(pedidoAgregar); // agregarCabecera
            foreach (DetallePedido det in pedidoAgregar.DetallesPedido)
            {
                pedido.AgregarDetalle(idPedido, det);
            }
        }
        public BindingList<Pedido> listarPedidos()
        {
            PedidoDA p = new PedidoDA();
            return p.listarPedidos();
        }

        public void eliminarPedido(int idPedido)
        {
            PedidoDA p = new PedidoDA();
            // se libera los productos
            p.eliminar(idPedido);
        }

        public BindingList<DetallePedido> listarDetalle(int id)
        {
            PedidoDA p = new PedidoDA();
            return p.listarDetallePedido(id);
        }

    }
}
