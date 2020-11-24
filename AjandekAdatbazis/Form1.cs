using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AjandekAdatbazis
{
    public partial class AjandekListaForm : Form
    {
        MySqlConnection conn;

        public AjandekListaForm()
        {
            InitializeComponent();

            conn = new MySqlConnection("Server=localhost; Database=ajandek; Uid=root; Pwd=;");
            conn.Open();

            this.FormClosed += (sender, args) => {
                if (conn != null)
                {
                    conn.Close();
                }
            };

            AdatBetoltes();
        }

        void AdatBetoltes()
        {
            string sql = @"SELECT id, nev, uzlet FROM ajandek ORDER BY nev";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            using (var reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string nev = reader.GetString("nev");

                    string uzlet;
                    try
                    {
                        uzlet = reader.GetString("uzlet");
                    }
                    catch (SqlNullValueException ex)
                    {
                        uzlet = null;
                    }
                    var ajandek = new Ajandek(id, nev, uzlet);
                    ajandekListBox.Items.Add(ajandek);
                }
            }
        }

        private void Btn_AjandekHozzaadas_Click(object sender, EventArgs e)
        {
            if(Btn_AjandekHozzaadas.Text == "Ajándék hozzáadása")
            {
                try
                {
                    string ajandekNev = TxtBox_AjandekNev.Text;
                    string ajandekUzlet;
                    if (TxtBox_AjandekUzlet.ForeColor == Color.Gray)
                    {
                        ajandekUzlet = null;
                    }
                    else
                    {
                        ajandekUzlet = TxtBox_AjandekUzlet.Text;
                    }
                    string sql = "INSERT INTO ajandek.ajandek(nev,uzlet) VALUES('" + ajandekNev + "','" + ajandekUzlet + "');";
                    MySqlDataReader reader;
                    reader = new MySqlCommand(sql, conn).ExecuteReader();
                    while (reader.Read())
                    {
                    }
                    reader.Close();
                    ajandekListBox.Items.Clear();
                    AdatBetoltes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                try
                {
                    string ajandekNev = TxtBox_AjandekNev.Text;
                    string ajandekUzlet;
                    int ajandekID = ((Ajandek)ajandekListBox.SelectedItem).Id;
                    if (TxtBox_AjandekUzlet.ForeColor == Color.Gray)
                    {
                        ajandekUzlet = null;
                    }
                    else
                    {
                        ajandekUzlet = TxtBox_AjandekUzlet.Text;
                    }
                    string sql = "UPDATE ajandek SET nev='" + ajandekNev + "', uzlet='" + ajandekUzlet + "' WHERE id = " + ajandekID + ";";
                    MySqlDataReader reader;
                    reader = new MySqlCommand(sql, conn).ExecuteReader();
                    while (reader.Read())
                    {
                    }
                    reader.Close();
                    ajandekListBox.Items.Clear();
                    AdatBetoltes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            TxtBox_AjandekNev.Text = "Ajándék neve";
            TxtBox_AjandekNev.ForeColor = Color.Gray;
            TxtBox_AjandekUzlet.Text = "Üzlet neve";
            TxtBox_AjandekUzlet.ForeColor = Color.Gray;
        }

        private void TxtBox_AjandekNev_FocusEnter(object sender, EventArgs e)
        {
            if(TxtBox_AjandekNev.Text == "Ajándék neve" && TxtBox_AjandekNev.ForeColor == Color.Gray)
            {
                TxtBox_AjandekNev.Text = "";
                TxtBox_AjandekNev.ForeColor = Color.Black;
            }

            if((TxtBox_AjandekNev.Text == "" || TxtBox_AjandekNev.ForeColor == Color.Gray) && (TxtBox_AjandekUzlet.Text == "" || TxtBox_AjandekUzlet.ForeColor == Color.Gray))
            {
                Btn_AjandekHozzaadas.Text = "Ajándék hozzáadása";
            }
        }

        private void TxtBox_AjandekNev_FocusLeave(object sender, EventArgs e)
        {
            if (TxtBox_AjandekNev.Text == "" && TxtBox_AjandekNev.ForeColor == Color.Black)
            {
                TxtBox_AjandekNev.Text = "Ajándék neve";
                TxtBox_AjandekNev.ForeColor = Color.Gray;
            }

            if ((TxtBox_AjandekNev.Text == "" || TxtBox_AjandekNev.ForeColor == Color.Gray) && (TxtBox_AjandekUzlet.Text == "" || TxtBox_AjandekUzlet.ForeColor == Color.Gray))
            {
                Btn_AjandekHozzaadas.Text = "Ajándék hozzáadása";
            }
        }

        private void TxtBox_AjandekUzlet_FocusEnter(object sender, EventArgs e)
        {
            if ((TxtBox_AjandekUzlet.Text == "Üzlet neve" || TxtBox_AjandekUzlet.Text == "Saját készítésű") && TxtBox_AjandekUzlet.ForeColor == Color.Gray)
            {
                TxtBox_AjandekUzlet.Text = "";
                TxtBox_AjandekUzlet.ForeColor = Color.Black;
            }

            if ((TxtBox_AjandekNev.Text == "" || TxtBox_AjandekNev.ForeColor == Color.Gray) && (TxtBox_AjandekUzlet.Text == "" || TxtBox_AjandekUzlet.ForeColor == Color.Gray))
            {
                Btn_AjandekHozzaadas.Text = "Ajándék hozzáadása";
            }
        }

        private void TxtBox_AjandekUzlet_FocusLeave(object sender, EventArgs e)
        {
            if (TxtBox_AjandekUzlet.Text == "" && TxtBox_AjandekUzlet.ForeColor == Color.Black)
            {
                TxtBox_AjandekUzlet.Text = "Üzlet neve";
                TxtBox_AjandekUzlet.ForeColor = Color.Gray;
            }

            if ((TxtBox_AjandekNev.Text == "" || TxtBox_AjandekNev.ForeColor == Color.Gray) && (TxtBox_AjandekUzlet.Text == "" || TxtBox_AjandekUzlet.ForeColor == Color.Gray))
            {
                Btn_AjandekHozzaadas.Text = "Ajándék hozzáadása";
            }
        }

        private void ajandekListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ajandek ajandek = (Ajandek)ajandekListBox.SelectedItem;
            TxtBox_AjandekNev.Text = ajandek.Nev;
            TxtBox_AjandekNev.ForeColor = Color.Black;
            if(ajandek.Uzlet == "")
            {
                TxtBox_AjandekUzlet.Text = "Saját készítésű";
                TxtBox_AjandekUzlet.ForeColor = Color.Gray;
            } else
            {
                TxtBox_AjandekUzlet.Text = ajandek.Uzlet;
                TxtBox_AjandekUzlet.ForeColor = Color.Black;
            }

            LBL_AjandekID.Text = "ID: ";
            LBL_AjandekNev.Text = "Név: ";
            LBL_AjandekUzlet.Text = "Üzlet neve: ";
            LBL_AjandekID.Text += ajandek.Id.ToString();
            LBL_AjandekNev.Text += ajandek.Nev;
            if(ajandek.Uzlet == "")
            {
                LBL_AjandekUzlet.Text += "Saját készítésű";
            } else
            {
                LBL_AjandekUzlet.Text += ajandek.Uzlet;
            }
            Btn_AjandekHozzaadas.Text = "Ajándék módosítása";

            if(ajandekListBox.SelectedIndex != -1)
            {
                Btn_AjandekTorlese.Enabled = true;
            }
        }

        private void Btn_AjandekTorlese_Click(object sender, EventArgs e)
        {
            Ajandek ajandek = (Ajandek)ajandekListBox.SelectedItem;

            try
            {
                string sql = "DELETE FROM ajandek WHERE id = '" + ajandek.Id + "';";
                MySqlDataReader reader;
                reader = new MySqlCommand(sql, conn).ExecuteReader();
                while (reader.Read())
                {
                }
                reader.Close();
                ajandekListBox.Items.Clear();
                AdatBetoltes();
                ajandekListBox.SelectedIndex = -1;
                TxtBox_AjandekNev.Text = "Ajándék neve";
                TxtBox_AjandekNev.ForeColor = Color.Gray;
                TxtBox_AjandekUzlet.Text = "Üzlet neve";
                TxtBox_AjandekUzlet.ForeColor = Color.Gray;

                LBL_AjandekID.Text = "ID: ";
                LBL_AjandekNev.Text = "Név: ";
                LBL_AjandekUzlet.Text = "Üzlet neve: ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
