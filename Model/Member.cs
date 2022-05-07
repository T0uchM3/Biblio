using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Member
    {
        private String name;
        private DateTime since; //member since
        private int age;
        private String mail;
        private int phone;
        int picture;
        private int id;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public DateTime Since
        {
            get => since;
            set => since = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public string Mail
        {
            get => mail;
            set => mail = value;
        }

        public int Phone
        {
            get => phone;
            set => phone = value;
        }

        public int Picture
        {
            get => picture;
            set => picture = value;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }
    }
}