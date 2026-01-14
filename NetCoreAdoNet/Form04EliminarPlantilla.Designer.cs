namespace NetCoreAdoNet
{
    partial class Form04EliminarPlantilla
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
            txtId = new TextBox();
            lstPlantilla = new ListBox();
            label2 = new Label();
            btnEliminar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(14, 45);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 10;
            // 
            // lstPlantilla
            // 
            lstPlantilla.FormattingEnabled = true;
            lstPlantilla.Location = new Point(158, 45);
            lstPlantilla.Name = "lstPlantilla";
            lstPlantilla.Size = new Size(164, 199);
            lstPlantilla.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 12);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 8;
            label2.Text = "Plantilla";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(14, 89);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 44);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 6;
            label1.Text = "Inscripcion";
            // 
            // Form04EliminarPlantilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 260);
            Controls.Add(txtId);
            Controls.Add(lstPlantilla);
            Controls.Add(label2);
            Controls.Add(btnEliminar);
            Controls.Add(label1);
            Name = "Form04EliminarPlantilla";
            Text = "Form04EliminarPlantilla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private ListBox lstPlantilla;
        private Label label2;
        private Button btnEliminar;
        private Label label1;
    }
}