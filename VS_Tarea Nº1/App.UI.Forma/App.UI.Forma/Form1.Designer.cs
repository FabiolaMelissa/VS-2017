namespace App.UI.Forma
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtParmx = new System.Windows.Forms.TextBox();
            this.txtParmy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.rbtCuadrado = new System.Windows.Forms.RadioButton();
            this.rbtTriangulo = new System.Windows.Forms.RadioButton();
            this.rbtCirculo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(190, 119);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtParmx
            // 
            this.txtParmx.Location = new System.Drawing.Point(62, 106);
            this.txtParmx.Name = "txtParmx";
            this.txtParmx.Size = new System.Drawing.Size(100, 20);
            this.txtParmx.TabIndex = 1;
            // 
            // txtParmy
            // 
            this.txtParmy.Location = new System.Drawing.Point(62, 140);
            this.txtParmy.Name = "txtParmy";
            this.txtParmy.Size = new System.Drawing.Size(100, 20);
            this.txtParmy.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Área: ";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(103, 184);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(0, 13);
            this.lblArea.TabIndex = 6;
            // 
            // rbtCuadrado
            // 
            this.rbtCuadrado.AutoSize = true;
            this.rbtCuadrado.Location = new System.Drawing.Point(81, 13);
            this.rbtCuadrado.Name = "rbtCuadrado";
            this.rbtCuadrado.Size = new System.Drawing.Size(71, 17);
            this.rbtCuadrado.TabIndex = 7;
            this.rbtCuadrado.TabStop = true;
            this.rbtCuadrado.Text = "Cuadrado";
            this.rbtCuadrado.UseVisualStyleBackColor = true;
            // 
            // rbtTriangulo
            // 
            this.rbtTriangulo.AutoSize = true;
            this.rbtTriangulo.Location = new System.Drawing.Point(81, 37);
            this.rbtTriangulo.Name = "rbtTriangulo";
            this.rbtTriangulo.Size = new System.Drawing.Size(69, 17);
            this.rbtTriangulo.TabIndex = 8;
            this.rbtTriangulo.TabStop = true;
            this.rbtTriangulo.Text = "Triángulo";
            this.rbtTriangulo.UseVisualStyleBackColor = true;
            // 
            // rbtCirculo
            // 
            this.rbtCirculo.AutoSize = true;
            this.rbtCirculo.Location = new System.Drawing.Point(81, 61);
            this.rbtCirculo.Name = "rbtCirculo";
            this.rbtCirculo.Size = new System.Drawing.Size(57, 17);
            this.rbtCirculo.TabIndex = 9;
            this.rbtCirculo.TabStop = true;
            this.rbtCirculo.Text = "Cìrculo";
            this.rbtCirculo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtCirculo);
            this.Controls.Add(this.rbtTriangulo);
            this.Controls.Add(this.rbtCuadrado);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtParmy);
            this.Controls.Add(this.txtParmx);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtParmx;
        private System.Windows.Forms.TextBox txtParmy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.RadioButton rbtCuadrado;
        private System.Windows.Forms.RadioButton rbtTriangulo;
        private System.Windows.Forms.RadioButton rbtCirculo;
    }
}

