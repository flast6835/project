using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_forsty_cone
{
    public class Session
    { //prevent multiple instances of session
        private static Session instance;
        public int UserId { get; set; } // Store user ID
        public string Username { get; set; } // Store username
        public int IsAdmin { get; set; } // Store admin status (0 or 1)

        private Session() { } // Private constructor to prevent instantiation   

        public static Session Instance
        {
            get
            {
                // Create a new instance if it doesn't exist
                if (instance == null)
                {
                    instance = new Session();
                }
                return instance;
            }
        }

        public void Clear() // Clear session data
        {
            UserId = 0;
            Username = null;
            IsAdmin = 0;
        }
    }
}
