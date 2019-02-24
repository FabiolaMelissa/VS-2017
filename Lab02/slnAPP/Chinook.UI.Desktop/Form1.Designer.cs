namespace Chinook.UI.Desktop
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.dcCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFiltroPorNombre = new System.Windows.Forms.TextBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(341, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dcCodigo,
            this.dcNombre});
            this.dgvListado.Location = new System.Drawing.Point(4, 31);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(1021, 618);
            this.dgvListado.TabIndex = 1;
            // 
            // dcCodigo
            // 
            this.dcCodigo.DataPropertyName = "Artistid";
            this.dcCodigo.HeaderText = "Código";
            this.dcCodigo.Name = "dcCodigo";
            // 
            // dcNombre
            // 
            this.dcNombre.DataPropertyName = "Name";
            this.dcNombre.HeaderText = "Nombre";
            this.dcNombre.Name = "dcNombre";
            // 
            // txtFiltroPorNombre
            // 
            this.txtFiltroPorNombre.Location = new System.Drawing.Point(4, 6);
            this.txtFiltroPorNombre.Name = "txtFiltroPorNombre";
            this.txtFiltroPorNombre.Size = new System.Drawing.Size(238, 20);
            this.txtFiltroPorNombre.TabIndex = 2;
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(248, 4);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnFiltro.TabIndex = 3;
            this.btnFiltro.Text = "Filtro";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 649);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.txtFiltroPorNombre);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.btnConsultar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcNombre;
        private System.Windows.Forms.TextBox txtFiltroPorNombre;
        private System.Windows.Forms.Button btnFiltro;
    }
}

