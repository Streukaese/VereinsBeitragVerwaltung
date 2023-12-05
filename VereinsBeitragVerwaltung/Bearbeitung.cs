using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VereinsBeitragVerwaltung
{
    public partial class Bearbeitung : Form
    {
        public Mitglied MitgliedInBearbeitung { get; set; }
        public Bearbeitung(Mitglied mitglied)
        {
            MitgliedInBearbeitung = mitglied;
            InitializeComponent();
            if(mitglied != null )
            {
                textBoxName.Text = mitglied.Name;
                numericUpDownAge.Value = mitglied.Age;  
                numericUpDownBeitrag.Value = (decimal)mitglied.Beitrag;
            }
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)    // Speichern
        {
            string name = textBoxName.Text;
            if( name.Length == 0)
            {
                textBoxName.Focus();
                return;
            }
            decimal age = (int) numericUpDownAge.Value;
            if (age == 0)
            {
                numericUpDownAge.Focus();
                return;
            }
            double beitrag = (double) numericUpDownBeitrag.Value;
            if (beitrag == 0.0)
            {
                numericUpDownBeitrag.Focus();
                return;
            }
            if (MitgliedInBearbeitung == null)
            {
                Datenbank.Open();
                //long zuAendernId = 32;
                string neueName = "Mega Artikel";
                int neuAge = 5;
                double neuerBeitrag = 35.55;
                MySqlCommand cmd = Datenbank.CreateCommand();
                cmd.CommandText = "INSERT INTO mitglied (id, name, age, beitrag) VALUES (NULL, @name, @age, @beitrag)"; //FIXME insert
                cmd.Parameters.AddWithValue("name", neueName);
                cmd.Parameters.AddWithValue("age", neuAge);
                cmd.Parameters.AddWithValue("beitrag", neuerBeitrag);
                cmd.Prepare();
                cmd.ExecuteNonQuery();

                Datenbank.Close();

                // TODO ordentlich in die DB speichern und dabei die ID bekommen
                //Mitglied m = new Mitglied(id, name, (int)age, beitrag);
                //mitglied.Add(m);
                //mitglied.Items.Add(m.ToString());
                //VereinsBeitragVerwaltung.Hauptfenster.dataGridViewMitglieder.SelectedRows[0].Value = mitglied.Name;
                //dataGridViewMitglieder.SelectedCells[1].Value = mitglied.Age;
                //dataGridViewMitglieder.SelectedCells[2].Value = m.Beitrag;
            }
            else
            {
                // Update
                Datenbank.Open();
                MySqlCommand command = Datenbank.CreateCommand();
                command.CommandText = "UPDATE `mitglied` SET `name` = @name, `age` = @age, `beitrag` = @beitrag WHERE `mitglied`.`id` = @id";
                command.Parameters.AddWithValue("name", name);
                command.Parameters.AddWithValue("age", age);
                command.Parameters.AddWithValue("beitrag", beitrag);
                command.Parameters.AddWithValue("id", MitgliedInBearbeitung.Id);
                command.Prepare();
                command.ExecuteNonQuery();
                Datenbank.Close();

                MitgliedInBearbeitung.Name = name;
                MitgliedInBearbeitung.Age = (int)age;
                MitgliedInBearbeitung.Beitrag = beitrag;
            }

            //textBoxName.Text = "";
            //numericUpDownAge.Value = 0;
            //numericUpDownBeitrag.Value = 0;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
