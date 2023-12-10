

namespace Modul_10;

public partial class Form1 : Form
{
    //tambah list untuk menyimpan semua nama kota, lalu manfaatkan list sbg autofill textbox
    List<string> listKota = new List<string>();

    public Form1()
    {
        InitializeComponent();
        listKota = Ongkir.GetKotaList();

        foreach (string kota in listKota)
        {
            tbAsal.AutoCompleteCustomSource.Add(kota);
            tbAsal.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbAsal.AutoCompleteSource = AutoCompleteSource.CustomSource;

            tbTujuan.AutoCompleteCustomSource.Add(kota);
            tbTujuan.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbTujuan.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }
    }

    private int GetIdKota(string kota)
    {
        int idKota = -1;
        idKota = Ongkir.GetIdKotaList(kota);
        return idKota;
    }

    private void TampilkanDaftar(List<string> daftarLayanan)
    {
        groupBox1.Text = "Detail Layanan";
        foreach (string layanan in daftarLayanan)
        {
            groupBox1.Text += "\n-" + layanan;
        }
    }

    private void btnCek_Click(object sender, EventArgs e)
    {
        string kurir = "";
        if (rbJNE.Checked)
        {
            kurir = "jne";
        }
        else if (rbPOS.Checked)
        {
            kurir = "pos";
        }
        else if (rbTIKI.Checked)
        {
            kurir = "tiki";
        }
        List<string> daftarLayanan = Ongkir.GetLayananList
            (
            GetIdKota(tbAsal.Text),
            GetIdKota(tbTujuan.Text),
            int.Parse(tbBerat.Text),
            kurir
            );

        TampilkanDaftar(daftarLayanan);
    }

    private void Form1_Load(object sender, EventArgs e) { }
}