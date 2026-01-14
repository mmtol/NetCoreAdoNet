namespace NetCoreAdoNet
{
    partial class Form08CRUDDepts
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
            lstDepts = new ListBox();
            label2 = new Label();
            txtID = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            txtLoc = new TextBox();
            label4 = new Label();
            btnInsertar = new Button();
            btnModificar = new Button();
            btnEiminar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // lstDepts
            // 
            lstDepts.FormattingEnabled = true;
            lstDepts.Location = new Point(12, 54);
            lstDepts.Name = "lstDepts";
            lstDepts.Size = new Size(245, 214);
            lstDepts.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 57);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 2;
            label2.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(284, 87);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(284, 164);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(284, 134);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // txtLoc
            // 
            txtLoc.Location = new Point(284, 245);
            txtLoc.Name = "txtLoc";
            txtLoc.Size = new Size(100, 23);
            txtLoc.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(284, 215);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 6;
            label4.Text = "Localidad";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(59, 291);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 8;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(169, 291);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEiminar
            // 
            btnEiminar.Location = new Point(267, 291);
            btnEiminar.Name = "btnEiminar";
            btnEiminar.Size = new Size(75, 23);
            btnEiminar.TabIndex = 10;
            btnEiminar.Text = "Eliminar";
            btnEiminar.UseVisualStyleBackColor = true;
            btnEiminar.Click += btnEiminar_Click;
            // 
            // Form08CRUDDepts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 336);
            Controls.Add(btnEiminar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(txtLoc);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(lstDepts);
            Controls.Add(label1);
            Name = "Form08CRUDDepts";
            Text = "Form08CRUDDepts";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstDepts;
        private Label label2;
        private TextBox txtID;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtLoc;
        private Label label4;
        private Button btnInsertar;
        private Button btnModificar;
        private Button btnEiminar;
    }
}