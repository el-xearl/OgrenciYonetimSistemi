namespace OgrenciYonetimSistemi
{
    public partial class Form1 : Form
    {
        //Dinamik Öðrenci Listesi
        List<Ogrenci> ogrenciListesi = new List<Ogrenci>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //form acýldýgýnda calýsacak baslangýc kodlarý buradadýr.
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Ekle Butonuna basýnca çalýþýr
        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Textboxlardan veri al
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            int numara = Convert.ToInt32(txtNumara.Text);
            double ort = Convert.ToDouble(txtNumara.Text);
            //Yeni Öðrenci Listesi Oluþtur
            Ogrenci yeni = new Ogrenci(ad, soyad, numara, ort);
            //Listeye ekle
            ogrenciListesi.Add(yeni);
            //DataGridview Güncelle
            ListeYenile();
            //FormAlanlarýný Temizle
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int index = dataGridView1.CurrentRow.Index;

                //Listeden Çýkar 
                ogrenciListesi.RemoveAt(index);
                //DataGridview Güncelle 
                ListeYenile();
            } 
        }
        //DataGridview Güncelle Methodu
        private void ListeYenile()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ogrenciListesi;

        }
        //Form Alanlarýný Düzenle
        private void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtNumara.Clear();
            txtOrta.Clear();
        }
    }
}
