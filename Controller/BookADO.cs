using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTROLLER;
using Model;

namespace Controller
{
    public class BookADO
    {
        public List<Book> bookADOList = new List<Book>();
        Connection cnx = new Connection();

        public void insert(Book book)
        {
            using (SqlCommand cmd = new SqlCommand("insert into Book values (@Title,@Picture)"))
            {
                cmd.Parameters.AddWithValue("@Title", book.Title);

                cmd.Parameters.AddWithValue("@Picture", book.Picture);
                cnx.executeCommand(cmd);
            }
        }

        public void update(Book book)
        {
            //SqlCommand cmd = new SqlCommand("update  client set nom ='" + client.Nom + "' ,  prenom =  '" +
            //                                client.Prenom + "' , adresse =  '" + client.Adresse + "' , tel =  '" +
            //                                client.Telephone + "' , code_postale =  '" + client.Code_postal +
            //                                "' where id = " + client.Id + "; ");
            //cnx.executeCommand(cmd);
        }

        public void delete(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from  Book  where id = " + id + "; ");
            cnx.executeCommand(cmd);
            load(null);
        }

        public void load(String title)
        {
            bookADOList = new List<Book>();
            SqlDataReader reader;
            if (title == null)
                reader = cnx.SDD("SELECT * FROM BOOK");
            else
                reader = cnx.SDD("SELECT * FROM BOOK WHERE Title = '" + title + "';");

            while (reader.Read())
            {
                Book book = new Book();
                book.Title = (String)reader.GetValue(1);
                book.Picture = (byte[])reader.GetValue(2);
                book.Id = (int)reader.GetValue(0);
                bookADOList.Add(book);
            }

            reader.Close();
        }
    }
}