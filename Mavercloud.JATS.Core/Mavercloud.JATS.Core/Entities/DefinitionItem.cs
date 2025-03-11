using Mavercloud.JATS.Base;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Mavercloud.JATS.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "def-item")]
    public class DefinitionItem
    {
        [XmlElement(ElementName = "title")]
        public Title Title
        {
            get; set;
        }

        [XmlElement(ElementName = "term")]
        public Term Term
        {
            get;set;
        }

        [XmlElement(ElementName = "def")]
        public List<Definition> Defs
        {
            get;
            set;
        }
    }
}