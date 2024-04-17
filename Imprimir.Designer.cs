namespace Examen_Parcial_3
{
    partial class Imprimir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Imprimir));
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpago = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblcambio = new System.Windows.Forms.Label();
            this.txtlista = new System.Windows.Forms.TextBox();
            this.btnpagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(236, 62);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(208, 27);
            this.txtnombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefono del cliente";
            // 
            // txttelefono
            // 
            this.txttelefono.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.Location = new System.Drawing.Point(236, 119);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(208, 27);
            this.txttelefono.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cantidad de efectivo";
            // 
            // txtpago
            // 
            this.txtpago.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpago.Location = new System.Drawing.Point(236, 180);
            this.txtpago.Name = "txtpago";
            this.txtpago.Size = new System.Drawing.Size(110, 27);
            this.txtpago.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(335, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Su cambio es:";
            // 
            // lblcambio
            // 
            this.lblcambio.AutoSize = true;
            this.lblcambio.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcambio.Location = new System.Drawing.Point(372, 271);
            this.lblcambio.Name = "lblcambio";
            this.lblcambio.Size = new System.Drawing.Size(63, 20);
            this.lblcambio.TabIndex = 1;
            this.lblcambio.Text = "cambio";
            // 
            // txtlista
            // 
            this.txtlista.Location = new System.Drawing.Point(33, 224);
            this.txtlista.Multiline = true;
            this.txtlista.Name = "txtlista";
            this.txtlista.ReadOnly = true;
            this.txtlista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtlista.Size = new System.Drawing.Size(287, 201);
            this.txtlista.TabIndex = 4;
            // 
            // btnpagar
            // 
            this.btnpagar.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpagar.Location = new System.Drawing.Point(339, 352);
            this.btnpagar.Name = "btnpagar";
            this.btnpagar.Size = new System.Drawing.Size(122, 33);
            this.btnpagar.TabIndex = 5;
            this.btnpagar.Text = "Pagar";
            this.btnpagar.UseVisualStyleBackColor = true;
            this.btnpagar.Click += new System.EventHandler(this.btnpagar_Click);
            // 
            // Imprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(473, 437);
            this.Controls.Add(this.btnpagar);
            this.Controls.Add(this.txtlista);
            this.Controls.Add(this.txtpago);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.lblcambio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Imprimir";
            this.Text = "Imprimir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblcambio;
        private System.Windows.Forms.TextBox txtlista;
        private System.Windows.Forms.Button btnpagar;
    }
}