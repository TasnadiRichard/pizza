namespace pizza
{
    public partial class Form1_pizzarendel�s : Form
    {
        public Form1_pizzarendel�s()
        {
            InitializeComponent();
        }

        private void Form1_pizzarendel�s_Load(object sender, EventArgs e)
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
            openFileDialog.Filter = "Vessz�vel tagolt CSV |*.csv|Sz�veges f�jl (*.txt)|*.txt|�sszes f�jl (*.*)|*.*";
            openFileDialog.FilterIndex = 0;
            openFileDialog.Title = "Adatf�jl neve";
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.FileName = "pizza.csv";

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Be�ll�tjuk a bet�lt�tt f�jl nev�t a textBox_forrasfajlneve-be
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
