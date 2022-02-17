using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Logica;


namespace Banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bank banco = new Bank();
        Sucursal miSucursal = new Sucursal();

        private void acceptarbtn_Click(object sender, EventArgs e)
        {
            int idBanco;
            String nombreBanco;
            String fechaCreacion;
            string respuestabanco;

            idBanco = int.Parse(IdBancotxt.Text);
            nombreBanco = NombreBancotxt.Text;
            fechaCreacion = tiempocreacion.Text;

            respuestabanco = banco.agregarBanco(idBanco, nombreBanco, fechaCreacion);

            respuestabancotxt.Text = respuestabanco;
            
        }

        private void bottonSucursal_Click(object sender, EventArgs e)
        {
            int idSucursal;
            int cantEmpleados;
            int antiguedadSucursal;
            int idBancoSucursal;
            string nombreSucursal;
            string ubicacionSucursal;

            string returntxt;

            idSucursal = int.Parse(IdSucursaltxt.Text);
            cantEmpleados = int.Parse(CantEmpleadostxt.Text);
            antiguedadSucursal = int.Parse(Antiguedadtxt.Text);
            idBancoSucursal = int.Parse(IdBancoSucursaltxt.Text);
            nombreSucursal = NombeSucursaltxt.Text;
            ubicacionSucursal = ubicacionSucursalcombo.Text;

            returntxt = miSucursal.agregarSucursal(idSucursal, cantEmpleados, antiguedadSucursal, idBancoSucursal, nombreSucursal, ubicacionSucursal);
            returntxtbox.Text = returntxt;

           
        }

        private void buscartbtn_Click(object sender, EventArgs e)
        {
            string nombreBanco = buscadorNombreBancotxt.Text;
            string ubicacionSuc = ubicacionSuccombo.Text;
            // Creo Data Set
            DataSet miData = new DataSet();
            miData = miSucursal.consultar( nombreBanco, ubicacionSuc);
            datagridSuc.DataSource = miData;
            datagridSuc.DataMember = " Sucursales";
            
                      
            
           
        }
    }
}
