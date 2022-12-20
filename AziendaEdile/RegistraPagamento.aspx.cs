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
    public partial class RegistraPagamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton_CercaDipendente_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["connessioneDB"].ToString();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("CERCA", TextBox_CercaDipendente.Text);
                cmd.CommandText = "SELECT * FROM Dipendente WHERE Nome = @CERCA OR Cognome = @CERCA";
                cmd.Connection = con;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    DropDownList_Dipendente.Items.Clear();
                    while (reader.Read())
                    {
                        ListItem li = new ListItem();
                        li.Text = reader["Nome"].ToString() + " " + reader["Cognome"].ToString();
                        li.Value = reader["ID_Dipendente"].ToString();
                        DropDownList_Dipendente.Items.Add(li);
                    }
                }
            }
            catch (Exception ex)
            {
                Label_ERROR.Text = ex.Message;
            }
        }

        protected void Button_RegistraPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["connessioneDB"].ToString();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("Periodo", TextBox_Periodo.Text);
                cmd.Parameters.AddWithValue("Ammontare", TextBox_Ammontare.Text);
                cmd.Parameters.AddWithValue("Acconto", CheckBox_Acconto.Checked);
                cmd.Parameters.AddWithValue("ID_Dipendente", DropDownList_Dipendente.SelectedItem.Value);
                cmd.CommandText = "INSERT INTO Pagamento VALUES (@Periodo, @Ammontare, @Acconto, @ID_Dipendente)";
                cmd.Connection = con;
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    Label_ERROR.Text = "Inserimento effettuato con successo.";
                } else
                {
                    Label_ERROR.Text = "Nessuna riga interessata.";
                }
            }
            catch (Exception ex)
            {
                Label_ERROR.Text = ex.Message;
            }
        }
    }
}