namespace ConvertirASvg
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        
        string pathImage = "";

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PNG (*.png)|*.png|JPEG (*.jpg)|*.jpg"; ;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathImage = openFileDialog1.FileName;
                pictureBox1.Image=Image.FromFile(pathImage);
            }
        }

        private void btnConvertiraSVG_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                UtilImage util = new UtilImage();

                string opathImage = saveFileDialog1.FileName;

                util.ConvertirPngASvg(pathImage, opathImage);
            }
            
        }
    }
}
