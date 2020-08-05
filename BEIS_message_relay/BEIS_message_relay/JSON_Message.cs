using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BEIS_message_relay
{
    /*
    - This class is used to define what the JSON string will 
        look like when it arrives at rabbitMQ.
    - By default the User coming from Banner is described in
        the "Payload" field
    - Any extra attributes in the message should be defined below
    */

    public class JSON_Message
    {
        public string ActionType { get; set; }
        public string Date { get; set; }
        public BannerUser Payload { get; set; }

        public JSON_Message(BannerUser _bannerUser)
        {
            this.ActionType = "Update";
            this.Date = DateTime.Now.ToLongDateString();

            this.Payload = _bannerUser;
        }
    }
}
