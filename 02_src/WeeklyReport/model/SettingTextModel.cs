﻿using System;
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

        [System.Xml.Serialization.XmlElement("lastweek_mondai_gyomu")]
        public String lastweek_mondai_gyomu { get; set; }

        [System.Xml.Serialization.XmlElement("lastweek_mondai_jiko")]
        public String lastweek_mondai_jiko { get; set; }

        [System.Xml.Serialization.XmlElement("lastweek_result_gyomu")]
        public String lastweek_result_gyomu { get; set; }

        [System.Xml.Serialization.XmlElement("lastweek_result_jiko")]
        public String lastweek_result_jiko { get; set; }

        [System.Xml.Serialization.XmlElement("kadoutei")]
        public String kadou_tei_value { get; set; }

        [System.Xml.Serialization.XmlElement("kadouchu")]
        public String kadou_chu_value { get; set; }

        [System.Xml.Serialization.XmlElement("kadoukou")]
        public String kadou_kou_value { get; set; }

    }
}
