using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeeklyReport.common;
using WeeklyReport.model;
using System.Xml;
using WeeklyReport.util;



namespace WeeklyReport.model
{
    [System.Xml.Serialization.XmlRoot("save_text")]

    public class SaveTextModel
    {
        [System.Xml.Serialization.XmlElement("sunday")]
        public String sunday { get; set; }

        [System.Xml.Serialization.XmlElement("sunday_start_hh")]
        public String sunday_start_hh { get; set; }

        [System.Xml.Serialization.XmlElement("sunday_start_mm")]
        public String sunday_start_mm { get; set; }

        [System.Xml.Serialization.XmlElement("sunday_end_hh")]
        public String sunday_end_hh { get; set; }

        [System.Xml.Serialization.XmlElement("sunday_end_mm")]
        public String sunday_end_mm { get; set; }

        [System.Xml.Serialization.XmlElement("monday")]
        public String monday { get; set; }

        [System.Xml.Serialization.XmlElement("monday_start_hh")]
        public String monday_start_hh { get; set; }

        [System.Xml.Serialization.XmlElement("monday_start_mm")]
        public String monday_start_mm { get; set; }

        [System.Xml.Serialization.XmlElement("monday_end_hh")]
        public String monday_end_hh { get; set; }

        [System.Xml.Serialization.XmlElement("monday_end_mm")]
        public String monday_end_mm { get; set; }

        [System.Xml.Serialization.XmlElement("tuesday")]
        public String tuesday { get; set; }

        [System.Xml.Serialization.XmlElement("tuesday_start_hh")]
        public String tuesday_start_hh { get; set; }

        [System.Xml.Serialization.XmlElement("tuesday_start_mm")]
        public String tuesday_start_mm { get; set; }

        [System.Xml.Serialization.XmlElement("tuesday_end_hh")]
        public String tuesday_end_hh { get; set; }

        [System.Xml.Serialization.XmlElement("tuesday_end_mm")]
        public String tuesday_end_mm { get; set; }

        [System.Xml.Serialization.XmlElement("wednesday")]
        public String wednesday { get; set; }

        [System.Xml.Serialization.XmlElement("wednesday_start_hh")]
        public String wednesday_start_hh { get; set; }

        [System.Xml.Serialization.XmlElement("wednesday_start_mm")]
        public String wednesday_start_mm { get; set; }

        [System.Xml.Serialization.XmlElement("wednesday_end_hh")]
        public String wednesday_end_hh { get; set; }

        [System.Xml.Serialization.XmlElement("wednesday_end_mm")]
        public String wednesday_end_mm { get; set; }

        [System.Xml.Serialization.XmlElement("thursday")]
        public String thursday { get; set; }

        [System.Xml.Serialization.XmlElement("thursday_start_hh")]
        public String thursday_start_hh { get; set; }

        [System.Xml.Serialization.XmlElement("thursday_start_mm")]
        public String thursday_start_mm { get; set; }

        [System.Xml.Serialization.XmlElement("thursday_end_hh")]
        public String thursday_end_hh { get; set; }

        [System.Xml.Serialization.XmlElement("thursday_end_mm")]
        public String thursday_end_mm { get; set; }

        [System.Xml.Serialization.XmlElement("friday")]
        public String friday { get; set; }

        [System.Xml.Serialization.XmlElement("friday_start_hh")]
        public String friday_start_hh { get; set; }

        [System.Xml.Serialization.XmlElement("friday_start_mm")]
        public String friday_start_mm { get; set; }

        [System.Xml.Serialization.XmlElement("friday_end_hh")]
        public String friday_end_hh { get; set; }

        [System.Xml.Serialization.XmlElement("friday_end_mm")]
        public String friday_end_mm { get; set; }

        [System.Xml.Serialization.XmlElement("saturday")]
        public String saturday { get; set; }

        [System.Xml.Serialization.XmlElement("saturday_start_hh")]
        public String saturday_start_hh { get; set; }

        [System.Xml.Serialization.XmlElement("saturday_start_mm")]
        public String saturday_start_mm { get; set; }

        [System.Xml.Serialization.XmlElement("saturday_end_hh")]
        public String saturday_end_hh { get; set; }

        [System.Xml.Serialization.XmlElement("saturday_end_mm")]
        public String saturday_end_mm { get; set; }

    }
}
