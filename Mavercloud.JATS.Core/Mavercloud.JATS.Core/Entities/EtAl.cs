﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Mavercloud.JATS.Entities
{

    [Serializable]
    [XmlRoot(ElementName = "etal")]
    public class EtAl : ContributorNamingElement
    {
        public string Content
        {
            get;set;
        }
    }
}
