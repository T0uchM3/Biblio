using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Book
    {
        private String title;
        private byte[] picture;
        private int id;

        public string Title
        {
            get => title;
            set => title = value;
        }

        public byte[] Picture
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