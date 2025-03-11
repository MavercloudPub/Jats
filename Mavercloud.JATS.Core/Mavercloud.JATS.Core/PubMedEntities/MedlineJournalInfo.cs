using System.Xml.Serialization; 
namespace Mavercloud.JATS.PubMedEntities{ 

[XmlRoot(ElementName="MedlineJournalInfo")]
public class MedlineJournalInfo { 

	[XmlElement(ElementName="Country")] 
	public string Country { get; set; } 

	[XmlElement(ElementName="MedlineTA")] 
	public string MedlineTA { get; set; } 

	[XmlElement(ElementName="NlmUniqueID")] 
	public string NlmUniqueID { get; set; } 

	[XmlElement(ElementName="ISSNLinking")] 
	public string ISSNLinking { get; set; } 
}

}