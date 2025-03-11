using Mavercloud.JATS.Base;
using Mavercloud.JATS.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Mavercloud.JATS.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "sec")]
    public class Section : ParagraphElement
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "sec-type")]
        public string SectionType
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "specific-use")]
        public string SpecificUse
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "base", Namespace = "http://www.w3.org/xml/1998/namespace")]
        public string Base
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "lang", Namespace = "http://www.w3.org/xml/1998/namespace")]
        public string Language
        {
            get; set;
        }

        [XmlElement(ElementName = "sec-meta")]
        public SectionMetadata SecMeta
        {
            get; set;
        }

        [XmlElement(ElementName = "label")]
        public Label Label
        {
            get; set;
        }

        [XmlElement(ElementName = "title")]
        public Title Title
        {
            get; set;
        }

        [XmlElement("sec", typeof(Section))]
        [XmlElement("p", typeof(Paragraph))]
        [XmlElement("fig", typeof(Figure))]
        [XmlElement("fig-group", typeof(FigureGroup))]
        [XmlElement("table-wrap", typeof(TableWrapper))]
        [XmlElement("table-wrap-group", typeof(TableWrapperGroup))]
        public List<ParagraphElement> Elements
        {
            get;
            set;
        }


    }
}
