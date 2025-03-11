using System.Xml.Serialization; 
namespace Mavercloud.JATS.NLMCatalogEntities{ 

[XmlRoot(ElementName="DateCreated")]
public class DateCreated { 

	[XmlElement(ElementName="Year")] 
	public int Year { get; set; } 

	[XmlElement(ElementName="Month")] 
	public string Month { get; set; } 

	[XmlElement(ElementName="Day")] 
	public string Day { get; set; } 
}

}