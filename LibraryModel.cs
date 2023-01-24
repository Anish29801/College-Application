using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Application
{
    public class LibraryModel
    {
        // Libaray Model
        private int id = 0;
        private int libarayBookId = 0;
        private int libarayStudentId = 0;
        private DateTime subDate = DateTime.MinValue;
        private DateTime retDate = DateTime.MinValue;
        private int subscribed = 0;

        // Libaray Properties

        public int LibarayId
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public int LibarayBookId
        {
            get
            {
                return libarayBookId;
            }
            set
            {
                libarayBookId = value;
            }
        }
        public int LibarayStudentId
        {
            get
            {
                return libarayStudentId;
            }
            set
            {
                libarayStudentId = value;
            }
        }
        public int Subscribed
        {
            get
            {
                return subscribed;
            }
            set
            {
                subscribed = value;
            }
        }
        public DateTime SubDate
        {
            get
            {
                return subDate;
            }
            set
            {
                subDate = value;
            }
        }
        public DateTime RetDate
        {
            get
            {
                return retDate;
            }
            set
            {
                retDate = value;
            }
        }
    }
}
