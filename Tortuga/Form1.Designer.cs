namespace Tortuga
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
            this.btnGirarIzquierda = new System.Windows.Forms.Button();
            this.txtTablero = new System.Windows.Forms.TextBox();
            this.btnGirarDerecha = new System.Windows.Forms.Button();
            this.btnPlumaAbajo = new System.Windows.Forms.Button();
            this.btnPlumaArriba = new System.Windows.Forms.Button();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGirarIzquierda
            // 
            this.btnGirarIzquierda.Location = new System.Drawing.Point(240, 25);
            this.btnGirarIzquierda.Name = "btnGirarIzquierda";
            this.btnGirarIzquierda.Size = new System.Drawing.Size(90, 23);
            this.btnGirarIzquierda.TabIndex = 0;
            this.btnGirarIzquierda.Text = "Girar Izquierda";
            this.btnGirarIzquierda.UseVisualStyleBackColor = true;
            this.btnGirarIzquierda.Click += new System.EventHandler(this.btnGirarIzquierda_Click);
            // 
            // txtTablero
            // 
            this.txtTablero.Location = new System.Drawing.Point(90, 128);
            this.txtTablero.Multiline = true;
            this.txtTablero.Name = "txtTablero";
            this.txtTablero.Size = new System.Drawing.Size(200, 200);
            this.txtTablero.TabIndex = 1;
            // 
            // btnGirarDerecha
            // 
            this.btnGirarDerecha.Location = new System.Drawing.Point(240, 54);
            this.btnGirarDerecha.Name = "btnGirarDerecha";
            this.btnGirarDerecha.Size = new System.Drawing.Size(90, 23);
            this.btnGirarDerecha.TabIndex = 2;
            this.btnGirarDerecha.Text = "Girar Derecha";
            this.btnGirarDerecha.UseVisualStyleBackColor = true;
            this.btnGirarDerecha.Click += new System.EventHandler(this.btnGirarDerecha_Click);
            // 
            // btnPlumaAbajo
            // 
            this.btnPlumaAbajo.Location = new System.Drawing.Point(51, 54);
            this.btnPlumaAbajo.Name = "btnPlumaAbajo";
            this.btnPlumaAbajo.Size = new System.Drawing.Size(90, 23);
            this.btnPlumaAbajo.TabIndex = 4;
            this.btnPlumaAbajo.Text = "Pluma Abajo";
            this.btnPlumaAbajo.UseVisualStyleBackColor = true;
            this.btnPlumaAbajo.Click += new System.EventHandler(this.btnPlumaAbajo_Click);
            // 
            // btnPlumaArriba
            // 
            this.btnPlumaArriba.Location = new System.Drawing.Point(51, 25);
            this.btnPlumaArriba.Name = "btnPlumaArriba";
            this.btnPlumaArriba.Size = new System.Drawing.Size(90, 23);
            this.btnPlumaArriba.TabIndex = 3;
            this.btnPlumaArriba.Text = "Pluma Arriba";
            this.btnPlumaArriba.UseVisualStyleBackColor = true;
            this.btnPlumaArriba.Click += new System.EventHandler(this.btnPlumaArriba_Click);
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Location = new System.Drawing.Point(51, 83);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(90, 23);
            this.btnAvanzar.TabIndex = 5;
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(240, 83);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(90, 23);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 346);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.btnPlumaAbajo);
            this.Controls.Add(this.btnPlumaArriba);
            this.Controls.Add(this.btnGirarDerecha);
            this.Controls.Add(this.txtTablero);
            this.Controls.Add(this.btnGirarIzquierda);
            this.Name = "Form1";
            this.Text = "Tortuga";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGirarIzquierda;
        private System.Windows.Forms.TextBox txtTablero;
        private System.Windows.Forms.Button btnGirarDerecha;
        private System.Windows.Forms.Button btnPlumaAbajo;
        private System.Windows.Forms.Button btnPlumaArriba;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.Button btnImprimir;
    }
}

