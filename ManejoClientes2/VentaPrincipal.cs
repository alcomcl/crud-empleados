using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoClientes2
{
    public partial class forma : Form
    {
        int orden = 1;
        int posicion;
        public forma()
        {
            InitializeComponent();
            limpiar();
        }

        void limpiar()
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            txtRut.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtFecha.Text = "";
            cboxSexo.Text = "";
            cboxEstCivil.Text = "";


        }

        private void btbAgregar_Click(object sender, EventArgs e)
        {
            string rut, nombre, apellido,fecha, sexo, estCivil;
            

            rut = txtRut.Text;
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            fecha = txtFecha.Text;
            sexo = cboxSexo.Text;
            estCivil = cboxEstCivil.Text;


            tblDatos.Rows.Add(orden + "", rut, nombre, apellido, fecha, sexo, estCivil);
            orden = orden + 1;

            limpiar();

            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;

        }

        private void tblDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = tblDatos.CurrentRow.Index;
            try
            {
                txtRut.Text = tblDatos[1, posicion].Value.ToString();
                txtNombre.Text = tblDatos[2, posicion].Value.ToString();
                txtApellido.Text = tblDatos[3, posicion].Value.ToString();
                txtFecha.Text = tblDatos[4, posicion].Value.ToString();
                cboxSexo.Text = tblDatos[5, posicion].Value.ToString();
                cboxEstCivil.Text = tblDatos[6, posicion].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Error", "Fila vacia", MessageBoxButtons.OK);
            }


            
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            limpiar();
            btnAgregar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string rut, nombre, apellido, sexo, estCivil, fecha;
            

            rut = txtRut.Text;
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            fecha = txtFecha.Text;
            sexo = cboxSexo.Text;
            estCivil = cboxEstCivil.Text;

            tblDatos[1, posicion].Value = txtRut.Text;
            tblDatos[2, posicion].Value = txtNombre.Text;
            tblDatos[3, posicion].Value = txtApellido.Text;
            tblDatos[4, posicion].Value = txtFecha.Text;
            tblDatos[5, posicion].Value = cboxSexo.Text;
            tblDatos[6, posicion].Value = cboxEstCivil.Text;

            limpiar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            tblDatos.Rows.RemoveAt(posicion);
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCliente miCliente = new BuscarCliente();
            miCliente.ShowDialog();

            txtRut.Text = miCliente.rut;
            txtNombre.Text = miCliente.nombre;
            txtApellido.Text = miCliente.apellido;
            txtFecha.Text = miCliente.fechaNac;
            cboxSexo.Text = miCliente.sexo;
            cboxEstCivil.Text = miCliente.estCivil;

            

        }
    }
}
