namespace FormsPildorasInformaticas
{
    partial class VentanaPrincipal
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
            btnInscripcion = new Button();
            button2 = new Button();
            btnPago = new Button();
            btnListado = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnInscripcion
            // 
            btnInscripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInscripcion.Location = new Point(154, 120);
            btnInscripcion.Name = "btnInscripcion";
            btnInscripcion.Size = new Size(173, 83);
            btnInscripcion.TabIndex = 0;
            btnInscripcion.Text = "Inscribir Socio";
            btnInscripcion.UseVisualStyleBackColor = true;
            btnInscripcion.Click += btnInscripcion_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(478, 120);
            button2.Name = "button2";
            button2.Size = new Size(163, 83);
            button2.TabIndex = 1;
            button2.Text = "Inscripción Actividades";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnPago
            // 
            btnPago.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPago.Location = new Point(154, 262);
            btnPago.Name = "btnPago";
            btnPago.Size = new Size(173, 69);
            btnPago.TabIndex = 2;
            btnPago.Text = "Pagos";
            btnPago.UseVisualStyleBackColor = true;
            // 
            // btnListado
            // 
            btnListado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnListado.Location = new Point(478, 262);
            btnListado.Name = "btnListado";
            btnListado.Size = new Size(163, 69);
            btnListado.TabIndex = 3;
            btnListado.Text = "Listado de Vencimientos";
            btnListado.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(653, 37);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnListado);
            Controls.Add(btnPago);
            Controls.Add(button2);
            Controls.Add(btnInscripcion);
            Name = "VentanaPrincipal";
            Text = "Ventana Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnInscripcion;
        private Button button2;
        private Button btnPago;
        private Button btnListado;
        private Button btnSalir;
    }
}