﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTROLLER;
using Model;

namespace Controller
{
    public class LibrarianADO
    {
        public List<Librarian> libADOList = new List<Librarian>();
        Connection cnx = new Connection();

        public void insert(Librarian librarian)
        {
            SqlCommand cmd = new SqlCommand("insert into librarian values ('" + librarian.Name + "' , '" +
                                            librarian.Password +
                                            "')");
            cnx.executeCommand(cmd);
            Console.WriteLine("INSERTED LIBRARIAN");
        }

        public void update(Librarian client)
        {
            //SqlCommand cmd = new SqlCommand("update  client set nom ='" + client.Nom + "' ,  prenom =  '" +
            //                                client.Prenom + "' , adresse =  '" + client.Adresse + "' , tel =  '" +
            //                                client.Telephone + "' , code_postale =  '" + client.Code_postal +
            //                                "' where id = " + client.Id + "; ");
            //cnx.executeCommand(cmd);
        }

        public void delete(Librarian client)
        {
            //SqlCommand cmd = new SqlCommand("delete from  client  where id = " + client.Id + "; ");
            //cnx.executeCommand(cmd);
        }

        public void load()
        {
            libADOList = new List<Librarian>();
            SqlDataReader reader = cnx.SDD("SELECT * FROM LIBRARIAN");
            while (reader.Read())
            {
                Librarian librarian = new Librarian();
                librarian.Name = (String)reader.GetValue(1);
                librarian.Password = (String)reader.GetValue(2);

                libADOList.Add(librarian);
            }

            reader.Close();
        }
    }
}