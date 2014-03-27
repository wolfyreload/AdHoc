using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace DbmlReader
{
	
	public class Function
	{
		// ATTRIBUTES
		[XmlAttribute("Name")]
		public string Name { get; set; }
		
		[XmlAttribute("Method")]
		public string Method { get; set; }
		
		[XmlIgnore]
		public bool? IsComposable { get; set; }
        
        [XmlIgnore]
        //[XmlAttribute("IsComposable")]
		public string IsComposableString
		{
            get { return (IsComposable ?? false) ? "true" : "false"; }
			set
			{
				if (String.IsNullOrEmpty(value)) IsComposable = null;
				else IsComposable = value == "true";
			}
		}
		
		// ELEMENTS
		[XmlElement("Parameter")]
		public List<Parameter> Parameter { get; set; }
		
		[XmlElement("Return")]
		public Return Return { get; set; }
		
		[XmlElement("ElementType")]
		public ElementType ElementType { get; set; }
		
		// CONSTRUCTOR
		public Function()
		{}
	}
}
