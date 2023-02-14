using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using DemoThuctap.DAO;
using DemoThuctap.DTO;
using System.Data;

namespace DemoThuctap
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadDb();
        }

        protected void btnGetValue_Click(object sender, EventArgs e)
        {
            lblValue.Text = txtValue.Text.Trim()+" "+ DateTime.UtcNow.ToLongTimeString();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (!txtName.Text.Equals("") && lblId.Text.Equals(""))
            {
                DAOProduct DaoProduct = new DAOProduct();
                DaoProduct.Add(txtName.Text.Trim());
                ResetValues();
                LoadDb();             
            }
            
        }
        void LoadDb()
        {
            DataTable dtProduct = new DataTable();
            DAOProduct DaoProduct = new DAOProduct();
            dtProduct= DaoProduct.LoadDB();
            gvProduct.DataSource = dtProduct;
            gvProduct.DataBind();
        }
        protected void gvProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblId.Text = gvProduct.SelectedRow.Cells[0].Text.ToString();
            txtName.Text = gvProduct.SelectedRow.Cells[1].Text.ToString();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!lblId.Text.Equals("")){
                Product a = new Product(lblId.Text.Trim(), txtName.Text.Trim());
                DAOProduct DaoProduct = new DAOProduct();
                DaoProduct.Update(a);
                ResetValues();
                LoadDb();
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (!lblId.Text.Equals(""))
            {
                DAOProduct DaoProduct = new DAOProduct();
                DaoProduct.Delete(lblId.Text.Trim());
                ResetValues();
                LoadDb();
            }
        }
        void ResetValues()
        {
            txtName.Text = "";
            lblId.Text = "";
        }
    }
}