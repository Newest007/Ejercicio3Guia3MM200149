
namespace Ejercicio3___Guía3_MM200149
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
            this.listadoproduct = new System.Windows.Forms.Label();
            this.dtgvlistado = new System.Windows.Forms.DataGridView();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.btneliminar = new System.Windows.Forms.Button();
            this.gbxingresar = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btningresardat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvlistado)).BeginInit();
            this.gbxingresar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listadoproduct
            // 
            this.listadoproduct.AutoSize = true;
            this.listadoproduct.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listadoproduct.Location = new System.Drawing.Point(116, 35);
            this.listadoproduct.Name = "listadoproduct";
            this.listadoproduct.Size = new System.Drawing.Size(170, 26);
            this.listadoproduct.TabIndex = 0;
            this.listadoproduct.Text = "Listado de Productos";
            // 
            // dtgvlistado
            // 
            this.dtgvlistado.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dtgvlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvlistado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Imagen});
            this.dtgvlistado.Location = new System.Drawing.Point(12, 76);
            this.dtgvlistado.Name = "dtgvlistado";
            this.dtgvlistado.Size = new System.Drawing.Size(410, 256);
            this.dtgvlistado.TabIndex = 1;
            this.dtgvlistado.DoubleClick += new System.EventHandler(this.dtgvlistado_DoubleClick);
            // 
            // Imagen
            // 
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.Name = "Imagen";
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(50, 355);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(123, 39);
            this.btneliminar.TabIndex = 2;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // gbxingresar
            // 
            this.gbxingresar.BackColor = System.Drawing.Color.LavenderBlush;
            this.gbxingresar.Controls.Add(this.pictureBox1);
            this.gbxingresar.Controls.Add(this.button3);
            this.gbxingresar.Controls.Add(this.button2);
            this.gbxingresar.Controls.Add(this.label1);
            this.gbxingresar.Controls.Add(this.txtstock);
            this.gbxingresar.Controls.Add(this.label6);
            this.gbxingresar.Controls.Add(this.txtprecio);
            this.gbxingresar.Controls.Add(this.label5);
            this.gbxingresar.Controls.Add(this.txtmarca);
            this.gbxingresar.Controls.Add(this.label4);
            this.gbxingresar.Controls.Add(this.txtdescripcion);
            this.gbxingresar.Controls.Add(this.label3);
            this.gbxingresar.Controls.Add(this.txtnombre);
            this.gbxingresar.Controls.Add(this.label2);
            this.gbxingresar.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxingresar.Location = new System.Drawing.Point(438, 46);
            this.gbxingresar.Name = "gbxingresar";
            this.gbxingresar.Size = new System.Drawing.Size(375, 513);
            this.gbxingresar.TabIndex = 3;
            this.gbxingresar.TabStop = false;
            this.gbxingresar.Text = "Mantenimientos de Productos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(205, 373);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(186, 454);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 45);
            this.button3.TabIndex = 12;
            this.button3.Text = "Listado Productos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 45);
            this.button2.TabIndex = 11;
            this.button2.Text = "Guardar Datos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Imagen a cargar:";
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(134, 316);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(103, 34);
            this.txtstock.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Stock:";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(134, 263);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(103, 34);
            this.txtprecio.TabIndex = 7;
            this.txtprecio.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Precio:";
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(134, 203);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(206, 34);
            this.txtmarca.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Marca:";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(134, 121);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(206, 64);
            this.txtdescripcion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(134, 58);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(206, 34);
            this.txtnombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // btningresardat
            // 
            this.btningresardat.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningresardat.Location = new System.Drawing.Point(237, 355);
            this.btningresardat.Name = "btningresardat";
            this.btningresardat.Size = new System.Drawing.Size(123, 64);
            this.btningresardat.TabIndex = 4;
            this.btningresardat.Text = "Ingresar Productos";
            this.btningresardat.UseVisualStyleBackColor = true;
            this.btningresardat.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 571);
            this.Controls.Add(this.btningresardat);
            this.Controls.Add(this.gbxingresar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.dtgvlistado);
            this.Controls.Add(this.listadoproduct);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 3 Guía 3 MM200149";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvlistado)).EndInit();
            this.gbxingresar.ResumeLayout(false);
            this.gbxingresar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label listadoproduct;
        private System.Windows.Forms.DataGridView dtgvlistado;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.GroupBox gbxingresar;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewImageColumn Imagen;
        private System.Windows.Forms.Button btningresardat;
    }
}

