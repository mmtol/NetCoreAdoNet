namespace AdoNetPracticaFinal
{
    partial class FormFinal
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
            cmbDepts = new ComboBox();
            label2 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            txtLocalidad = new TextBox();
            label4 = new Label();
            txtApellido = new TextBox();
            label5 = new Label();
            txtOficio = new TextBox();
            label6 = new Label();
            txtSalario = new TextBox();
            label7 = new Label();
            btnInsertarDept = new Button();
            label8 = new Label();
            lstEmpleados = new ListBox();
            btnUpdateEmp = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 29);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // cmbDepts
            // 
            cmbDepts.FormattingEnabled = true;
            cmbDepts.Location = new Point(30, 47);
            cmbDepts.Name = "cmbDepts";
            cmbDepts.Size = new Size(121, 23);
            cmbDepts.TabIndex = 1;
            cmbDepts.SelectedIndexChanged += cmbDepts_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 90);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 2;
            label2.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(30, 108);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(30, 162);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 144);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(30, 215);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(100, 23);
            txtLocalidad.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 197);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 6;
            label4.Text = "Localidad";
            // 
            // txtApellido
            // 
            txtApellido.Enabled = false;
            txtApellido.Location = new Point(420, 45);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(420, 27);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 8;
            label5.Text = "Apellido";
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(420, 108);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(100, 23);
            txtOficio.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(420, 90);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 10;
            label6.Text = "Oficio";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(420, 177);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(100, 23);
            txtSalario.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(420, 159);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 12;
            label7.Text = "Salario";
            // 
            // btnInsertarDept
            // 
            btnInsertarDept.Location = new Point(30, 267);
            btnInsertarDept.Name = "btnInsertarDept";
            btnInsertarDept.Size = new Size(121, 39);
            btnInsertarDept.TabIndex = 14;
            btnInsertarDept.Text = "Insertar dept";
            btnInsertarDept.UseVisualStyleBackColor = true;
            btnInsertarDept.Click += btnInsertarDept_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(185, 9);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 15;
            label8.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(185, 27);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(210, 289);
            lstEmpleados.TabIndex = 16;
            lstEmpleados.SelectedIndexChanged += lstEmpleados_SelectedIndexChanged;
            // 
            // btnUpdateEmp
            // 
            btnUpdateEmp.Location = new Point(420, 226);
            btnUpdateEmp.Name = "btnUpdateEmp";
            btnUpdateEmp.Size = new Size(100, 41);
            btnUpdateEmp.TabIndex = 17;
            btnUpdateEmp.Text = "Update emp";
            btnUpdateEmp.UseVisualStyleBackColor = true;
            btnUpdateEmp.Click += btnUpdateEmp_Click;
            // 
            // FormFinal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 329);
            Controls.Add(btnUpdateEmp);
            Controls.Add(lstEmpleados);
            Controls.Add(label8);
            Controls.Add(btnInsertarDept);
            Controls.Add(txtSalario);
            Controls.Add(label7);
            Controls.Add(txtOficio);
            Controls.Add(label6);
            Controls.Add(txtApellido);
            Controls.Add(label5);
            Controls.Add(txtLocalidad);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(cmbDepts);
            Controls.Add(label1);
            Name = "FormFinal";
            Text = "FormFinal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbDepts;
        private Label label2;
        private TextBox txtId;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtLocalidad;
        private Label label4;
        private TextBox txtApellido;
        private Label label5;
        private TextBox txtOficio;
        private Label label6;
        private TextBox txtSalario;
        private Label label7;
        private Button btnInsertarDept;
        private Label label8;
        private ListBox lstEmpleados;
        private Button btnUpdateEmp;
    }
}