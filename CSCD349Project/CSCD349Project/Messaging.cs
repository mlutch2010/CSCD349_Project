using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    class Messaging
    {

        private List<string> messages;   
        private int lastMessage;
        public Messaging()
        {
            messages = new List<string>();
            lastMessage = 0;
        }
        public void addMessage(string newMessage)
        {
            if(newMessage != null)
                messages.Add(newMessage);
        }
    
        public string getLatestMessages()
        {
            string output = "";
            for (; lastMessage < messages.Count; ++lastMessage)
                output += messages[lastMessage] + "\n";
            return output;
        }
    
    
    
    }
}
