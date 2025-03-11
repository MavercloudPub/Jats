using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Mavercloud.JATS.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "comment")]
    public class CommentInCitation : InnerXmlElement
    {
        [XmlElement(ElementName = "ext-link")]
        public List<ExternalLink> ExLinks
        {
            get;
            set;
        }

    }
}
