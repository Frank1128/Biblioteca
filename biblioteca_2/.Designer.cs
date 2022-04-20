namespace biblioteca_2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtautor1 = new System.Windows.Forms.TextBox();
            this.txtlibro1 = new System.Windows.Forms.TextBox();
            this.txtubicacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdisponible = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(542, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(542, 96);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(72, 300);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 49);
            this.button3.TabIndex = 2;
            this.button3.Text = "Nueva Busqueda";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(514, 313);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 36);
            this.button4.TabIndex = 3;
            this.button4.Text = "salir";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtautor1
            // 
            this.txtautor1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtautor1.Cursor = System.Windows.Forms.Cursors.No;
            this.txtautor1.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtautor1.Location = new System.Drawing.Point(317, 21);
            this.txtautor1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtautor1.Multiline = true;
            this.txtautor1.Name = "txtautor1";
            this.txtautor1.ReadOnly = true;
            this.txtautor1.Size = new System.Drawing.Size(176, 30);
            this.txtautor1.TabIndex = 4;
            this.txtautor1.TabStop = false;
            this.txtautor1.Text = "e";
            this.txtautor1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtlibro1
            // 
            this.txtlibro1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtlibro1.Cursor = System.Windows.Forms.Cursors.No;
            this.txtlibro1.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlibro1.Location = new System.Drawing.Point(358, 96);
            this.txtlibro1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtlibro1.Multiline = true;
            this.txtlibro1.Name = "txtlibro1";
            this.txtlibro1.ReadOnly = true;
            this.txtlibro1.Size = new System.Drawing.Size(135, 29);
            this.txtlibro1.TabIndex = 5;
            this.txtlibro1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtubicacion
            // 
            this.txtubicacion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtubicacion.Cursor = System.Windows.Forms.Cursors.No;
            this.txtubicacion.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtubicacion.Location = new System.Drawing.Point(358, 150);
            this.txtubicacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtubicacion.Multiline = true;
            this.txtubicacion.Name = "txtubicacion";
            this.txtubicacion.ReadOnly = true;
            this.txtubicacion.Size = new System.Drawing.Size(135, 30);
            this.txtubicacion.TabIndex = 6;
            this.txtubicacion.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre del Libro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ubicacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(181, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Disponible";
            // 
            // txtdisponible
            // 
            this.txtdisponible.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtdisponible.Cursor = System.Windows.Forms.Cursors.No;
            this.txtdisponible.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdisponible.Location = new System.Drawing.Point(393, 216);
            this.txtdisponible.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdisponible.Multiline = true;
            this.txtdisponible.Name = "txtdisponible";
            this.txtdisponible.ReadOnly = true;
            this.txtdisponible.ShortcutsEnabled = false;
            this.txtdisponible.Size = new System.Drawing.Size(100, 27);
            this.txtdisponible.TabIndex = 11;
            this.txtdisponible.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::biblioteca_2.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(663, 385);
            this.Controls.Add(this.txtdisponible);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtubicacion);
            this.Controls.Add(this.txtlibro1);
            this.Controls.Add(this.txtautor1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Biblioteca Nacional";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtautor1;
        private System.Windows.Forms.TextBox txtlibro1;
        private System.Windows.Forms.TextBox txtubicacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdisponible;
    }
}

