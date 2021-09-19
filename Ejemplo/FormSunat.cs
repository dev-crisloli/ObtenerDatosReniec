using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo
{
    public partial class FormSunat : Form
    {
        public FormSunat()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            datosReniec.getReniec getReniec = new datosReniec.getReniec();
            getReniec.Dni = txt_buscarDNI.Text;
            getReniec.obtenerDatosReniec();
            txt_primerApellido.Text = getReniec.PrimerApellido;
            txt_segundoApellido.Text = getReniec.SegundoApellido;
            txt_nombres.Text = getReniec.Nombres;
            txt_codigoVerificador.Text = getReniec.CodigoVerificador;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
