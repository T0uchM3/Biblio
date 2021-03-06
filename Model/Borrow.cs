using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Borrow
    {
        private int libId;
        private int memId;
        private int bookId;
        private DateTime date;
        private DateTime dueDate;
        private int id;
        private int returned;

        public int LibId
        {
            get => libId;
            set => libId = value;
        }

        public int MemId
        {
            get => memId;
            set => memId = value;
        }

        public int BookId
        {
            get => bookId;
            set => bookId = value;
        }

        public DateTime Date
        {
            get => date;
            set => date = value;
        }

        public DateTime DueDate
        {
            get => dueDate;
            set => dueDate = value;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public int Returned
        {
            get => returned;
            set => returned = value;
        }
    }
}