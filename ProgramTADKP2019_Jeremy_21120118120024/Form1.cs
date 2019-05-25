using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramTADKP2019_Jeremy_21120118120024
{
    public partial class Myprogram : Form
    {
        private void hapus()
        {
            comboBox1.Text = (" ");
            textBox1.Text = (" ");
        }
        class data
        {

            private string Nama;
            private string Tanggal;
            private string Tempat;
            private string Pendidikan;
            private string Penemu;

            public void setNama(string val)
            {
                this.Nama = val;
            }
            public string getNama()
            {
                return Nama;
            }
            public void setTanggal(string val)
            {
                this.Tanggal = val;
            }
            public string getTanggal()
            {
                return Tanggal;
            }
            public void setTempat(string val)
            {
                this.Tempat = val;
            }
            public string getTempat()
            {
                return Tempat;
            }
            public void setPendidikan(string val)
            {
                this.Pendidikan = val;
            }
            public string getPendidikan()
            {
                return Pendidikan;
            }
            public void setPenemu(string val)
            {
                this.Penemu = val;
            }
            public string getPenemu()
            {
                return Penemu;
            }
        }

        public Myprogram()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            MaximizeBox = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                data andy = new data();
                andy.setNama("Andy Rubin");
                andy.setTanggal("22 Juni 1946");
                andy.setTempat("New Bedford, Amerika Serikat");
                andy.setPendidikan(System.Environment.NewLine + "Utica College, Utica, New York, Bachelor of Science dalam ilmu komputer, 1981 - 1986");
                andy.setPenemu("Android");
                textBox1.Text = "Nama Lengkap :" + andy.getNama() + System.Environment.NewLine
                + "Tanggal Lahir :" + andy.getTanggal() + System.Environment.NewLine
                + "Tempat Lahir :" + andy.getTempat() + System.Environment.NewLine
                + "Pendidikan Usai SMA :" + andy.getPendidikan() + System.Environment.NewLine
                + "Penemu OS " + andy.getPenemu();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                data bill = new data();
                bill.setNama("William Henry (Bill) Gates III");
                bill.setTanggal("28 Oktober 1955");
                bill.setTempat("Seattle, Washington, Amerika Serikat");
                bill.setPendidikan(System.Environment.NewLine + "Harvard University mulai tahun 1975");
                bill.setPenemu("Microsoft Windows");
                textBox1.Text = "Nama Lengkap :" + bill.getNama() + System.Environment.NewLine
                + "Tanggal Lahir :" + bill.getTanggal() + System.Environment.NewLine
                + "Tempat Lahir :" + bill.getTempat() + System.Environment.NewLine
                + "Pendidikan Usai SMA :" + bill.getPendidikan() + System.Environment.NewLine
                + "Penemu OS " + bill.getPenemu();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                data larry = new data();
                larry.setNama("Lawrence Edward (Larry) Page");
                larry.setTanggal("26 Maret 1973");
                larry.setTempat("Lansing, Michigan, Amerika Serikat");
                larry.setPendidikan(System.Environment.NewLine + "S1 - Universitas Michigan" + System.Environment.NewLine + "S2 - Universitas Stanford");
                larry.setPenemu("Mesin Pencari Google bersama Sergey Brin");
                textBox1.Text = "Nama Lengkap :" + larry.getNama() + System.Environment.NewLine
                + "Tanggal Lahir :" + larry.getTanggal() + System.Environment.NewLine
                + "Tempat Lahir :" + larry.getTempat() + System.Environment.NewLine
                + "Pendidikan Usai SMA :" + larry.getPendidikan() + System.Environment.NewLine
                + "Penemu " + larry.getPenemu();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                textBox1.Text = ("Error Gan");
                
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hapus();
        }
    }
}

