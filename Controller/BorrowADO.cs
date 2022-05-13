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
        public List<Count> counList = new List<Count>();

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

        public void loadCount(int indicator)
        {
            SqlDataReader reader = null;
            borrowADOList = new List<Borrow>();
            if (indicator == 0)
            {
                reader = cnx.SDD("SELECT * FROM VisitorCount");
            }
            else
            {
                reader = cnx.SDD("SELECT * FROM BorrowCount");
            }

            while (reader.Read())
            {
                Count c = new Count();
                c.date = (DateTime)reader.GetValue(0);
                c.count = (int)reader.GetValue(1);
                counList.Add(c);
            }

            reader.Close();
        }

        public Status loadStatus()
        {
            SqlDataReader reader = null;
            borrowADOList = new List<Borrow>();
            reader = cnx.SDD("SELECT * FROM BorrowStatus");
            Status s = new Status();
            while (reader.Read())
            {
                s.BorrowYesterday = (int)reader.GetValue(0);
                s.BorrowBeforeYesterday = (int)reader.GetValue(1);
                s.TotalBorrow = (int)reader.GetValue(2);
                s.VisitYesterday = (int)reader.GetValue(3);
                s.VisitBeforeYesterday = (int)reader.GetValue(4);
                s.TotalVisit = (int)reader.GetValue(5);
                s.OverdueYesterday = (int)reader.GetValue(7);
                s.OverdueBeforeYesterday = (int)reader.GetValue(8);
                s.TotalOverdue = (int)reader.GetValue(6);
            }

            reader.Close();
            return s;
        }
    }
}