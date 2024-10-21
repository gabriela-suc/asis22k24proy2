﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Produccion
{
    public partial class Frm_Receta : Form
    {
        public Frm_Receta()
        {
            InitializeComponent();
            string[] alias = { "ID", "Producto","Descripción", "Cantidad", "Costo", "Campo", "Tipo", "Estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            Color colorFondo = ColorTranslator.FromHtml("#AEA1D6"); // Color de fondo
            Color colorFuente = ColorTranslator.FromHtml("#230050"); // Color de fuente
            navegador1.AsignarColorFondo(colorFondo);
            navegador1.AsignarColorFuente(colorFuente);
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario("admin");
            navegador1.AsignarTabla("tbl_recetas");
            navegador1.AsignarNombreForm("Recetas");
            //List<string> tablas = new List<string> { "detallefactura", "pagos" };
            //navegador1.AsignarTablas(tablas);




        }
    }
}