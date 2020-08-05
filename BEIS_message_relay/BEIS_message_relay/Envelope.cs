using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BEIS_message_relay
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", IsNullable = false)]
    public partial class Envelope
    {

        private EnvelopeBody bodyField;

        /// <remarks/>
        public EnvelopeBody Body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public partial class EnvelopeBody
    {

        private modifyRequest modifyRequestField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:SPML:2:0")]
        public modifyRequest modifyRequest
        {
            get
            {
                return this.modifyRequestField;
            }
            set
            {
                this.modifyRequestField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:SPML:2:0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:SPML:2:0", IsNullable = false)]
    public partial class modifyRequest
    {

        private modifyRequestPsoID psoIDField;

        private modifyRequestModification modificationField;

        private string returnDataField;

        /// <remarks/>
        public modifyRequestPsoID psoID
        {
            get
            {
                return this.psoIDField;
            }
            set
            {
                this.psoIDField = value;
            }
        }

        /// <remarks/>
        public modifyRequestModification modification
        {
            get
            {
                return this.modificationField;
            }
            set
            {
                this.modificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string returnData
        {
            get
            {
                return this.returnDataField;
            }
            set
            {
                this.returnDataField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:SPML:2:0")]
    public partial class modifyRequestPsoID
    {

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:SPML:2:0")]
    public partial class modifyRequestModification
    {

        private modifyRequestModificationData dataField;

        private string modificationModeField;

        /// <remarks/>
        public modifyRequestModificationData data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string modificationMode
        {
            get
            {
                return this.modificationModeField;
            }
            set
            {
                this.modificationModeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:SPML:2:0")]
    public partial class modifyRequestModificationData
    {

        private UDCIdentity uDCIdentityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:sungardhe:enterprise:domain:identity:1.0")]
        public UDCIdentity UDCIdentity
        {
            get
            {
                return this.uDCIdentityField;
            }
            set
            {
                this.uDCIdentityField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:sungardhe:enterprise:domain:identity:1.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:sungardhe:enterprise:domain:identity:1.0", IsNullable = false)]
    public partial class UDCIdentity
    {

        private string uDCIdentifierField;

        private UDCIdentityPersonIdentity personIdentityField;

        private UDCIdentityInstitutionrole[] institutionRolesField;

        private UDCIdentityAttribute[] extensionField;

        private string actionField;

        private string pUBLISHER_NAMEField;

        /// <remarks/>
        public string UDCIdentifier
        {
            get
            {
                return this.uDCIdentifierField;
            }
            set
            {
                this.uDCIdentifierField = value;
            }
        }

        /// <remarks/>
        public UDCIdentityPersonIdentity PersonIdentity
        {
            get
            {
                return this.personIdentityField;
            }
            set
            {
                this.personIdentityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("institutionrole", IsNullable = false)]
        public UDCIdentityInstitutionrole[] InstitutionRoles
        {
            get
            {
                return this.institutionRolesField;
            }
            set
            {
                this.institutionRolesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Attribute", IsNullable = false)]
        public UDCIdentityAttribute[] Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PUBLISHER_NAME
        {
            get
            {
                return this.pUBLISHER_NAMEField;
            }
            set
            {
                this.pUBLISHER_NAMEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:sungardhe:enterprise:domain:identity:1.0")]
    public partial class UDCIdentityPersonIdentity
    {

        private UDCIdentityPersonIdentityPersonName personNameField;

        private string genderField;

        private UDCIdentityPersonIdentityBirthdate birthdateField;

        private uint taxIdField;

        /// <remarks/>
        public UDCIdentityPersonIdentityPersonName PersonName
        {
            get
            {
                return this.personNameField;
            }
            set
            {
                this.personNameField = value;
            }
        }

        /// <remarks/>
        public string Gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        /// <remarks/>
        public UDCIdentityPersonIdentityBirthdate Birthdate
        {
            get
            {
                return this.birthdateField;
            }
            set
            {
                this.birthdateField = value;
            }
        }

        /// <remarks/>
        public uint TaxId
        {
            get
            {
                return this.taxIdField;
            }
            set
            {
                this.taxIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:sungardhe:enterprise:domain:identity:1.0")]
    public partial class UDCIdentityPersonIdentityPersonName
    {

        private string formattedNameField;

        private string givenNameField;

        private string middleNameField;

        private string familyNameField;

        /// <remarks/>
        public string FormattedName
        {
            get
            {
                return this.formattedNameField;
            }
            set
            {
                this.formattedNameField = value;
            }
        }

        /// <remarks/>
        public string GivenName
        {
            get
            {
                return this.givenNameField;
            }
            set
            {
                this.givenNameField = value;
            }
        }

        /// <remarks/>
        public string MiddleName
        {
            get
            {
                return this.middleNameField;
            }
            set
            {
                this.middleNameField = value;
            }
        }

        /// <remarks/>
        public string FamilyName
        {
            get
            {
                return this.familyNameField;
            }
            set
            {
                this.familyNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:sungardhe:enterprise:domain:identity:1.0")]
    public partial class UDCIdentityPersonIdentityBirthdate
    {

        private byte birthDayField;

        private byte birthMonthField;

        private ushort birthYearField;

        /// <remarks/>
        public byte BirthDay
        {
            get
            {
                return this.birthDayField;
            }
            set
            {
                this.birthDayField = value;
            }
        }

        /// <remarks/>
        public byte BirthMonth
        {
            get
            {
                return this.birthMonthField;
            }
            set
            {
                this.birthMonthField = value;
            }
        }

        /// <remarks/>
        public ushort BirthYear
        {
            get
            {
                return this.birthYearField;
            }
            set
            {
                this.birthYearField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:sungardhe:enterprise:domain:identity:1.0")]
    public partial class UDCIdentityInstitutionrole
    {

        private string roleField;

        private string contextField;

        /// <remarks/>
        public string role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }

        /// <remarks/>
        public string context
        {
            get
            {
                return this.contextField;
            }
            set
            {
                this.contextField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:sungardhe:enterprise:domain:identity:1.0")]
    public partial class UDCIdentityAttribute
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}
