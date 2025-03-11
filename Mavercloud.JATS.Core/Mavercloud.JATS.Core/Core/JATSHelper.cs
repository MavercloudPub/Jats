using Mavercloud.JATS.Base;
using Mavercloud.JATS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Mavercloud.JATS.Core
{
    public static class JATSHelper
    {
        public static void InitAttribute(XmlReader reader, object obj)
        {
            var count = reader.AttributeCount;
            if (count > 0)
            {
                var props = obj.GetType().GetProperties().Where(
                prop => Attribute.IsDefined(prop, typeof(XmlAttributeAttribute)));
                foreach (var prop in props)
                {
                    var attr = prop.GetCustomAttributes(typeof(XmlAttributeAttribute), true)[0] as XmlAttributeAttribute;
                    Mavercloud.JATS.Helpers.Object.SetPropertyValue(obj, prop, reader.GetAttribute(attr.AttributeName));
                }
            }
        }
        public static ParagraphElement GetElement(string localName, string xml)
        {
            ParagraphElement element = null;
            switch (localName)
            {
                case "sec":
                    element = Mavercloud.JATS.Helpers.Xml.XmlStrToObject<Section>(xml);
                    break;
                case "p":
                    element = Mavercloud.JATS.Helpers.Xml.XmlStrToObject<Paragraph>(xml);
                    break;
                case "fig":
                    element = Mavercloud.JATS.Helpers.Xml.XmlStrToObject<Figure>(xml);
                    break;
                case "fig-group":
                    element = Mavercloud.JATS.Helpers.Xml.XmlStrToObject<FigureGroup>(xml);
                    break;
                case "table-wrap":
                    element = Mavercloud.JATS.Helpers.Xml.XmlStrToObject<TableWrapper>(xml);
                    break;
                case "table-wrap-group":
                    element = Mavercloud.JATS.Helpers.Xml.XmlStrToObject<TableWrapperGroup>(xml);
                    break;
                default:
                    break;
            }
            return element;
        }
    }
}
