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
    public class MemberADO
    {
        public List<Member> memADOList = new List<Member>();
        Connection cnx = new Connection();

        public void insert(Member member)
        {
            Console.WriteLine("INSERTED Member");

            using (SqlCommand cmd =
                   new SqlCommand("insert into Member values (@Name,@Since,@Age,@Mail,@Phone,@Picture)"))
            {
                cmd.Parameters.AddWithValue("@Name", member.Name);

                cmd.Parameters.AddWithValue("@Since", member.Since);
                cmd.Parameters.AddWithValue("@Age", member.Age);
                cmd.Parameters.AddWithValue("@Mail", member.Mail);
                cmd.Parameters.AddWithValue("@Phone", member.Phone);
                cmd.Parameters.AddWithValue("@Picture", member.Picture);

                cnx.executeCommand(cmd);
            }
        }

        public void update(Member member)
        {
            //SqlCommand cmd = new SqlCommand("update  client set nom ='" + client.Nom + "' ,  prenom =  '" +
            //                                client.Prenom + "' , adresse =  '" + client.Adresse + "' , tel =  '" +
            //                                client.Telephone + "' , code_postale =  '" + client.Code_postal +
            //                                "' where id = " + client.Id + "; ");
            //cnx.executeCommand(cmd);
        }

        public void delete(Member member)
        {
            //SqlCommand cmd = new SqlCommand("delete from  client  where id = " + client.Id + "; ");
            //cnx.executeCommand(cmd);
        }

        public void load()
        {
            memADOList = new List<Member>();
            SqlDataReader reader = cnx.SDD("SELECT * FROM Member");
            while (reader.Read())
            {
                Member member = new Member();
                member.Name = (String)reader.GetValue(1);
                member.Since = (DateTime)reader.GetValue(2);
                member.Age = (int)reader.GetValue(3);
                member.Mail = (String)reader.GetValue(4);
                member.Phone = (int)reader.GetValue(5);
                member.Picture = (byte[])reader.GetValue(6);

                memADOList.Add(member);
            }

            reader.Close();
        }
    }
}