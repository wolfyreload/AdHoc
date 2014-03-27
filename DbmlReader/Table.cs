using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace DbmlReader
{
	
	public class Table
	{
		// ATTRIBUTES
		[XmlAttribute("Name")]
		public string Name { get; set; }
		
		[XmlAttribute("Member")]
		public string Member { get; set; }
		
		// ELEMENTS
		[XmlElement("Type")]
		public Type Type { get; set; }
		
		// CONSTRUCTOR
		public Table()
		{}
	}
}
