using System.Collections.Generic;
using System.Xml.Serialization;
namespace PDC.Entity
{
    //This File holds the model classes used for XML 

    [XmlRoot(ElementName = "Address")]
    public class Address
    {
        [XmlElement(ElementName = "Street")]
        public string Street { get; set; }
        [XmlElement(ElementName = "HouseNumber")]
        public string HouseNumber { get; set; }
        [XmlElement(ElementName = "PostalCode")]
        public string PostalCode { get; set; }
        [XmlElement(ElementName = "City")]
        public string City { get; set; }
    }

    [XmlType("Company")]
    [XmlRoot(ElementName = "Sender")]
    public class Sender
    {
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "Address")]
        public Address Address { get; set; }
        [XmlElement(ElementName = "CcNumber")]
        public string CcNumber { get; set; }
    }

    [XmlRoot(ElementName = "Receipient")]
    public class Receipient
    {
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "Address")]
        public Address Address { get; set; }
    }

    [XmlRoot(ElementName = "Parcel")]
    public class Parcel
    {
        [XmlElement(ElementName = "Sender")]
        public Sender Sender { get; set; }
        [XmlElement(ElementName = "Receipient")]
        public Receipient Receipient { get; set; }
        [XmlElement(ElementName = "Weight")]
        public string Weight { get; set; }
        [XmlElement(ElementName = "Value")]
        public string Value { get; set; }
        [XmlIgnore]
        public string Department { get; set; }
    }

    [XmlRoot(ElementName = "parcels")]
    public class Parcels
    {
        [XmlElement(ElementName = "Parcel")]
        public List<Parcel> Parcel { get; set; }
    }

    [XmlRoot(ElementName = "Container")]
    public class ParcelDetails
    {
        [XmlElement(ElementName = "Id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "ShippingDate")]
        public string ShippingDate { get; set; }
        [XmlElement(ElementName = "parcels")]
        public Parcels Parcels { get; set; }
    }

}


