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
    public partial class ArchiviaDipendente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                // POPOLARE LA DROPDOWNLIST Della mansione
                try 
                { 
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["connessioneDB"].ToString();
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM Mansione";
                    cmd.Connection = con;
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read()) 
                        { 
                            ListItem li = new ListItem();
                            li.Text = reader["Tipologia"].ToString();
                            li.Value = reader["ID_Mansione"].ToString();
                            Mansione m = new Mansione();
                            m.ID_Mansione = Convert.ToInt32(reader["ID_Mansione"]);
                            m.Tipologia = reader["Tipologia"].ToString();
                            DropDownList_Mansione.Items.Add(li);
                        }
                    }
                }
                catch (Exception ex) 
                {
                    Label_ERROR.Text = ex.Message; 
                }
            }
        }

        protected void Button_InsertDipendente_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["connessioneDB"].ToString();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("Nome", TextBox_Nome.Text);
                cmd.Parameters.AddWithValue("Cognome", TextBox_Cognome.Text);
                cmd.Parameters.AddWithValue("Indirizzo", TextBox_Indirizzo.Text);
                cmd.Parameters.AddWithValue("CodiceFiscale", TextBox_CodiceFiscale.Text);
                cmd.Parameters.AddWithValue("Coniugato", CheckBox_Coniugato.Checked);
                cmd.Parameters.AddWithValue("NumeroFigliACarico", TextBox_NumeroFigliACarico.Text);
                cmd.Parameters.AddWithValue("ID_Mansione", DropDownList_Mansione.SelectedItem.Value);
                cmd.CommandText = "INSERT INTO Dipendente VALUES (@Nome, @Cognome, @Indirizzo, @CodiceFiscale, @Coniugato, @NumeroFigliACarico, @ID_Mansione)"; 
                cmd.Connection = con;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListItem li = new ListItem();
                        li.Text = reader["Tipologia"].ToString();
                        li.Value = reader["ID_Mansione"].ToString();
                        DropDownList_Mansione.Items.Add(li);
                    }
                } 
            }
            catch (Exception ex)
            {
                Label_ERROR.Text = ex.Message;
            }
        }
    }
}