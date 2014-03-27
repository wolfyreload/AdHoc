using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace DbmlReader
{
	
	public class Connection
	{
		// ATTRIBUTES
		[XmlAttribute("Mode")]
		public string Mode { get; set; }
		
		[XmlAttribute("ConnectionString")]
		public string ConnectionString { get; set; }
		
		[XmlAttribute("SettingsObjectName")]
		public string SettingsObjectName { get; set; }
		
		[XmlAttribute("SettingsPropertyName")]
		public string SettingsPropertyName { get; set; }
		
		[XmlAttribute("Provider")]
		public string Provider { get; set; }
		
		// ELEMENTS
		[XmlText]
		public string Value { get; set; }
		
		// CONSTRUCTOR
		public Connection()
		{}
	}
}
