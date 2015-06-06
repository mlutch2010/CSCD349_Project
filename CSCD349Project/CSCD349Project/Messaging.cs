using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    public class Messaging
    {

        private List<string> messages;   
        private int lastMessage;
        public Messaging()
        {
            messages = new List<string>();
            lastMessage = 0;
        }
        public void AddMessage(string newMessage)
        {
            if(newMessage != null)
                messages.Add(newMessage);
        }
    
        public string[] getLatestMessages()
        {
            List<string> output = new List<string>();
            for (; lastMessage < messages.Count; ++lastMessage)
                output.Add(messages[lastMessage]);
            return output.ToArray();
        }
    
    
    
    }
}
