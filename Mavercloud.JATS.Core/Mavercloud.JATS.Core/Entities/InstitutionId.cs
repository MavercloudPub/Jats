using System.Xml.Serialization;
using System;

namespace Mavercloud.JATS.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "institution-id")]
    public class InstitutionId : InnerXmlElement
    {
        [XmlAttribute(AttributeName = "institution-id-type")]
        public string InstitutionIdType { get; set; }
    }
}