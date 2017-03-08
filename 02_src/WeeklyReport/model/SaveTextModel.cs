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
        [System.Xml.Serialization.XmlElement("write")]
        public String write { get; set; }

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

        [System.Xml.Serialization.XmlElement("sunday_kadou")]
        public String sunday_kadou { get; set; }

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

        [System.Xml.Serialization.XmlElement("monday_kadou")]
        public String monday_kadou { get; set; }

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

        [System.Xml.Serialization.XmlElement("tuesday_kadou")]
        public String tuesday_kadou { get; set; }

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

        [System.Xml.Serialization.XmlElement("wednesday_kadou")]
        public String wednesday_kadou { get; set; }

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

        [System.Xml.Serialization.XmlElement("thursday_kadou")]
        public String thursday_kadou { get; set; }

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

        [System.Xml.Serialization.XmlElement("friday_kadou")]
        public String friday_kadou { get; set; }

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

        [System.Xml.Serialization.XmlElement("saturday_kadou")]
        public String saturday_kadou { get; set; }

        [System.Xml.Serialization.XmlElement("mondaikaizen_gyomu")]
        public String mondaikaizen_gyomu { get; set; }

        [System.Xml.Serialization.XmlElement("mondaikaizen_jiko")]
        public String mondaikaizen_jiko { get; set; }

        [System.Xml.Serialization.XmlElement("result_gyomu")]
        public String result_gyomu { get; set; }

        [System.Xml.Serialization.XmlElement("result_jiko")]
        public String result_jiko { get; set; }

        [System.Xml.Serialization.XmlElement("saying_gyoumunai")]
        public String saying_gyoumunai { get; set; }

        [System.Xml.Serialization.XmlElement("saying_gyoumugai")]
        public String saying_gyoumugai { get; set; }

    }
}
