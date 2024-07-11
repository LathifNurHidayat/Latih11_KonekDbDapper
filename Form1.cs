namespace Latih11_KonekDbDapper
{
    public partial class Form1 : Form
    {

        private readonly NilaiDal _nilaiDal;
        public Form1()
        {
            InitializeComponent();
            _nilaiDal = new NilaiDal();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var datasourche = _nilaiDal.ListNilai();
            dataGridView1.DataSource = datasourche;
        }
    }
}
