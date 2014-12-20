// Konvertierungsprojekt
// Anwendung: BitratenRechner.NET v2.00
// Sprache:   VB.Net > C#
// Status: 100% + kleine Extras^^
//
// Was ist neu zur VB.NET Version?
// Einfärbung der Ausgabebox (ComboBox3) + Anpassung ihrer Titelleiste je nach Modus
//
//
// Schwierigkeiten beim Konvertieren:
// - Genauere Deklaration der Variablentypen war erforderlich
// - Kein VB.Left/.Right -> Lösung siehe "eingabefilter"
// - Kein KeyUp/KeyDown Event möglich -> Lösung siehe "eingabefilter"
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BitratenrechnerCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Rechnen()
        {
            long Dauer;
            decimal Ergebnis, Ergebnis2;
            Int32 BitsA = Convert.ToInt32(Quelle_AudRate.Text) / 8, BitsA2 = Convert.ToInt32(Ziel_AudRate.Text) / 8;
            Int32 BitsV = Convert.ToInt32(Quelle_VidRate.Text) / 8, BitsV2 = Convert.ToInt32(Ziel_VidRate.Text) / 8;

            Dauer = Convert.ToInt64(Text_Stunden.Text) * 60;
            Dauer += Convert.ToInt64(Text_Minuten.Text);
            Dauer *= 60;
            Dauer += Convert.ToInt64(Text_Sekunden.Text);
            Ergebnis = (Dauer * BitsA) + (Dauer * BitsV);
            Ergebnis /= 1024;

            if (Check1.Checked == true)
            {
                Ergebnis2 = (Dauer * BitsA2) + (Dauer * BitsV2);
                Ergebnis2 /= 1024;
                Ergebnis -= Ergebnis2;
                Text5.Text = Convert.ToString(Ergebnis * -1);
            }
            else
            {
                Text5.Text = Convert.ToString(Ergebnis);
                goto ende;              // mir doch egal obs unsauberer Code ist, er funzt ;P
            }

        ende:
            ;
        }

        private void Check1_CheckedChanged(object sender, EventArgs e)
        {
            if (Check1.Checked == true)
            {
                GroupBox3.Text = "Differenz (MBytes)";
                Ziel_AudRate.Enabled = true;
                Ziel_VidRate.Enabled = true;
                Label7.Enabled = true;
                Label8.Enabled = true;
            }
            else
            {
                GroupBox3.Text = "Größe (MBytes)";
                Ziel_AudRate.Enabled = false;
                Ziel_VidRate.Enabled = false;
                Label7.Enabled = false;
                Label8.Enabled = false;
                Text5.BackColor = System.Drawing.SystemColors.Window;
            }
            Rechnen();
        }

        private void Text_Stunden_TextChanged(object sender, EventArgs e)
        {       
            if (Text_Stunden.Text == "")
                Text_Stunden.Text = "0";

            // ruft die Methode eingabefilter auf um unerwünschte Zeichen auszufiltern
            Text_Stunden.Text = eingabefilter(Text_Stunden.Text);

            // beschränkt den Max.Wert von Text_Stunden auf 99
            if (Convert.ToByte(Text_Stunden.Text) > 99)
                Text_Stunden.Text = "99";

            Rechnen();
        }
        private void Text_Minuten_TextChanged(object sender, EventArgs e)
        {
            if (Text_Minuten.Text == "")
                Text_Minuten.Text = "0";

            // ruft die Methode eingabefilter auf um unerwünschte Zeichen auszufiltern
            Text_Minuten.Text = eingabefilter(Text_Minuten.Text);

            // Beschränkt die Minutenzahl auf 59
            if (Convert.ToByte(Text_Minuten.Text) >= 60)
            {
                Text_Stunden.Text = Convert.ToString(Convert.ToByte(Text_Stunden.Text) +1);
                Text_Minuten.Text = Convert.ToString(Convert.ToByte(Text_Minuten.Text) -60);
            }
            
            Rechnen();
        }
        private void Text_Sekunden_TextChanged(object sender, EventArgs e)
        {
            if (Text_Sekunden.Text == "")
                Text_Sekunden.Text = "0";
            
            // ruft die Methode eingabefilter auf um unerwünschte Zeichen auszufiltern
            Text_Sekunden.Text = eingabefilter(Text_Sekunden.Text);

            // Beschränkt die Sekundenzahl auf 59
            if (Convert.ToByte(Text_Sekunden.Text) >= 60)
            {
                Text_Minuten.Text = Convert.ToString(Convert.ToByte(Text_Minuten.Text) + 1);
                Text_Sekunden.Text = Convert.ToString(Convert.ToByte(Text_Sekunden.Text) - 60);
            }

            Rechnen();
        }
        private void Quelle_VidRate_TextChanged(object sender, EventArgs e)
        {
            if (Quelle_VidRate.Text == "")
                Quelle_VidRate.Text = "0";

            // ruft die Methode eingabefilter auf um unerwünschte Zeichen auszufiltern
            Quelle_VidRate.Text = eingabefilter(Quelle_VidRate.Text);

            Rechnen();
        }
        private void Ziel_VidRate_TextChanged(object sender, EventArgs e)
        {
            if (Ziel_VidRate.Text == "")
                Ziel_VidRate.Text = "0";

            // ruft die Methode eingabefilter auf um unerwünschte Zeichen auszufiltern
            Ziel_VidRate.Text = eingabefilter(Ziel_VidRate.Text);

            Rechnen();
        }

        private void Quelle_AudRate_TextChanged(object sender, EventArgs e)
        {
            if (Quelle_AudRate.Text == "")
                Quelle_AudRate.Text = "128";

            Quelle_AudRate.Text = eingabefilter(Quelle_AudRate.Text);

            Rechnen();
        }
        private void Ziel_AudRate_TextChanged(object sender, EventArgs e)
        {
            if (Ziel_AudRate.Text == "")
                Ziel_AudRate.Text = "128";

            Ziel_AudRate.Text = eingabefilter(Ziel_AudRate.Text);

            Rechnen();
        }

        private void Text5_TextChanged(object sender, EventArgs e)
        {
            if (Check1.Checked == true)
            {
                if (Convert.ToDecimal(Text5.Text) < 0)
                    Text5.BackColor = System.Drawing.Color.Green;
                else if (Convert.ToDecimal(Text5.Text) > 0)
                    Text5.BackColor = System.Drawing.Color.Red;
                else
                    Text5.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        public string eingabefilter(string e)
        {
            // überprüft einen eingehenden String auf Zeichen und Zahlen,
            // filtert die Zeichen aus und gibt die übriggebliebenen Zahlen zurück
            string puffer = e, cleaned = "";

            while (puffer.Length > 0)
            {
                if (puffer.StartsWith("0") | puffer.StartsWith("1") | puffer.StartsWith("2") | puffer.StartsWith("3") | puffer.StartsWith("4") | puffer.StartsWith("5") | puffer.StartsWith("6") | puffer.StartsWith("7") | puffer.StartsWith("8") | puffer.StartsWith("9"))
                    cleaned += puffer.Substring(0, 1);

                puffer = puffer.Remove(0, 1);
            }

            return cleaned;
        }

        private void Quelle_AudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rechnen();
        }
        private void Ziel_AudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rechnen();
        }
    }
}
