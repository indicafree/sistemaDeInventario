namespace prytp2_LP2
{
    partial class frmConsultadearticulos
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
            this.dgvArtuculos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDeStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTotalenStock = new System.Windows.Forms.Label();
            this.lblRubro = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblExportar = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.cmbRubros = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtuculos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArtuculos
            // 
            this.dgvArtuculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtuculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripcion,
            this.costo,
            this.stock,
            this.valorDeStock});
            this.dgvArtuculos.Location = new System.Drawing.Point(34, 64);
            this.dgvArtuculos.Name = "dgvArtuculos";
            this.dgvArtuculos.Size = new System.Drawing.Size(656, 178);
            this.dgvArtuculos.TabIndex = 1;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            // 
            // costo
            // 
            this.costo.HeaderText = "Costo";
            this.costo.Name = "costo";
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            // 
            // valorDeStock
            // 
            this.valorDeStock.HeaderText = "Valor en Stock";
            this.valorDeStock.Name = "valorDeStock";
            // 
            // lblCantidad
            // 
            this.lblCantidad.Location = new System.Drawing.Point(40, 257);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(161, 39);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad de articulos: ";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalenStock
            // 
            this.lblTotalenStock.Location = new System.Drawing.Point(408, 265);
            this.lblTotalenStock.Name = "lblTotalenStock";
            this.lblTotalenStock.Size = new System.Drawing.Size(100, 23);
            this.lblTotalenStock.TabIndex = 3;
            this.lblTotalenStock.Text = "Total en Stock";
            this.lblTotalenStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRubro
            // 
            this.lblRubro.Location = new System.Drawing.Point(31, 20);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(108, 31);
            this.lblRubro.TabIndex = 4;
            this.lblRubro.Text = "Rubro : ";
            this.lblRubro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(439, 24);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(137, 23);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblExportar
            // 
            this.lblExportar.Location = new System.Drawing.Point(53, 325);
            this.lblExportar.Name = "lblExportar";
            this.lblExportar.Size = new System.Drawing.Size(137, 23);
            this.lblExportar.TabIndex = 6;
            this.lblExportar.Text = "Exportar";
            this.lblExportar.UseVisualStyleBackColor = true;
            this.lblExportar.Click += new System.EventHandler(this.lblExportar_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(408, 325);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(100, 23);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.Text = "Info";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbRubros
            // 
            this.cmbRubros.FormattingEnabled = true;
            this.cmbRubros.Location = new System.Drawing.Point(111, 25);
            this.cmbRubros.Name = "cmbRubros";
            this.cmbRubros.Size = new System.Drawing.Size(121, 21);
            this.cmbRubros.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(735, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(474, 330);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmConsultadearticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmbRubros);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblExportar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblRubro);
            this.Controls.Add(this.lblTotalenStock);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.dgvArtuculos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultadearticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Articulos";
            this.Load += new System.EventHandler(this.frmConsultadearticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtuculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvArtuculos;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTotalenStock;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button lblExportar;
        private System.Windows.Forms.ComboBox cmbRubros;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDeStock;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

