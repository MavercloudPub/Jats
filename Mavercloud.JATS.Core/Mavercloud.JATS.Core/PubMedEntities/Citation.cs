using Mavercloud.JATS.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Mavercloud.JATS.PubMedEntities
{
    [XmlRoot(ElementName = "Citation")]
    public class Citation: InnerXmlElement
    {
    }
}
