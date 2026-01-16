namespace NetCoreAdoNet
{
    partial class Form09CRUDHospital
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
            btnEiminar = new Button();
            btnModificar = new Button();
            btnInsertar = new Button();
            txtDir = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            lstHosp = new ListBox();
            label1 = new Label();
            txtTlf = new TextBox();
            label5 = new Label();
            txtCamas = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnEiminar
            // 
            btnEiminar.Location = new Point(341, 276);
            btnEiminar.Name = "btnEiminar";
            btnEiminar.Size = new Size(75, 23);
            btnEiminar.TabIndex = 21;
            btnEiminar.Text = "Eliminar";
            btnEiminar.UseVisualStyleBackColor = true;
            btnEiminar.Click += btnEiminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(243, 276);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 20;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(133, 276);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 19;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtDir
            // 
            txtDir.Location = new Point(454, 124);
            txtDir.Name = "txtDir";
            txtDir.Size = new Size(100, 23);
            txtDir.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(454, 106);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 17;
            label4.Text = "Direccion";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(454, 71);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(454, 53);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 15;
            label3.Text = "Nombre";
            // 
            // txtID
            // 
            txtID.Location = new Point(454, 27);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(454, 9);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 13;
            label2.Text = "ID";
            // 
            // lstHosp
            // 
            lstHosp.FormattingEnabled = true;
            lstHosp.Location = new Point(12, 41);
            lstHosp.Name = "lstHosp";
            lstHosp.Size = new Size(414, 214);
            lstHosp.TabIndex = 12;
            lstHosp.SelectedIndexChanged += lstHosp_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 11;
            label1.Text = "Hospitales";
            // 
            // txtTlf
            // 
            txtTlf.Location = new Point(454, 180);
            txtTlf.Name = "txtTlf";
            txtTlf.Size = new Size(100, 23);
            txtTlf.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(454, 162);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 22;
            label5.Text = "Telefono";
            // 
            // txtCamas
            // 
            txtCamas.Location = new Point(454, 233);
            txtCamas.Name = "txtCamas";
            txtCamas.Size = new Size(100, 23);
            txtCamas.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(454, 215);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 24;
            label6.Text = "Camas";
            // 
            // Form09CRUDHospital
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 323);
            Controls.Add(txtCamas);
            Controls.Add(label6);
            Controls.Add(txtTlf);
            Controls.Add(label5);
            Controls.Add(btnEiminar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(txtDir);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(lstHosp);
            Controls.Add(label1);
            Name = "Form09CRUDHospital";
            Text = "Form09CRUDHospital";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEiminar;
        private Button btnModificar;
        private Button btnInsertar;
        private TextBox txtDir;
        private Label label4;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtID;
        private Label label2;
        private ListBox lstHosp;
        private Label label1;
        private TextBox txtTlf;
        private Label label5;
        private TextBox txtCamas;
        private Label label6;
    }
}