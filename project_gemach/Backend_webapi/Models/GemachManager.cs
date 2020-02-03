using System;

namespace Backend_webapi.Models
{
    public class GemachManager
    {
        //properties
        
        private static int allGemachManagersCount = 0;
        private int gemachManagerId;
        public int GemachManagerId
        {
            get { return gemachManagerId; }
            set { gemachManagerId = value; }
        }
        
        private string gemachManagerLastName;
        public string GemachManagerLastName
        {
            get { return gemachManagerLastName; }
            set { gemachManagerLastName = value; }
        }
        
        private string gemachManagerfirstName;
        public string GemachManagerFirstName
        {
            get { return gemachManagerfirstName; }
            set { gemachManagerfirstName = value; }
        }
        
        private string gemachManagerIDcard;
        public string GemachManagerIDcard
        {
            get { return gemachManagerIDcard; }
            set { gemachManagerIDcard = value; }
        }


        //constractors

        public GemachManager()
        {
            GemachManagerId = ++allGemachManagersCount;
        }

        //public GemachManager() { }
    }
}