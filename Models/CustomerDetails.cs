using System;
using System.Collections.Generic;
using System.Text;

namespace PushCustomersToMpoint.Modles
{
    class CustomerDetails
    {
        public int id { get; set; }
        public string title { get; set; }
        public string initials { get; set; }
        public string name { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string fullName { get; set; }
        public string gender { get; set; }
        public string birthDate { get; set; }
        public string birthPlace { get; set; }
        public Culture culture { get; set; }
        public string emailAddress { get; set; }
        public bool emailAddressVerified { get; set; }
        public string alternativeEmails { get; set; }
        public PhoneNumber[] phoneNumbers { get; set; }
        public Address[] addresses { get; set; }
        public Externalidentifier[] externalIdentifiers { get; set; }
        public object tags { get; set; }
        public Customfield[] customFields { get; set; }
        public int balance { get; set; }
        public object tier { get; set; }
        public Programidentifier[] programIdentifiers { get; set; }

    }

    public class Culture
    {
        public int id { get; set; }
        public string languageCode { get; set; }
        public string countryCode { get; set; }
        public string createdAt { get; set; }
        public string modifiedAt { get; set; }
    }

    public class Address
    {
        public int      id { get; set; }
        public bool     primary { get; set; }
        public string   type { get; set; }
        public string   addressLine1 { get; set; }
        public object   addressLine2 { get; set; }
        public string   houseNumber { get; set; }
        public string   houseNumberSuffix { get; set; }
        public string   postalCode { get; set; }
        public object   state { get; set; }
        public string   city { get; set; }
        public string   country { get; set; }
        public string   createdAt { get; set; }
        public string   modifiedAt { get; set; }
    }

    public class PhoneNumber
    {
        public int id { get; set; }
        public bool primary { get; set; }
        public string type { get; set; }
        public string countryCode { get; set; }
        public string number { get; set; }
        public string createdAt { get; set; }
        public string modifiedAt { get; set; }
    }

    public class Customfield
    {
        public int id { get; set; }
        public string name { get; set; }
        public string value { get; set; }
    }

    public class Programidentifier
    {
        public int id { get; set; }
        public string type { get; set; }
        public string identifier { get; set; }
        public Boolean activateOnRegistration { get; set; }
        public string registeredAt { get; set; }
        public string registrationSoure { get; set; }
        public string registrationReason { get; set; }
    }

    public class Externalidentifier
    {
        public int id { get; set; }
        public string Source { get; set; }
        public string Identifier { get; set; }
    }

}


