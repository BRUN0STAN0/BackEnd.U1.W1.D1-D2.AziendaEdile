using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace AziendaEdile
{
    public partial class DettaglioPagamenti : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // POPOLARE IL REPEATER DI DIPENDENTI
                Dipendente.Dipendenti.Clear();
                Pagamento.Pagamenti.Clear();
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["connessioneDB"].ToString();
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("ID_Dipendente", Request.QueryString["ID"]);
                    cmd.CommandText = "SELECT Dipendente.ID_Dipendente, Nome, Cognome, ID_Pagamento, Periodo, Ammontare, Acconto " +
                                        "FROM Dipendente JOIN Pagamento " +
                                        "ON Dipendente.ID_Dipendente = Pagamento.ID_Dipendente " +
                                        "WHERE Dipendente.ID_Dipendente = @ID_Dipendente";
                    cmd.Connection = con;
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Label_Nome.Text = reader["Nome"].ToString();
                            Label_Cognome.Text = reader["Cognome"].ToString();
                            Pagamento p = new Pagamento();
                            p.ID_Pagamento = Convert.ToInt32(reader["ID_Pagamento"]);
                            p.Acconto = Convert.ToBoolean(reader["Acconto"]);
                            p.Periodo = Convert.ToDateTime(reader["Periodo"]);
                            p.Ammontare = Convert.ToDecimal(reader["Ammontare"]);
                            Pagamento.Pagamenti.Add(p);
                        }

                        GridView_Pagamenti.DataSource = Pagamento.Pagamenti;
                        GridView_Pagamenti.DataBind();

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