﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Mavercloud.JATS.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "access-date")]
    public class AccessDate
    {
        [XmlText]
        public string Content { get; set; }
    }
}
