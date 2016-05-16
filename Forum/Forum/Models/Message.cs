using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forum.Models
{
    class Message
    {
        public User user { get; set;}
        public string text { get; set; }
        public DateTime dateTime { get; set; }
        private long id;

        public long Id
        {
            get { return id; }
            set 
            {
                if (id <= 0)
                { Console.Write("error"); }
                else
                    id = value;
            }
        }

        public Message(User _user, string _text, DateTime _dateTime, long _id)
        {
            this.user = _user;
            this.text = _text;
            this.dateTime = _dateTime;
            this.Id = _id;
        }
    }
}
