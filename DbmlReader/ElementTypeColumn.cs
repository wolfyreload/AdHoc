using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace DbmlReader
{
	
	public class ElementTypeColumn
	{
		// ATTRIBUTES
		[XmlAttribute("Name")]
		public string Name { get; set; }
		
		[XmlAttribute("Type")]
		public string Type { get; set; }
		
		[XmlAttribute("DbType")]
		public string DbType { get; set; }
		
		[XmlIgnore]
		public bool CanBeNull { get; set; }
		[XmlAttribute("CanBeNull")]
		public string CanBeNullString
		{
			get { return CanBeNull ? "true" : "false"; }
			set { CanBeNull = value == "true"; }
		}
		
		[XmlAttribute("Member")]
		public string Member { get; set; }
		
		// ELEMENTS
		[XmlText]
		public string Value { get; set; }
		
		// CONSTRUCTOR
		public ElementTypeColumn()
		{}
	}
}
