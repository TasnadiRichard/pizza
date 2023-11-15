namespace pizza
{
    public partial class Form1_pizzarendelés : Form
    {
        public Form1_pizzarendelés()
        {
            InitializeComponent();
        }

        private void Form1_pizzarendelés_Load(object sender, EventArgs e)
        {
            string kiindulasiFajl = Environment.CommandLine;
            if (File.Exists(kiindulasiFajl))
            {
                Adatbetoltes();
            }
        }

        private void Adatbetoltes()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Vesszõvel tagolt CSV |*.csv|Szöveges fájl (*.txt)|*.txt|Összes fájl (*.*)|*.*";
            openFileDialog.FilterIndex = 0;
            openFileDialog.Title = "Adatfájl neve";
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.FileName = "pizza.csv";

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Beállítjuk a betöltött fájl nevét a textBox_forrasfajlneve-be
                textBox_forrasfajlneve.Text = Path.GetFileName(openFileDialog.FileName);

                using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        listBox_pizzak.Items.Add(new pizza(sr.ReadLine()));
                    }
                }
            }
        }
    }
}
