using System;
using System.Xml;
using System.IO;
using System.Reflection;
using System.Collections.Generic;

namespace TaskWin {
	public class Settings {

		public enum DataType { STRING, INT, BOOL, DATE };		// settings data types variations
		public readonly String version;							// application version

		private XmlDocument xmlDoc = new XmlDocument();
		private String settingsFileName;

		private Dictionary<string, dynamic> options = new Dictionary<string, dynamic>();
		private Dictionary<string, DataType> optionTypes = new Dictionary<string, DataType>();

		/// <summary>
		/// Settings management class
		/// </summary>
		public Settings() {
			settingsFileName = Path.ChangeExtension(Assembly.GetExecutingAssembly().Location, "xml");
			version = getVersion();
		}


		/// <summary>
		/// Add a parameter to the settings with default type=string and default value=""
		/// </summary>
		/// <param name="name">name of the parameter</param>
		public void add(String name) { add(name, DataType.STRING, ""); }

		/// <summary>
		/// Add a parameter to the settings with the default value (int=0, bool=false, string="" or date=Now)
		/// </summary>
		/// <param name="name">name of the parameter</param>
		/// <param name="type">data type of the parameter</param>
		public void add(String name, DataType type) { 
			switch (type) {
				case DataType.INT:	add(name, type, 0); break;
				case DataType.BOOL:	add(name, type, false); break;
				case DataType.DATE:	add(name, type, DateTime.Now); break;
				default:			add(name, type, ""); break;
			}

		}

		/// <summary>
		/// Add a parameter to the settings
		/// </summary>
		/// <param name="name">name of the parameter</param>
		/// <param name="type">data type of the parameter</param>
		/// <param name="value">default value of the parameter</param>
		public void add(String name, DataType type, dynamic value) {
			options[name] = value;
			optionTypes.Add(name, type);
		}

		/// <summary>
		/// Sets a new value for a parameter
		/// </summary>
		/// <param name="name">name of the parameter</param>
		/// <param name="value">value of the parameter</param>
		public void set(String name, dynamic value) { options[name] = value; }

		/// <summary>
		/// Get a parameter from the settings
		/// </summary>
		/// <returns>Value of the predefined type</returns>
		public dynamic get(String name) {
			if (xmlDoc == null || xmlDoc.DocumentType == null) Read();
			switch (optionTypes[name]) {
				case DataType.INT:	return (int)options[name];
				case DataType.BOOL:	return (Boolean)options[name];
				case DataType.DATE:	return (DateTime)options[name];
				default:			return options[name] as String;
			}
		}


		/// <summary>
		/// Convert string value from XML to the correct data type
		/// </summary>
		private dynamic setValue(String name, String value) {
			switch (optionTypes[name]) {
				case DataType.INT:	if (value.Length>0) return int.Parse(value); else return options[name];
				case DataType.BOOL:	if (value.Length > 0) return bool.Parse(value); else return options[name];
				case DataType.DATE:	if (value.Length > 0) return DateTime.Parse(value); else return options[name];
				default:			return value; 
			}
		}

		/// <summary>
		/// Read settings from xml file
		/// </summary>
		public void Read() {
			try {
				if (File.Exists(settingsFileName)) xmlDoc.Load(settingsFileName);
				else throw new XmlException("Settings file not found");
			}
			catch (XmlException e) { }

			XmlNode temp, settings = xmlDoc.SelectSingleNode("/settings");
			if (settings != null) {
				Dictionary<string, dynamic>.KeyCollection keys = options.Keys;				// key names
				Dictionary<string, dynamic> opts = new Dictionary<string, dynamic>();		// temp array

				foreach (string key in keys) {
					temp = settings.SelectSingleNode(key);
					if (temp != null) opts[key] = setValue(key, temp.InnerText);
					else opts[key] = options[key];
				}
				options = opts;
			}
		}


		/// <summary>
		/// Save settings to the xml file
		/// </summary>
		public void Save() {
			XmlTextWriter writer = new XmlTextWriter(settingsFileName, System.Text.Encoding.UTF8);
			writer.WriteStartDocument();
			writer.WriteRaw("\n<settings>\n");
			 foreach(KeyValuePair<string, dynamic> node in options)
				writer.WriteRaw("	<"+node.Key+">" + node.Value.ToString() + "</"+node.Key+">\n");
			writer.WriteRaw("</settings>");
			writer.Close();
		}


		/// <summary>
		/// Get application version as string
		/// </summary>
		private String getVersion() {
			Version version = Assembly.GetExecutingAssembly().GetName().Version;
			return version.ToString();
		}

	}

}
