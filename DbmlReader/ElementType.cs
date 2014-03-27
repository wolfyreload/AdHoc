using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace DbmlReader
{
	
	public class ElementType
	{
		// ATTRIBUTES
		[XmlAttribute("Name")]
		public string Name { get; set; }
		
		// ELEMENTS
		[XmlElement("Column")]
		public List<ElementTypeColumn> ElementTypeColumn { get; set; }
		
		// CONSTRUCTOR
		public ElementType()
		{}
	}
}
