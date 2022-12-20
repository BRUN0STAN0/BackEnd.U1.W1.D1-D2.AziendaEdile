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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // POPOLARE IL REPEATER DI DIPENDENTI
                Dipendente.Dipendenti.Clear();
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["connessioneDB"].ToString();
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM Dipendente JOIN Mansione ON Dipendente.ID_Mansione = Mansione.ID_Mansione";
                    cmd.Connection = con;
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Dipendente d = new Dipendente();
                            d.ID_Dipendente = Convert.ToInt32(reader["ID_Dipendente"]);
                            d.Nome = reader["Nome"].ToString();
                            d.Cognome = reader["Cognome"].ToString();
                            d.Indirizzo = reader["Indirizzo"].ToString();
                            d.Coniugato = Convert.ToBoolean(reader["Coniugato"]);
                            d.CodiceFiscale = reader["CodiceFiscale"].ToString();
                            d.NumeroFigliACarico = Convert.ToInt32(reader["NumeroFigliACarico"]);
                            d.Mansione = reader["Tipologia"].ToString();
                            Dipendente.Dipendenti.Add(d);
                        }
                        Repeater_Dipendente.DataSource = Dipendente.Dipendenti;
                        Repeater_Dipendente.DataBind();
                    }
                }
                catch (Exception ex)
                {
                    Label_ERROR.Text = ex.Message;
                }
            }
        }
    }
}