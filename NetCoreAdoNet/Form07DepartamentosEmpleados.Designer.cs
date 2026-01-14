namespace NetCoreAdoNet
{
    partial class Form07DepartamentosEmpleados
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
            label2 = new Label();
            lstDepts = new ListBox();
            lstEmps = new ListBox();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 13);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 13);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "Empleados";
            // 
            // lstDepts
            // 
            lstDepts.FormattingEnabled = true;
            lstDepts.Location = new Point(16, 31);
            lstDepts.Name = "lstDepts";
            lstDepts.Size = new Size(120, 94);
            lstDepts.TabIndex = 2;
            lstDepts.SelectedIndexChanged += lstDepts_SelectedIndexChanged;
            // 
            // lstEmps
            // 
            lstEmps.FormattingEnabled = true;
            lstEmps.Location = new Point(192, 31);
            lstEmps.Name = "lstEmps";
            lstEmps.Size = new Size(120, 94);
            lstEmps.TabIndex = 3;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(365, 63);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form07DepartamentosEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 138);
            Controls.Add(btnEliminar);
            Controls.Add(lstEmps);
            Controls.Add(lstDepts);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form07DepartamentosEmpleados";
            Text = "Form07DepartamentosEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox lstDepts;
        private ListBox lstEmps;
        private Button btnEliminar;
    }
}