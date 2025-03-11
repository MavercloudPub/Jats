using System.Xml.Serialization; 
using System.Collections.Generic; 
namespace Mavercloud.JATS.PubMedEntities{ 

[XmlRoot(ElementName="ReferenceList")]
public class ReferenceList { 

	[XmlElement(ElementName="Reference")] 
	public List<Reference> Reference { get; set; } 
}

}