using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ders9_AddDeleteUpdate_Listeng_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

               
        MySqlConnection con = new MySqlConnection("Server=Localhost;Database=Ders9;Charset=utf8;Uid=root;Pwd=''");


        private void Form1_Load(object sender, EventArgs e)
        {
            list_products();   
        

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO products(ProductName, ProductPrice, ProductDescription) VALUES(@ProductName,@ProductPrice,@ProductDescription)", con);
                cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                cmd.Parameters.AddWithValue("@ProductPrice", txtProductPrice.Text);
                cmd.Parameters.AddWithValue("@ProductDescription", txtProductDescription.Text);

                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Ürün başarıyla eklendi", "Ders9", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtProductName.ResetText();
                    txtProductPrice.ResetText();
                    txtProductDescription.ResetText();

                    lwProducts.Items.Clear();
                    list_products();
                }
                else 
                {
                    MessageBox.Show("Ürün eklenirken hata oluştu", "Ders9", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                 con.Close();
                            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
        private void list_products()
        {
            
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM products", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem Item = new ListViewItem();
                    Item.Text = reader["ID"].ToString();
                    Item.SubItems.Add(reader["ProductName"].ToString());
                    Item.SubItems.Add(reader["ProductPrice"].ToString());
                    Item.SubItems.Add(reader["ProductDescription"].ToString());
                    lwProducts.Items.Add(Item);
                }
                
                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lwProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lwProducts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int p_id = int.Parse(lwProducts.SelectedItems[0].SubItems[0].Text);
            // Aslında aşağıdaki gibi de olur
            // txtID.Text = lwProducts.SelectedItems[0].SubItems[0].Text;
            //
            txtID.Text = Convert.ToString(p_id);
            txtProductName.Text = lwProducts.SelectedItems[0].SubItems[1].Text;
            txtProductPrice.Text = lwProducts.SelectedItems[0].SubItems[2].Text;
            txtProductDescription.Text = lwProducts.SelectedItems[0].SubItems[3].Text;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE products SET ProductName=@PN, ProductPrice=@PP, ProductDescription=@PD where ID=@id", con);
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.Parameters.AddWithValue("@PN", txtProductName.Text);
                cmd.Parameters.AddWithValue("@PP", txtProductPrice.Text);
                cmd.Parameters.AddWithValue("@PD", txtProductDescription.Text);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Ürün başarıyla güncellendi", "Ders9", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.ResetText();
                    txtProductName.ResetText();
                    txtProductPrice.ResetText();
                    txtProductDescription.ResetText();

                    lwProducts.Items.Clear();
                    list_products();
                }
                else
                {
                    MessageBox.Show("Ürün güncellenirken hata oluştu", "Ders9", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM products WHERE ID = @id", con);
                cmd.Parameters.AddWithValue("@id", txtID.Text);

                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Ürün başarıyla Silindi", "Ders9", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.ResetText();
                    txtProductName.ResetText();
                    txtProductPrice.ResetText();
                    txtProductDescription.ResetText();

                    lwProducts.Items.Clear();
                    list_products();
                }
                else
                {
                    MessageBox.Show("Ürün silinirken hata oluştu", "Ders9", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
