using System.Xml.Serialization; 
using System.Collections.Generic; 
namespace Mavercloud.JATS.PubMedEntities{ 

[XmlRoot(ElementName="PublicationTypeList")]
public class PublicationTypeList { 

	[XmlElement(ElementName="PublicationType")] 
	public List<PublicationType> PublicationType { get; set; } 
}

}