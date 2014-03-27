using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace DbmlReader
{
	
	public class TypeColumn
	{
		// ATTRIBUTES
		[XmlAttribute("Name")]
		public string Name { get; set; }
		
		[XmlAttribute("Type")]
		public string Type { get; set; }
		
		[XmlAttribute("DbType")]
		public string DbType { get; set; }
		
		[XmlIgnore]
		public bool? IsPrimaryKey { get; set; }
		[XmlAttribute("IsPrimaryKey")]
		public string IsPrimaryKeyString
		{
            get { return (IsPrimaryKey ?? false) ? "true" : "false"; }
			set
			{
                if (String.IsNullOrEmpty(value)) IsPrimaryKey = null;
				else IsPrimaryKey = value == "true";
			}
		}
		
		[XmlIgnore]
		public bool? IsDbGenerated { get; set; }
		[XmlAttribute("IsDbGenerated")]
		public string IsDbGeneratedString
		{
            get { return (IsDbGenerated ?? false) ? "true" : "false"; }
			set
			{
                if (String.IsNullOrEmpty(value)) IsDbGenerated = null;
				else IsDbGenerated = value == "true";
			}
		}
		
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
		
		[XmlAttribute("UpdateCheck")]
		public string UpdateCheck { get; set; }
		
		[XmlIgnore]
		public bool? IsVersion { get; set; }
        [XmlIgnore]
        //[XmlAttribute("IsVersion")]
		public string IsVersionString
		{
            get { return (IsVersion ?? false) ? "true" : "false"; }
			set
			{
                if (String.IsNullOrEmpty(value)) IsVersion = null;
				else IsVersion = value == "true";
			}
		}
		
		// ELEMENTS
		[XmlText]
		public string Value { get; set; }
		
		// CONSTRUCTOR
		public TypeColumn()
		{}
	}
}
