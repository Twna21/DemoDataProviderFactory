using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductWinApp
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private string GetConnectionString()
        {

            IConfiguration config = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", true, true)
                          .Build();
            var strConnection = config["ConnectionStrings:MyStoreDB"];
            return strConnection;


        }



        private void frmProduct_Load(object sender, EventArgs e)
        {
            DbProviderFactory factory = SqlClientFactory.Instance;

            using DbConnection connection = factory.CreateConnection();

            if (connection == null)
            {
                Console.WriteLine($"Unable to create the connection object.");
                return;
            }


            connection.ConnectionString = GetConnectionString();
            connection.Open();
            string sql = "select ProductID, Name from Products; select * from categories;";
            try
            {


                SqlDataAdapter adapter = new SqlDataAdapter(sql, GetConnectionString());
                adapter.Fill(dsMyStore);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Data from Database");
            }
        }
        DataSet dsMyStore = new DataSet();
        private void btnViewCategories_TextChanged(object sender, EventArgs e)
        {
            dgvList.DataSource = dsMyStore.Tables[1];
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            dgvList.DataSource = dsMyStore.Tables[0];
        }

        private void btnViewCategories_Click(object sender, EventArgs e)
        {
            dgvList.DataSource = dsMyStore.Tables[1];
        }


    }
}
