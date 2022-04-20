namespace biblioteca_2
{
    partial class REGISTRO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REGISTRO));
            this.btn_Registrarse = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.txt_cedula = new System.Windows.Forms.TextBox();
            this.txt_passw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tel = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.Label();
            this.txt_cc = new System.Windows.Forms.Label();
            this.txt_contraseña = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_atras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Registrarse
            // 
            this.btn_Registrarse.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Registrarse.Location = new System.Drawing.Point(64, 531);
            this.btn_Registrarse.Name = "btn_Registrarse";
            this.btn_Registrarse.Size = new System.Drawing.Size(182, 60);
            this.btn_Registrarse.TabIndex = 0;
            this.btn_Registrarse.Text = "REGISTRARSE";
            this.btn_Registrarse.UseVisualStyleBackColor = false;
            this.btn_Registrarse.Click += new System.EventHandler(this.btn_registro);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(299, 227);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(167, 26);
            this.txt_nombre.TabIndex = 1;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(299, 368);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(119, 26);
            this.txt_phone.TabIndex = 2;
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(299, 415);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(167, 26);
            this.txt_mail.TabIndex = 3;
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(299, 273);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(167, 26);
            this.txt_apellidos.TabIndex = 4;
            // 
            // txt_cedula
            // 
            this.txt_cedula.Location = new System.Drawing.Point(299, 318);
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(119, 26);
            this.txt_cedula.TabIndex = 5;
            // 
            // txt_passw
            // 
            this.txt_passw.Location = new System.Drawing.Point(299, 458);
            this.txt_passw.Name = "txt_passw";
            this.txt_passw.PasswordChar = '*';
            this.txt_passw.Size = new System.Drawing.Size(119, 26);
            this.txt_passw.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "NOMBRE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_tel
            // 
            this.txt_tel.AutoSize = true;
            this.txt_tel.Location = new System.Drawing.Point(124, 374);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(94, 20);
            this.txt_tel.TabIndex = 8;
            this.txt_tel.Text = "TELEFONO";
            // 
            // txt_email
            // 
            this.txt_email.AutoSize = true;
            this.txt_email.Location = new System.Drawing.Point(155, 421);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(63, 20);
            this.txt_email.TabIndex = 9;
            this.txt_email.Text = "E-MAIL";
            // 
            // txt_apellido
            // 
            this.txt_apellido.AutoSize = true;
            this.txt_apellido.Location = new System.Drawing.Point(130, 279);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(88, 20);
            this.txt_apellido.TabIndex = 10;
            this.txt_apellido.Text = "APELLIDO";
            // 
            // txt_cc
            // 
            this.txt_cc.AutoSize = true;
            this.txt_cc.Location = new System.Drawing.Point(143, 324);
            this.txt_cc.Name = "txt_cc";
            this.txt_cc.Size = new System.Drawing.Size(75, 20);
            this.txt_cc.TabIndex = 11;
            this.txt_cc.Text = "CEDULA";
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.AutoSize = true;
            this.txt_contraseña.Location = new System.Drawing.Point(99, 464);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(119, 20);
            this.txt_contraseña.TabIndex = 12;
            this.txt_contraseña.Text = "CONTRASEÑA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::biblioteca_2.Properties.Resources.th;
            this.pictureBox1.Location = new System.Drawing.Point(174, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btn_atras
            // 
            this.btn_atras.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_atras.Location = new System.Drawing.Point(355, 531);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(182, 60);
            this.btn_atras.TabIndex = 14;
            this.btn_atras.Text = "REGRESAR";
            this.btn_atras.UseVisualStyleBackColor = false;
            this.btn_atras.Click += new System.EventHandler(this.button1_Click);
            // 
            // REGISTRO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(581, 631);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_cc);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_passw);
            this.Controls.Add(this.txt_cedula);
            this.Controls.Add(this.txt_apellidos);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.btn_Registrarse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "REGISTRO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO";
            this.Load += new System.EventHandler(this.REGISTRO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Registrarse;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.TextBox txt_cedula;
        private System.Windows.Forms.TextBox txt_passw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_tel;
        private System.Windows.Forms.Label txt_email;
        private System.Windows.Forms.Label txt_apellido;
        private System.Windows.Forms.Label txt_cc;
        private System.Windows.Forms.Label txt_contraseña;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_atras;
    }
}