using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loans.DTO;
using Loans.BLL;

namespace Loans.UI
{
    public partial class frmNationality : Form
    {
        NationalityDTO oNat = new NationalityDTO();
        NationalityBLL oNatBLL = new NationalityBLL();

        public frmNationality()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            oNat.nationality = txtName.Text;
            try
            {
                oNatBLL.Insert(oNat);
                MessageBox.Show("Nationality Salved with Success ", "Insert Action", MessageBoxButtons.OK);
                LoadData();
                txtName.Text = "";
                txtName.Focus();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Insert Action", MessageBoxButtons.OK);
            }
            
        }

        private void LoadData()
        {
            // gvNat. Columns[0].Width = 10;
            // gvNat.Columns[1].Width = 60;
            gvNat.DataSource = oNatBLL.Fill();
        }

        private void frmNationality_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gvNat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text   = gvNat.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = gvNat.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            oNat.id =  Convert.ToInt16(txtId.Text); 
            oNat.nationality = txtName.Text;
            try
            {
                oNatBLL.Update(oNat);
                MessageBox.Show("Nationality Salved with Success ", "Insert Action", MessageBoxButtons.OK);
                LoadData();
                txtName.Text = "";
                txtName.Focus();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update Action", MessageBoxButtons.OK);
            }

        }
    }
}
