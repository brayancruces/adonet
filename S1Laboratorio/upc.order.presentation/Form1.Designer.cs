namespace upc.order.presentation
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboproducto = new System.Windows.Forms.ComboBox();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.lblprecio = new System.Windows.Forms.Label();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.lstventa = new System.Windows.Forms.ListView();
            this.ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbltotalneto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Cliente o Razon Social";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion del Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // cboproducto
            // 
            this.cboproducto.FormattingEnabled = true;
            this.cboproducto.Location = new System.Drawing.Point(44, 121);
            this.cboproducto.Name = "cboproducto";
            this.cboproducto.Size = new System.Drawing.Size(121, 21);
            this.cboproducto.TabIndex = 4;
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(44, 54);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(392, 20);
            this.txtcliente.TabIndex = 5;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(216, 122);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(46, 20);
            this.txtcantidad.TabIndex = 6;
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(301, 125);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(35, 13);
            this.lblprecio.TabIndex = 7;
            this.lblprecio.Text = "label5";
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(350, 336);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(86, 34);
            this.btnregistrar.TabIndex = 8;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // lstventa
            // 
            this.lstventa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstventa.Location = new System.Drawing.Point(44, 175);
            this.lstventa.Name = "lstventa";
            this.lstventa.Size = new System.Drawing.Size(392, 138);
            this.lstventa.TabIndex = 9;
            this.lstventa.UseCompatibleStateImageBehavior = false;
            this.lstventa.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader
            // 
            this.ColumnHeader.Text = "Producto";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cantidad";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Precio";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Subtotal";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Descuento";
            this.columnHeader4.Width = 82;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Neto";
            this.columnHeader5.Width = 66;
            // 
            // lbltotalneto
            // 
            this.lbltotalneto.AutoSize = true;
            this.lbltotalneto.Location = new System.Drawing.Point(265, 347);
            this.lbltotalneto.Name = "lbltotalneto";
            this.lbltotalneto.Size = new System.Drawing.Size(35, 13);
            this.lbltotalneto.TabIndex = 10;
            this.lbltotalneto.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total Neto a Pagar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 392);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbltotalneto);
            this.Controls.Add(this.lstventa);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.cboproducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboproducto;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.ListView lstventa;
        private System.Windows.Forms.ColumnHeader ColumnHeader;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lbltotalneto;
        private System.Windows.Forms.Label label5;
    }
}

