namespace Celulares
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
            lblCel = new Label();
            lblMarca = new Label();
            lblModelo = new Label();
            lblEstado = new Label();
            btnGuardar = new Button();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            txtEstado = new TextBox();
            dgvMostrar = new DataGridView();
            btnEliminar = new Button();
            btnEditar = new Button();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMostrar).BeginInit();
            SuspendLayout();
            // 
            // lblCel
            // 
            lblCel.AutoSize = true;
            lblCel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCel.Location = new Point(291, 9);
            lblCel.Name = "lblCel";
            lblCel.Size = new Size(115, 21);
            lblCel.TabIndex = 0;
            lblCel.Text = "CELULARES SV";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(21, 44);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(43, 15);
            lblMarca.TabIndex = 1;
            lblMarca.Text = "Marca:";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(21, 103);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(51, 15);
            lblModelo.TabIndex = 2;
            lblModelo.Text = "Modelo:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(21, 209);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 3;
            lblEstado.Text = "Estado:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(21, 286);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(21, 62);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(152, 23);
            txtMarca.TabIndex = 5;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(21, 121);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(152, 23);
            txtModelo.TabIndex = 6;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(21, 227);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(152, 23);
            txtEstado.TabIndex = 8;
            // 
            // dgvMostrar
            // 
            dgvMostrar.AllowUserToAddRows = false;
            dgvMostrar.AllowUserToDeleteRows = false;
            dgvMostrar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMostrar.Location = new Point(271, 62);
            dgvMostrar.Name = "dgvMostrar";
            dgvMostrar.ReadOnly = true;
            dgvMostrar.Size = new Size(469, 247);
            dgvMostrar.TabIndex = 12;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(190, 286);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(109, 286);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(21, 156);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 11;
            lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(21, 174);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(152, 23);
            txtPrecio.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 362);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(dgvMostrar);
            Controls.Add(txtEstado);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(btnGuardar);
            Controls.Add(lblEstado);
            Controls.Add(lblModelo);
            Controls.Add(lblMarca);
            Controls.Add(lblCel);
            Name = "Form1";
            Text = "Alfonso Isai Alvarez Franco 25-1224-2023";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMostrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCel;
        private Label lblMarca;
        private Label lblModelo;
        private Label lblEstado;
        private Button btnGuardar;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private TextBox txtEstado;
        private DataGridView dgvMostrar;
        private Button btnEliminar;
        private Button btnEditar;
        private Label lblPrecio;
        private TextBox txtPrecio;
    }
}
