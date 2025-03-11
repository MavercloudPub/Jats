using Mavercloud.JATS.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Mavercloud.JATS.PubMedEntities
{
    [XmlRoot(ElementName = "Keyword")]
    public class Keyword: InnerXmlElement
    {
        [XmlAttribute(AttributeName = "MajorTopicYN")]
        public string MajorTopicYN { get; set; }

    }
}
