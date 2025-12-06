using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace pisanjexml
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static List<ucenik> ucenici = new List<ucenik>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btunos_Click(object sender, EventArgs e)
        {
            ucenici.Add(new ucenik(Convert.ToInt32(Tbrb.Text), Tbime.Text, Tbprezime.Text,
                Convert.ToDouble(Tbprosek.Text)));

            Tbime.Text = Tbrb.Text = Tbprezime.Text = Tbprosek.Text = String.Empty;
            Tbrb.Focus();

        }

        protected void Btkraj_Click(object sender, EventArgs e)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            /*
             bez gornje dve linije koda zapis bi izgledao ovako <ucenici><ucenik><ID>1</ID><Ime>Marko</Ime></ucenik></ucenici>            
             */

            XmlWriter writer = XmlWriter.Create(Server.MapPath("ucenici2grupa.xml"), settings);
            writer.WriteStartDocument(); // pocetak dokumenta -><?xml version="1.0" encoding="utf-8"?>
            writer.WriteStartElement("ucenici"); // kreirali smo korenski element <ucenici>

            foreach (ucenik ucenik41 in ucenici)

            {
                writer.WriteStartElement("ucenik"); // <ucenik>

                writer.WriteStartElement("ID"); 
                writer.WriteValue(ucenik41.id);
                writer.WriteEndElement();
                //<ID>ucenik41.id</ID>

                writer.WriteStartElement("Ime");
                writer.WriteValue(ucenik41.ime);
                writer.WriteEndElement();
                //<Ime>ucenik41.ime</Ime>

                writer.WriteStartElement("Prezime");
                writer.WriteValue(ucenik41.prezime);
                writer.WriteEndElement();
                //<Prezime>ucenik41.prezime</Prezime>

                writer.WriteStartElement("Prosek");
                writer.WriteValue(ucenik41.prosek);
                writer.WriteEndElement();
                //<Prosek>ucenik41.prosek</Prosek>

                writer.WriteEndElement();
                // </ucenik>
            }
            writer.WriteEndElement(); // zatvaramo korenski element </ucenici>
            writer.Flush();//ovo nije obavezno jer se poziva u Close metodi automatski
            writer.Close();
            Response.Redirect("ucenici2grupa.xml");
        }

    }
}