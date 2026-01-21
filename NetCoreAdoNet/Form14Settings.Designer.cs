namespace NetCoreAdoNet
{
    partial class Form14Settings
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
            btnLeer = new Button();
            lblSrc = new Label();
            pb1 = new PictureBox();
            pb2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb2).BeginInit();
            SuspendLayout();
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(25, 26);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(75, 23);
            btnLeer.TabIndex = 0;
            btnLeer.Text = "Leer";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // lblSrc
            // 
            lblSrc.AutoSize = true;
            lblSrc.Location = new Point(25, 72);
            lblSrc.Name = "lblSrc";
            lblSrc.Size = new Size(34, 15);
            lblSrc.TabIndex = 1;
            lblSrc.Text = "SRC: ";
            // 
            // pb1
            // 
            pb1.Location = new Point(25, 113);
            pb1.Name = "pb1";
            pb1.Size = new Size(183, 123);
            pb1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb1.TabIndex = 2;
            pb1.TabStop = false;
            // 
            // pb2
            // 
            pb2.Location = new Point(25, 266);
            pb2.Name = "pb2";
            pb2.Size = new Size(183, 141);
            pb2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb2.TabIndex = 3;
            pb2.TabStop = false;
            // 
            // Form14Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 441);
            Controls.Add(pb2);
            Controls.Add(pb1);
            Controls.Add(lblSrc);
            Controls.Add(btnLeer);
            Name = "Form14Settings";
            Text = "Form14Settings";
            ((System.ComponentModel.ISupportInitialize)pb1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLeer;
        private Label lblSrc;
        private PictureBox pb1;
        private PictureBox pb2;
    }
}