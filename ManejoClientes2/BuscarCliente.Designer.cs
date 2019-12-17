namespace ManejoClientes2
{
    partial class BuscarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblBuscarCli = new System.Windows.Forms.DataGridView();
            this.ORDEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHANAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTCIVIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblBuscarCli)).BeginInit();
            this.SuspendLayout();
            // 
            // tblBuscarCli
            // 
            this.tblBuscarCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblBuscarCli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ORDEN,
            this.RUT,
            this.NOMBRE,
            this.APELLIDO,
            this.FECHANAC,
            this.SEXO,
            this.ESTCIVIL});
            this.tblBuscarCli.Location = new System.Drawing.Point(11, 90);
            this.tblBuscarCli.Name = "tblBuscarCli";
            this.tblBuscarCli.Size = new System.Drawing.Size(705, 414);
            this.tblBuscarCli.TabIndex = 0;
            this.tblBuscarCli.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblBuscarCli_CellClick);
            // 
            // ORDEN
            // 
            this.ORDEN.HeaderText = "ORDEN";
            this.ORDEN.Name = "ORDEN";
            // 
            // RUT
            // 
            this.RUT.HeaderText = "RUT";
            this.RUT.Name = "RUT";
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            // 
            // APELLIDO
            // 
            this.APELLIDO.HeaderText = "APELLIDO";
            this.APELLIDO.Name = "APELLIDO";
            // 
            // FECHANAC
            // 
            this.FECHANAC.HeaderText = "FECHA NACIMIENTO";
            this.FECHANAC.Name = "FECHANAC";
            // 
            // SEXO
            // 
            this.SEXO.HeaderText = "SEXO";
            this.SEXO.Name = "SEXO";
            // 
            // ESTCIVIL
            // 
            this.ESTCIVIL.HeaderText = "EST CIVIL";
            this.ESTCIVIL.Name = "ESTCIVIL";
            // 
            // BuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 516);
            this.Controls.Add(this.tblBuscarCli);
            this.Name = "BuscarCliente";
            this.Text = "BuscarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.tblBuscarCli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tblBuscarCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHANAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEXO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTCIVIL;
    }
}