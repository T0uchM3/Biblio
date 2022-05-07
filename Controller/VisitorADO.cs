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
    public class VisitorADO
    {
        public List<Visitor> visADOList = new List<Visitor>();
        Connection cnx = new Connection();

        public void insert(Visitor visitor)
        {
            SqlCommand cmd = new SqlCommand("insert into Visitor values ('" + visitor.Name + "' , '" +
                                            visitor.Age +
                                            "' , '" + visitor.VisitDay + "')");
            cnx.executeCommand(cmd);
            Console.WriteLine("INSERTED Visitor");
        }

        public void update(Visitor visitor)
        {
            //SqlCommand cmd = new SqlCommand("update  client set nom ='" + client.Nom + "' ,  prenom =  '" +
            //                                client.Prenom + "' , adresse =  '" + client.Adresse + "' , tel =  '" +
            //                                client.Telephone + "' , code_postale =  '" + client.Code_postal +
            //                                "' where id = " + client.Id + "; ");
            //cnx.executeCommand(cmd);
        }

        public void delete(String id)
        {
            SqlCommand cmd = new SqlCommand("delete from  Visitor  where id = " + id + "; ");
            cnx.executeCommand(cmd);
        }

        public void load()
        {
            visADOList = new List<Visitor>();
            SqlDataReader reader = cnx.SDD("SELECT * FROM Visitor");
            while (reader.Read())
            {
                Visitor visitor = new Visitor();
                visitor.Name = (String)reader.GetValue(1);
                visitor.Age = (int)reader.GetValue(2);
                visitor.VisitDay = (DateTime)reader.GetValue(3);
                visitor.Id = (int)reader.GetValue(0);
                visADOList.Add(visitor);
            }

            reader.Close();
        }
    }
}