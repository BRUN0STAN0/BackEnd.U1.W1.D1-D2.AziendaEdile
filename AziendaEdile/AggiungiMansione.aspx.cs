using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AziendaEdile
{
    public partial class AggiungiMansione : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button_InsertMansione_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["connessioneDB"].ToString();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("Tipologia", TextBox_Tipologia.Text);
                cmd.Parameters.AddWithValue("Descrizione", TextBox_Descrizione.Text);
                cmd.CommandText = "INSERT INTO Mansione VALUES (@Tipologia, @Descrizione)";
                cmd.Connection = con;
                int row = cmd.ExecuteNonQuery();

                if (row > 0)
                {
                    Label_ERROR.Text = "Inserimento effettuato con successo";
                }
                else
                {
                    Label_ERROR.Text = "Nessuna riga interessata";
                }
            }
            catch (Exception ex)
            {
                Label_ERROR.Text = ex.Message;
            }
        }
    }
}