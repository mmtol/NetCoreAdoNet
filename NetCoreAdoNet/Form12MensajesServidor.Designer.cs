namespace NetCoreAdoNet
{
    partial class Form12MensajesServidor
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
            label1 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            txtLocalidad = new TextBox();
            label3 = new Label();
            btnNuevoDept = new Button();
            lblServidor = new Label();
            label5 = new Label();
            lstDepartamentos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(12, 29);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 84);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(12, 138);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(100, 23);
            txtLocalidad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 120);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Localidad";
            // 
            // btnNuevoDept
            // 
            btnNuevoDept.Location = new Point(12, 184);
            btnNuevoDept.Name = "btnNuevoDept";
            btnNuevoDept.Size = new Size(100, 28);
            btnNuevoDept.TabIndex = 6;
            btnNuevoDept.Text = "Nuevo Dept";
            btnNuevoDept.UseVisualStyleBackColor = true;
            btnNuevoDept.Click += btnNuevoDept_Click;
            // 
            // lblServidor
            // 
            lblServidor.AutoSize = true;
            lblServidor.Location = new Point(12, 249);
            lblServidor.Name = "lblServidor";
            lblServidor.Size = new Size(56, 15);
            lblServidor.TabIndex = 7;
            lblServidor.Text = "Servidor: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(152, 11);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 8;
            label5.Text = "Departamentos";
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(152, 29);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(249, 214);
            lstDepartamentos.TabIndex = 9;
            // 
            // Form12MensajesServidor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 273);
            Controls.Add(lstDepartamentos);
            Controls.Add(label5);
            Controls.Add(lblServidor);
            Controls.Add(btnNuevoDept);
            Controls.Add(txtLocalidad);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "Form12MensajesServidor";
            Text = "Form12MensajesServidor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtLocalidad;
        private Label label3;
        private Button btnNuevoDept;
        private Label lblServidor;
        private Label label5;
        private ListBox lstDepartamentos;
    }
}