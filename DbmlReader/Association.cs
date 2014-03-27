using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace DbmlReader
{
	
	public class Association
	{
		// ATTRIBUTES
		[XmlAttribute("Name")]
		public string Name { get; set; }
		
		[XmlAttribute("Member")]
		public string Member { get; set; }
		
		[XmlAttribute("ThisKey")]
		public string ThisKey { get; set; }
		
		[XmlAttribute("OtherKey")]
		public string OtherKey { get; set; }
		
		[XmlAttribute("Type")]
		public string Type { get; set; }
		
		[XmlIgnore]
		public bool? IsForeignKey { get; set; }
		[XmlAttribute("IsForeignKey")]
		public string IsForeignKeyString
		{
			get { return (IsForeignKey ?? false) ? "true" : "false"; }
			set
			{
                if (String.IsNullOrEmpty(value)) IsForeignKey = null;
				else IsForeignKey = value == "true";
			}
		}
		
		[XmlAttribute("Cardinality")]
		public string Cardinality { get; set; }
		
		[XmlAttribute("Storage")]
		public string Storage { get; set; }
		
		// ELEMENTS
		[XmlText]
		public string Value { get; set; }
		
		// CONSTRUCTOR
		public Association()
		{}
	}
}
