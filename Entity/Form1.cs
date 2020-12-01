using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            loadProduct();
        }

        private void loadProduct()
        {
            dgwProduct.DataSource = _productDal.GetAll();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            _productDal.Ekle(new Product
            {
                Name = txtNameE.Text,
                UnitPrice = Convert.ToDecimal(txtFiyatE.Text),
                Stock = Convert.ToInt32(txtStokE.Text)

            });
            txtStokE.Clear();
            txtFiyatE.Clear();
            txtNameE.Clear();
            loadProduct();
            MessageBox.Show("Ürün başarıyla eklendi.");

        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNameG.Text = dgwProduct.CurrentRow.Cells[1].Value.ToString();
            txtFiyatG.Text = dgwProduct.CurrentRow.Cells[2].Value.ToString();
            txtStokG.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _productDal.Guncelle(new Product
            {
                Id = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                Name = txtNameG.Text,
                UnitPrice = Convert.ToDecimal(txtFiyatG.Text),
                Stock = Convert.ToInt32(txtStokG.Text)
            });
            txtStokG.Clear();
            txtFiyatG.Clear();
            txtNameG.Clear();
            loadProduct();
            MessageBox.Show("Ürün başarıyla güncellendi.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            txtStokG.Clear();
            txtFiyatG.Clear();
            txtNameG.Clear();
            _productDal.Sil(new Product
            {
                Id = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
            });
            loadProduct();
            MessageBox.Show("Ürün başarıyla silindi.");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var result = _productDal.GetByName(txtSearch.Text);
            dgwProduct.DataSource = result;
               
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            var result = _productDal.ikiFiyatGetir(Convert.ToDecimal(txtMin.Text), Convert.ToDecimal(txtMax.Text));
            dgwProduct.DataSource = result;
        }
    }
}
