namespace FormsPildorasInformaticas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtUsuario = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            lblUsuario = new Label();
            lblContrasenia = new Label();
            pictureBox1 = new PictureBox();
            txtPassword = new TextBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(385, 303);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(127, 64);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(610, 303);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(141, 64);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(538, 90);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(213, 27);
            txtUsuario.TabIndex = 2;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(385, 90);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(79, 28);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblContrasenia.ForeColor = SystemColors.ActiveCaptionText;
            lblContrasenia.Location = new Point(385, 168);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(110, 28);
            lblContrasenia.TabIndex = 4;
            lblContrasenia.Text = "Contraseña";
            lblContrasenia.Click += lblContrasenia_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(88, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 248);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(538, 169);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(213, 27);
            txtPassword.TabIndex = 6;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(593, 217);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(158, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Mostrar contraseña";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(879, 460);
            Controls.Add(checkBox1);
            Controls.Add(txtPassword);
            Controls.Add(pictureBox1);
            Controls.Add(lblContrasenia);
            Controls.Add(lblUsuario);
            Controls.Add(txtUsuario);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtUsuario;
        private System.Windows.Forms.Timer timer1;
        private Label lblUsuario;
        private Label lblContrasenia;
        private PictureBox pictureBox1;
        private TextBox txtPassword;
        private CheckBox checkBox1;
    }
}
