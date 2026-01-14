namespace NetCoreAdoNet
{
    partial class Form03EliminarEnfermo
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
            btnEliminar = new Button();
            label2 = new Label();
            lstEnfermos = new ListBox();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 30);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Inscripcion";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(42, 107);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 44);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 30);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Enfermos";
            // 
            // lstEnfermos
            // 
            lstEnfermos.FormattingEnabled = true;
            lstEnfermos.Location = new Point(186, 63);
            lstEnfermos.Name = "lstEnfermos";
            lstEnfermos.Size = new Size(164, 199);
            lstEnfermos.TabIndex = 4;
            // 
            // txtId
            // 
            txtId.Location = new Point(42, 63);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 5;
            // 
            // Form03EliminarEnfermo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 285);
            Controls.Add(txtId);
            Controls.Add(lstEnfermos);
            Controls.Add(label2);
            Controls.Add(btnEliminar);
            Controls.Add(label1);
            Name = "Form03EliminarEnfermo";
            Text = "Form03EliminarEnfermo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private Button btnEliminar;
        private Label label2;
        private ListBox lstEnfermos;
        private TextBox txtId;
    }
}