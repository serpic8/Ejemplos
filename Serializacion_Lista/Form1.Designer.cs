namespace Serializacion_Lista
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
            btnSerializar = new Button();
            btnDeserializar = new Button();
            dgvDatos = new DataGridView();
            txtNombre = new TextBox();
            label1 = new Label();
            txtCorreo = new TextBox();
            txtEdad = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnRegistrar = new Button();
            btnBorrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // btnSerializar
            // 
            btnSerializar.Enabled = false;
            btnSerializar.Location = new Point(347, 106);
            btnSerializar.Name = "btnSerializar";
            btnSerializar.Size = new Size(75, 23);
            btnSerializar.TabIndex = 0;
            btnSerializar.Text = "Serializar";
            btnSerializar.UseVisualStyleBackColor = true;
            btnSerializar.Click += btnSerializar_Click;
            // 
            // btnDeserializar
            // 
            btnDeserializar.Enabled = false;
            btnDeserializar.Location = new Point(347, 152);
            btnDeserializar.Name = "btnDeserializar";
            btnDeserializar.Size = new Size(75, 23);
            btnDeserializar.TabIndex = 1;
            btnDeserializar.Text = "Deserializar";
            btnDeserializar.UseVisualStyleBackColor = true;
            btnDeserializar.Click += btnDeserializar_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvDatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Dock = DockStyle.Bottom;
            dgvDatos.Location = new Point(0, 269);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.Size = new Size(604, 150);
            dgvDatos.TabIndex = 2;
            dgvDatos.CellDoubleClick += dgvDatos_CellDoubleClick;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(142, 61);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 69);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(142, 152);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(100, 23);
            txtCorreo.TabIndex = 5;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(142, 106);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 114);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 7;
            label2.Text = "Edad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 160);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 8;
            label3.Text = "Correo Electronico";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(347, 61);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(347, 202);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 10;
            btnBorrar.Text = "Borrar Lista";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 419);
            Controls.Add(btnBorrar);
            Controls.Add(btnRegistrar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtEdad);
            Controls.Add(txtCorreo);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(dgvDatos);
            Controls.Add(btnDeserializar);
            Controls.Add(btnSerializar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSerializar;
        private Button btnDeserializar;
        private DataGridView dgvDatos;
        private TextBox txtNombre;
        private Label label1;
        private TextBox txtCorreo;
        private TextBox txtEdad;
        private Label label2;
        private Label label3;
        private Button btnRegistrar;
        private Button btnBorrar;
    }
}