﻿using System;
using System.Xml.Serialization;

namespace Mavercloud.JATS.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "institution")]
    public class Institution : InnerXmlElement
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "content-type")]
        public string ContentType
        {
            get; set;
        }

    }
}