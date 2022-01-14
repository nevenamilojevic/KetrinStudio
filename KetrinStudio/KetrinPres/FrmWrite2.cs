using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetrinPres
{
    public partial class FrmWrite2 : Form
    {
        readonly KlijentBusiness klijentBusiness = new KlijentBusiness();
        readonly FrizerBusiness frizerBusiness = new FrizerBusiness();
        readonly VrsteBusiness vrsteBusiness = new VrsteBusiness();
        public FrmWrite2()
        {
            InitializeComponent();
        }
        private void FrmWrite2_Load(object sender, EventArgs e)
        {
            RefreshList();
        }
        private void RefreshList()
        {
            comboBoxFrizer.Items.Clear();
            foreach (Frizeri frizer in frizerBusiness.GetAllFrizeri())
            {
                comboBoxFrizer.Items.Add($"{frizer.ImeF} {frizer.PrezimeF} {frizer.BrojTelefonaF} ");
            }
            comboBoxTretman.Items.Clear();
            foreach(Vrste vrste in vrsteBusiness.GetAllVrste())
            {
                comboBoxTretman.Items.Add($"{vrste.Naziv} {vrste.Cena} dinara");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmClose2 frmClose = new FrmClose2();
            frmClose.Show();
            this.Hide();

            Klijenti k = new Klijenti()
            {
                ImeK = textBoxIme.Text,
                PrezimeK = textBoxPrezime.Text,
                BrojTelefonaK = textBoxBroj.Text,
                Email = textBoxEmail.Text,
                DatumTretaman = dateTimePicker1.Value

            };

            klijentBusiness.InsertKlijent(k);
        }

       
    }
}
