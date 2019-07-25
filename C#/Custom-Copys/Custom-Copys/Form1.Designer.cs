namespace Custom_Copys
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Direccion = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ButtonNuevo = new System.Windows.Forms.Button();
            this.ButtonInsertar = new System.Windows.Forms.Button();
            this.ButtonActualizar = new System.Windows.Forms.Button();
            this.ButtonEliminar = new System.Windows.Forms.Button();
            this.ButtonBuscar = new System.Windows.Forms.Button();
            this.LabelID = new System.Windows.Forms.Label();
            this.LabelApellido = new System.Windows.Forms.Label();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.LabelDireccion = new System.Windows.Forms.Label();
            this.LabelTelefono = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Direccion
            // 
            this.Direccion.Enabled = false;
            this.Direccion.Location = new System.Drawing.Point(328, 123);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(100, 20);
            this.Direccion.TabIndex = 0;
            // 
            // Apellido
            // 
            this.Apellido.Enabled = false;
            this.Apellido.Location = new System.Drawing.Point(328, 97);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(100, 20);
            this.Apellido.TabIndex = 1;
            // 
            // Telefono
            // 
            this.Telefono.Enabled = false;
            this.Telefono.Location = new System.Drawing.Point(328, 149);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(100, 20);
            this.Telefono.TabIndex = 2;
            // 
            // Nombre
            // 
            this.Nombre.Enabled = false;
            this.Nombre.Location = new System.Drawing.Point(328, 71);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 20);
            this.Nombre.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.Enabled = false;
            this.Id.Location = new System.Drawing.Point(328, 45);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(100, 20);
            this.Id.TabIndex = 4;
            this.Id.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 313);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ButtonNuevo
            // 
            this.ButtonNuevo.Location = new System.Drawing.Point(278, 186);
            this.ButtonNuevo.Name = "ButtonNuevo";
            this.ButtonNuevo.Size = new System.Drawing.Size(150, 23);
            this.ButtonNuevo.TabIndex = 6;
            this.ButtonNuevo.Text = "Nuevo";
            this.ButtonNuevo.UseVisualStyleBackColor = true;
            this.ButtonNuevo.Click += new System.EventHandler(this.ButtonNuevo_Click);
            // 
            // ButtonInsertar
            // 
            this.ButtonInsertar.Location = new System.Drawing.Point(278, 273);
            this.ButtonInsertar.Name = "ButtonInsertar";
            this.ButtonInsertar.Size = new System.Drawing.Size(150, 23);
            this.ButtonInsertar.TabIndex = 7;
            this.ButtonInsertar.Text = "Insertar";
            this.ButtonInsertar.UseVisualStyleBackColor = true;
            this.ButtonInsertar.Click += new System.EventHandler(this.ButtonInsertar_Click);
            // 
            // ButtonActualizar
            // 
            this.ButtonActualizar.Location = new System.Drawing.Point(278, 302);
            this.ButtonActualizar.Name = "ButtonActualizar";
            this.ButtonActualizar.Size = new System.Drawing.Size(150, 23);
            this.ButtonActualizar.TabIndex = 8;
            this.ButtonActualizar.Text = "Actualizar";
            this.ButtonActualizar.UseVisualStyleBackColor = true;
            // 
            // ButtonEliminar
            // 
            this.ButtonEliminar.Location = new System.Drawing.Point(278, 244);
            this.ButtonEliminar.Name = "ButtonEliminar";
            this.ButtonEliminar.Size = new System.Drawing.Size(150, 23);
            this.ButtonEliminar.TabIndex = 9;
            this.ButtonEliminar.Text = "Eliminar";
            this.ButtonEliminar.UseVisualStyleBackColor = true;
            // 
            // ButtonBuscar
            // 
            this.ButtonBuscar.Location = new System.Drawing.Point(278, 215);
            this.ButtonBuscar.Name = "ButtonBuscar";
            this.ButtonBuscar.Size = new System.Drawing.Size(150, 23);
            this.ButtonBuscar.TabIndex = 10;
            this.ButtonBuscar.Text = "Buscar";
            this.ButtonBuscar.UseVisualStyleBackColor = true;
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Location = new System.Drawing.Point(299, 48);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(18, 13);
            this.LabelID.TabIndex = 11;
            this.LabelID.Text = "ID";
            this.LabelID.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LabelApellido
            // 
            this.LabelApellido.AutoSize = true;
            this.LabelApellido.Location = new System.Drawing.Point(263, 100);
            this.LabelApellido.Name = "LabelApellido";
            this.LabelApellido.Size = new System.Drawing.Size(59, 13);
            this.LabelApellido.TabIndex = 12;
            this.LabelApellido.Text = "APELLIDO";
            this.LabelApellido.Click += new System.EventHandler(this.LabelApellido_Click);
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Location = new System.Drawing.Point(268, 74);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(54, 13);
            this.LabelNombre.TabIndex = 13;
            this.LabelNombre.Text = "NOMBRE";
            // 
            // LabelDireccion
            // 
            this.LabelDireccion.AutoSize = true;
            this.LabelDireccion.Location = new System.Drawing.Point(256, 126);
            this.LabelDireccion.Name = "LabelDireccion";
            this.LabelDireccion.Size = new System.Drawing.Size(66, 13);
            this.LabelDireccion.TabIndex = 14;
            this.LabelDireccion.Text = "DIRECCION";
            // 
            // LabelTelefono
            // 
            this.LabelTelefono.AutoSize = true;
            this.LabelTelefono.Location = new System.Drawing.Point(258, 152);
            this.LabelTelefono.Name = "LabelTelefono";
            this.LabelTelefono.Size = new System.Drawing.Size(64, 13);
            this.LabelTelefono.TabIndex = 15;
            this.LabelTelefono.Text = "TELEFONO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 339);
            this.Controls.Add(this.LabelTelefono);
            this.Controls.Add(this.LabelDireccion);
            this.Controls.Add(this.LabelNombre);
            this.Controls.Add(this.LabelApellido);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.ButtonBuscar);
            this.Controls.Add(this.ButtonEliminar);
            this.Controls.Add(this.ButtonActualizar);
            this.Controls.Add(this.ButtonInsertar);
            this.Controls.Add(this.ButtonNuevo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.Direccion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ButtonNuevo;
        private System.Windows.Forms.Button ButtonInsertar;
        private System.Windows.Forms.Button ButtonActualizar;
        private System.Windows.Forms.Button ButtonEliminar;
        private System.Windows.Forms.Button ButtonBuscar;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Label LabelApellido;
        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.Label LabelDireccion;
        private System.Windows.Forms.Label LabelTelefono;
    }
}

