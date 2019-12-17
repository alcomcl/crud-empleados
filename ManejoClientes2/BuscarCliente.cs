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
    public partial class BuscarCliente : Form

    {
        public String cod,rut, nombre, apellido, fechaNac, sexo, estCivil;
        
        
        public BuscarCliente()
        {
            InitializeComponent();
            cargarTabla();

        }

        void cargarTabla()
        {
            tblBuscarCli.Rows.Add("0001", "10663741-4", "Alex", "Cofre", "15/11/1987","H", "Soltero");
            tblBuscarCli.Rows.Add("0002", "16512349-4", "Carlos", "Cofre", "15/11/1987", "H", "Soltero");
            tblBuscarCli.Rows.Add("0003", "17641781-4", "Marcos", "Cofre", "15/11/1987", "H", "Soltero");
        }

        private void tblBuscarCli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = tblBuscarCli.CurrentRow.Index;
            try
            {
                cod = tblBuscarCli[0, fila].Value.ToString();
                rut = tblBuscarCli[1, fila].Value.ToString();
                nombre = tblBuscarCli[2, fila].Value.ToString();
                apellido = tblBuscarCli[3, fila].Value.ToString();
                fechaNac = tblBuscarCli[4, fila].Value.ToString(); ;
                sexo = tblBuscarCli[5, fila].Value.ToString();
                estCivil = tblBuscarCli[6, fila].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Ola", "Chao", MessageBoxButtons.OK);
            }


            this.Visible = false; 


        }
    }
}
