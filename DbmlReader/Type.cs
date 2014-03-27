using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace DbmlReader
{
	
	public class Type
	{
		// ATTRIBUTES
		[XmlAttribute("Name")]
		public string Name { get; set; }
		
		[XmlElement("Column")]
		public List<TypeColumn> TypeColumn { get; set; }

        // ELEMENTS
        [XmlElement("Association")]
        public List<Association> Association { get; set; }
		

		// CONSTRUCTOR
		public Type()
		{}
	}
}
