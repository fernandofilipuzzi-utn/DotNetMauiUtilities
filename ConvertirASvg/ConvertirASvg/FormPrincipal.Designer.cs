namespace ConvertirASvg
{
    partial class FormPrincipal
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
            btnSeleccionarImagen = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            btnConvertiraSVG = new Button();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSeleccionarImagen
            // 
            btnSeleccionarImagen.Location = new Point(526, 69);
            btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            btnSeleccionarImagen.Size = new Size(94, 61);
            btnSeleccionarImagen.TabIndex = 0;
            btnSeleccionarImagen.Text = "Seleccionar Imagen";
            btnSeleccionarImagen.UseVisualStyleBackColor = true;
            btnSeleccionarImagen.Click += btnSeleccionarImagen_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(508, 339);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnConvertiraSVG
            // 
            btnConvertiraSVG.Location = new Point(526, 145);
            btnConvertiraSVG.Name = "btnConvertiraSVG";
            btnConvertiraSVG.Size = new Size(94, 59);
            btnConvertiraSVG.TabIndex = 2;
            btnConvertiraSVG.Text = "Convertir a SVG";
            btnConvertiraSVG.UseVisualStyleBackColor = true;
            btnConvertiraSVG.Click += btnConvertiraSVG_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 374);
            Controls.Add(btnConvertiraSVG);
            Controls.Add(pictureBox1);
            Controls.Add(btnSeleccionarImagen);
            Name = "FormPrincipal";
            Text = "Convertir a vectorial imagenes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSeleccionarImagen;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private Button btnConvertiraSVG;
        private SaveFileDialog saveFileDialog1;
    }
}
