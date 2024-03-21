namespace Composite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Composite<Category> categories = new Composite<Category>();
            var bilgisayar = categories.Add(new Category("Bilgisayar"));
            var laptop = bilgisayar.Add(new Category("Laptop"));
            var dell = laptop.Add(new Category("Dell"));
            var evSinemaSistemi = categories.Add(new Category("Ev sinema sistemi"));
            var sesSistemi = evSinemaSistemi.Add(new Category("5+1 Bluetooth"));

            Composite<Category>.Show(1, categories, treeViewCategories);

        }
    }
}
