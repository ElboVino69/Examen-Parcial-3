namespace Examen_Parcial_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnrefresco = new System.Windows.Forms.Button();
            this.btnsabrita = new System.Windows.Forms.Button();
            this.btngalleta = new System.Windows.Forms.Button();
            this.btnjabon = new System.Windows.Forms.Button();
            this.btncosmetico = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.pcbimagen = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txblista = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbimagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnrefresco
            // 
            this.btnrefresco.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresco.Location = new System.Drawing.Point(27, 51);
            this.btnrefresco.Name = "btnrefresco";
            this.btnrefresco.Size = new System.Drawing.Size(125, 34);
            this.btnrefresco.TabIndex = 0;
            this.btnrefresco.Text = "Refresco";
            this.btnrefresco.UseVisualStyleBackColor = true;
            this.btnrefresco.Click += new System.EventHandler(this.btnrefresco_Click);
            // 
            // btnsabrita
            // 
            this.btnsabrita.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsabrita.Location = new System.Drawing.Point(27, 110);
            this.btnsabrita.Name = "btnsabrita";
            this.btnsabrita.Size = new System.Drawing.Size(125, 36);
            this.btnsabrita.TabIndex = 1;
            this.btnsabrita.Text = "Sabritas";
            this.btnsabrita.UseVisualStyleBackColor = true;
            this.btnsabrita.Click += new System.EventHandler(this.btnsabrita_Click);
            // 
            // btngalleta
            // 
            this.btngalleta.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngalleta.Location = new System.Drawing.Point(27, 169);
            this.btngalleta.Name = "btngalleta";
            this.btngalleta.Size = new System.Drawing.Size(125, 35);
            this.btngalleta.TabIndex = 2;
            this.btngalleta.Text = "Galletas";
            this.btngalleta.UseVisualStyleBackColor = true;
            this.btngalleta.Click += new System.EventHandler(this.btngalleta_Click);
            // 
            // btnjabon
            // 
            this.btnjabon.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnjabon.Location = new System.Drawing.Point(27, 228);
            this.btnjabon.Name = "btnjabon";
            this.btnjabon.Size = new System.Drawing.Size(125, 33);
            this.btnjabon.TabIndex = 3;
            this.btnjabon.Text = "Jabones";
            this.btnjabon.UseVisualStyleBackColor = true;
            this.btnjabon.Click += new System.EventHandler(this.btnjabon_Click);
            // 
            // btncosmetico
            // 
            this.btncosmetico.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncosmetico.Location = new System.Drawing.Point(27, 286);
            this.btncosmetico.Name = "btncosmetico";
            this.btncosmetico.Size = new System.Drawing.Size(125, 33);
            this.btncosmetico.TabIndex = 4;
            this.btncosmetico.Text = "Cosmeticos";
            this.btncosmetico.UseVisualStyleBackColor = true;
            this.btncosmetico.Click += new System.EventHandler(this.btncosmetico_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimir.Location = new System.Drawing.Point(158, 414);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(129, 36);
            this.btnimprimir.TabIndex = 6;
            this.btnimprimir.Text = "IMPRIMIR";
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // pcbimagen
            // 
            this.pcbimagen.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pcbimagen.ErrorImage")));
            this.pcbimagen.Image = global::Examen_Parcial_3.Properties.Resources.picture_photo_image_icon_131252;
            this.pcbimagen.InitialImage = ((System.Drawing.Image)(resources.GetObject("pcbimagen.InitialImage")));
            this.pcbimagen.Location = new System.Drawing.Point(171, 19);
            this.pcbimagen.Name = "pcbimagen";
            this.pcbimagen.Size = new System.Drawing.Size(224, 205);
            this.pcbimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbimagen.TabIndex = 5;
            this.pcbimagen.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "PRODUCTOS";
            // 
            // txblista
            // 
            this.txblista.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txblista.Location = new System.Drawing.Point(171, 234);
            this.txblista.Multiline = true;
            this.txblista.Name = "txblista";
            this.txblista.ReadOnly = true;
            this.txblista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txblista.Size = new System.Drawing.Size(224, 85);
            this.txblista.TabIndex = 8;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(158, 354);
            this.txtcantidad.Multiline = true;
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(87, 29);
            this.txtcantidad.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cantidad ";
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(285, 354);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(110, 29);
            this.btnagregar.TabIndex = 10;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(428, 462);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txblista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.pcbimagen);
            this.Controls.Add(this.btncosmetico);
            this.Controls.Add(this.btnjabon);
            this.Controls.Add(this.btngalleta);
            this.Controls.Add(this.btnsabrita);
            this.Controls.Add(this.btnrefresco);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tienda";
            ((System.ComponentModel.ISupportInitialize)(this.pcbimagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnrefresco;
        private System.Windows.Forms.Button btnsabrita;
        private System.Windows.Forms.Button btngalleta;
        private System.Windows.Forms.Button btnjabon;
        private System.Windows.Forms.Button btncosmetico;
        private System.Windows.Forms.PictureBox pcbimagen;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txblista;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnagregar;
    }
}

