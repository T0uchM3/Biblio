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
    public class BorrowADO
    {
        public List<Borrow> borrowADOList = new List<Borrow>();
        Connection cnx = new Connection();

        public void insert(Borrow borrow)
        {
            Console.WriteLine("INSERTED LIBRARIAN");

            using (SqlCommand cmd =
                   new SqlCommand("insert into Borrow values (@LibID ,@MemID,@BookID,@Date,@DueDate)"))
            {
                cmd.Parameters.AddWithValue("@LibID", borrow.LibId);
                cmd.Parameters.AddWithValue("@MemID", borrow.MemId);
                cmd.Parameters.AddWithValue("@BookID", borrow.BookId);
                cmd.Parameters.AddWithValue("@Date", borrow.Date);
                cmd.Parameters.AddWithValue("@DueDate", borrow.DueDate);
                cnx.executeCommand(cmd);
            }
        }

        public void update(Borrow borrow)
        {
            //SqlCommand cmd = new SqlCommand("update  client set nom ='" + client.Nom + "' ,  prenom =  '" +
            //                                client.Prenom + "' , adresse =  '" + client.Adresse + "' , tel =  '" +
            //                                client.Telephone + "' , code_postale =  '" + client.Code_postal +
            //                                "' where id = " + client.Id + "; ");
            //cnx.executeCommand(cmd);
        }

        public void delete(Borrow borrow)
        {
            //SqlCommand cmd = new SqlCommand("delete from  client  where id = " + client.Id + "; ");
            //cnx.executeCommand(cmd);
        }

        public void load()
        {
            borrowADOList = new List<Borrow>();
            SqlDataReader reader = cnx.SDD("SELECT * FROM BORROW");
            while (reader.Read())
            {
                Borrow borrow = new Borrow();
                borrow.LibId = (int)reader.GetValue(1);
                borrow.MemId = (int)reader.GetValue(2);
                borrow.BookId = (int)reader.GetValue(3);
                borrow.Date = (DateTime)reader.GetValue(4);
                borrow.DueDate = (DateTime)reader.GetValue(5);
                borrowADOList.Add(borrow);
            }

            reader.Close();
        }
    }
}