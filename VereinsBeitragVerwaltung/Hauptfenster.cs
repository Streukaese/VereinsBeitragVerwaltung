using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VereinsBeitragVerwaltung
{
    public partial class Hauptfenster : Form
    {
        public Hauptfenster()
        {
            InitializeComponent();
        }

        Mitglied ausgwaehltesMitglied = null;
        Dictionary<long, Mitglied> mitgliederById = new Dictionary<long, Mitglied>();
        void AddMitglied(Mitglied m)
        {
            mitgliederById[m.Id] = m;

            int index = dataGridViewMitglieder.Rows.Add();
            dataGridViewMitglieder.Rows[index].Cells["ColumnId"].Value = m.Id;
            dataGridViewMitglieder.Rows[index].Cells["ColumnName"].Value = m.Name;  // Erstellt neue Zeile
            dataGridViewMitglieder.Rows[index].Cells["ColumnAge"].Value = m.Age;
            dataGridViewMitglieder.Rows[index].Cells["ColumnBeitrag"].Value = m.Beitrag; //.ToString("0.00") + " €";
        }

        private void Hauptfenster_Load(object sender, EventArgs e)
        {
            //AddMitglied(new Mitglied("Albert", 35.5));
            //AddMitglied(new Mitglied("Bernhardt", 45.5));
            //AddMitglied(new Mitglied("Carola", 25.7));
            Datenbank.Open();
            MySqlCommand cmd = Datenbank.CreateCommand();
            cmd.CommandText = "SELECT id, name, age, beitrag FROM `mitglied`";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                long id = reader.GetInt16(0);
                string name = reader.GetString(1);
                int age = reader.GetInt32(2);
                double beitrag = reader.GetDouble(3);
                //hier etwas mit den Daten machen, z.B. in eine Liste speichern

                AddMitglied(new Mitglied(id, name, age, beitrag));

            }
            reader.Close();

            Datenbank.Close();
        }

        private void buttonHinzufuegen_Click(object sender, EventArgs e)
        {
            //Bearbeitung bearbeiten = new Bearbeitung(null);
            string name = textBoxName.Text;
            //if(bearbeiten.ShowDialog() != DialogResult.OK)
            if(name.Length == 0)
            {
                return;
            }
            int age = (int)numericUpDownAge.Value;
            if(age <= 0)
            {
                numericUpDownAge.Focus();
                return;
            }
            double beitrag = (double)numericUpDownAge.Value;
            if(beitrag < 0.0)
            {
                numericUpDownBeitrag.Focus();
                return;
            }
            long id = 1;
            while(mitgliederById.ContainsKey(id))
            {
                ++id;
            }
            // AddMitglied(new Mitglied(id, name, age, beitrag));

            if (ausgwaehltesMitglied == null)
            {
                Datenbank.Open();
                MySqlCommand command = Datenbank.CreateCommand();
                command.CommandText = "INSERT INTO mitglied (id, name, age, beitrag) VALUES (NULL, @name, @age, @beitrag)";
                command.Parameters.AddWithValue("name", name);
                command.Parameters.AddWithValue("age", age);
                command.Parameters.AddWithValue("beitrag", beitrag);
                command.ExecuteNonQuery();
                long Id = (long)command.LastInsertedId;
                Datenbank.Close();

                AddMitglied(new Mitglied(id, name, age, beitrag));
                // AddMitglied(m);
                // dataGridViewMitglieder.SelectedRows.ToString(m.ToString);
                // dataGridViewMitglieder.Rows.Add(dataGridViewMitglieder.SelectedRows[0]);     // Alternativer ansatz
            }

            textBoxName.Text = "";
            numericUpDownAge.Value = 0;
            numericUpDownBeitrag.Value = 0;
        }

        private void buttonAendern_Click(object sender, EventArgs e)
        {
            long zuAendernId = 32;
            string neueName = "Mega Artikel";
            int neuAge = 5;
            double neuerBeitrag = 35.55;
            MySqlCommand cmd = Datenbank.CreateCommand();
            cmd.CommandText = "update mitglieder set name = @name"
                     + "age = @age"
                     + "beitrag = @beitrag"
                     + " where id = @id";
            cmd.Parameters.AddWithValue("name", neueName);
            cmd.Parameters.AddWithValue("age", neuAge);
            cmd.Parameters.AddWithValue("beitrag", neuerBeitrag);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

        private void buttonEntfernen_Click(object sender, EventArgs e)
        {
            if(dataGridViewMitglieder.SelectedRows.Count != 1)
            {
                return;
            }

            Mitglied m = mitgliederById[dataGridViewMitglieder.SelectedRows.Count];

            Datenbank.Open();
            //int zuLoeschenId = listBoxToDo.SelectedIndex-1;
            MySqlCommand cmd = Datenbank.CreateCommand();
            cmd.CommandText = "delete from mitglied where id=" + m.Id;
            cmd.ExecuteNonQuery();

            Datenbank.Close();

            long id = (long)dataGridViewMitglieder.SelectedRows[0].Cells["ColumnId"].Value;
            dataGridViewMitglieder.Rows.Remove(dataGridViewMitglieder.SelectedRows[0]);
            mitgliederById.Remove(id);

            /*
            int index = dataGridViewMitglieder.;
            if (index < 0 || index >= fluesse.Count)
            {
                listBoxFluesse.Focus();
                return;
            }
            Fluss f = fluesse[index];

            // Fluss aus Datenbank löschen durch auswahl aus der Liste
            Datenbank.Open();

            // int zuLoeschenId = 32; // Wird nicht gebraucht weil id ausgewählt wird -> f.id
            MySqlCommand cmd = Datenbank.CreateCommand();
            cmd.CommandText = "delete from Fluss where id=" + f.id;
            cmd.ExecuteNonQuery();

            Datenbank.Close();
            // Fluss aus der Liste löschen (Grafisch)
            listBoxFluesse.Items.RemoveAt(index);
            // Fluss wird aus dem Speicher gelöscht
            fluesse.RemoveAt(index);
            */
        }

        private void dataGridViewMitglieder_DoubleClick(object sender, EventArgs e)
        {
            if(dataGridViewMitglieder.SelectedRows.Count!=1)
            {
                return;
            }
            int index = dataGridViewMitglieder.SelectedRows[0].Index;
            //MessageBox.Show("Bearbeiten von " +mitglieder[index]);

        }
    }
}
