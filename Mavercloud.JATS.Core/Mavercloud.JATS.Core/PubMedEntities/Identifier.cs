﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Mavercloud.JATS.PubMedEntities
{
    [XmlRoot(ElementName = "Identifier")]
    public class Identifier
    {
        [XmlAttribute(AttributeName = "Source")]
        public string Source { get; set; }

        [XmlText]
        public string Text { get; set; }
    }
}
