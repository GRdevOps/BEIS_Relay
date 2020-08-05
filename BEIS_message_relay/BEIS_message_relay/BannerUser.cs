using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BEIS_message_relay
{
    /*
    - This class is used to define what the Banner User looks like
    - Any attributes specific to the user should be defined here
    - This class will get placed into the "Payload" field when sent to rabbitMQ
    */

    public class BannerUser
    {
        // Any attribute that is part of the user should be defined here
        // Setup Multivalued Attributes as Lists
        public String UDCIdentifier { get; set; }
        public String FullName { get; set; }
        public String GivenName { get; set; }
        public String MiddleName { get; set; }
        public String FamilyName { get; set; }
        public String OU { get; set; }
        public List<String> Roles { get; set; }

        // Map attributes to the Envelope class here
        public BannerUser(Envelope xml)
        {
            this.UDCIdentifier = xml.Body.modifyRequest.modification.
                data.UDCIdentity.UDCIdentifier;

            this.FullName = xml.Body.modifyRequest.modification.
                data.UDCIdentity.PersonIdentity.PersonName.FormattedName;

            this.GivenName = xml.Body.modifyRequest.modification.
                data.UDCIdentity.PersonIdentity.PersonName.GivenName;

            this.MiddleName = xml.Body.modifyRequest.modification.
                data.UDCIdentity.PersonIdentity.PersonName.MiddleName;

            this.FamilyName = xml.Body.modifyRequest.modification.
                data.UDCIdentity.PersonIdentity.PersonName.FamilyName;

            this.OU = xml.Body.modifyRequest.modification.
                data.UDCIdentity.Extension.Where(t => t.name == "OU").First().value;

            // Must initialize before the loop for Lists
            this.Roles = new List<string>();

            foreach (var role in xml.Body.modifyRequest.modification.
                data.UDCIdentity.InstitutionRoles)
            {
                this.Roles.Add(role.role);
            }
        }
    }
}
