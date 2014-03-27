using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace DbmlReader
{
	
	public class Return
	{
		// ATTRIBUTES
		[XmlAttribute("Type")]
		public string Type { get; set; }
		
		[XmlAttribute("DbType")]
		public string DbType { get; set; }
		
		// ELEMENTS
		[XmlText]
		public string Value { get; set; }
		
		// CONSTRUCTOR
		public Return()
		{}
	}
}
