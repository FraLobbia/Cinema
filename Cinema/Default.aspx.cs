using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cinema
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CompraBiglietto(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionStringDb"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                // questa stringa genererà un errore in quanto IdCustomer non esiste!
               // cmd.CommandText = "UPDATE Customers SET CompanyName=@CompanyName, City=@City WHERE IdCustomer=@id";


                cmd.CommandText = "INSERT INTO Prenotazioni VALUES (@SurnameField, @NameField, @SceltaSala, @Ridotto, '2024-02-14')";




                //cmd.CommandText = "UPDATE Customers SET CompanyName=@CompanyName, City=@City WHERE CustomerId=@id";

                cmd.Parameters.AddWithValue("NameField", NameField.Text);
                cmd.Parameters.AddWithValue("SurnameField", SurnameField.Text);
                cmd.Parameters.AddWithValue("SceltaSala", SceltaSala.value);
                cmd.Parameters.AddWithValue("Ridotto", RidottoCheckbox.Checked);
                //cmd.Parameters.AddWithValue("Data", new DateTime.Now);

                cmd.ExecuteNonQuery();

                //Response.Redirect("Dettaglio?idCliente=" + IdCustomer.Text);
            }
            catch (Exception ex)
            {

                Response.Write("Errore");
                Response.Write(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
    }
}