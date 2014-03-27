using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace DbmlReader
{
	[XmlTypeAttribute(AnonymousType = true)]
	public class Database
	{
		// ATTRIBUTES
		[XmlAttribute("Name")]
		public string Name { get; set; }
		
		[XmlAttribute("EntityNamespace")]
		public string EntityNamespace { get; set; }
		
		[XmlAttribute("ContextNamespace")]
		public string ContextNamespace { get; set; }

		[XmlAttribute("Class")]
		public string Class { get; set; }
		
		// ELEMENTS
		[XmlElement("Table")]
		public List<Table> Table { get; set; }
		
		[XmlElement("Connection")]
		public Connection Connection { get; set; }
		
		[XmlElement("Function")]
		public List<Function> Function { get; set; }
		
		// CONSTRUCTOR
		public Database()
		{}
	}
}
