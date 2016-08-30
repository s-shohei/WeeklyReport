using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyReport.model
{
    [System.Xml.Serialization.XmlRoot("setting")]

    public class SettingTextModel
    {
        [System.Xml.Serialization.XmlElement("division")]
        public String division { get; set; }

        [System.Xml.Serialization.XmlElement("project")]
        public String project { get; set; }

        [System.Xml.Serialization.XmlElement("unit")]
        public String unit { get; set; }

        [System.Xml.Serialization.XmlElement("name")]
        public String name { get; set; }

        [System.Xml.Serialization.XmlElement("lastweek_mondai")]
        public String lastweek_mondai { get; set; }

        [System.Xml.Serialization.XmlElement("lastweek_result")]
        public String lastweek_result { get; set; }

    }
}
