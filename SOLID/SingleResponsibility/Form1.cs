namespace SingleResponsibility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * Bir sınıfta değişiklik yapmak için genel olarak birden fazla sebebim (bahanem) varsa prensibe uymadığım anlamına gelir.
         * 
         * Türkay der ki Form1 bir insan olsaydı, sorumluluğunu nasıl açıklardı.
         *   - Ben, kullanıcın girdiği verileri alır ve arka tarafta bu verileri kullanarak çalışan nesnelere paslarım.
         *   - Ya da arka plandan gelen verileri kullanıcıya gösteririm.
         *   - Kullanıcının uygulamayla etkileşime girdiği olayları yöneten bir nesneyim.
         * 
         */

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxProductName.Text;
            decimal price = decimal.Parse(textBoxPrice.Text);

            ProductService productService = new ProductService();
            productService.CreateProduct(name, price);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog.Color;
            }
        }
    }
}
