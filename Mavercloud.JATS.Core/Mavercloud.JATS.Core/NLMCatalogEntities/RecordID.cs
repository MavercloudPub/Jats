using System.Xml.Serialization; 
namespace Mavercloud.JATS.NLMCatalogEntities{ 

[XmlRoot(ElementName="RecordID")]
public class RecordID { 

	[XmlAttribute(AttributeName="Source")] 
	public string Source { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

}