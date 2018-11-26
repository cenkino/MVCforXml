using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WordCount.Models
{
    [Serializable]
    [XmlRoot("WordsList"), XmlType("WordsList")]
    public class WordsList
    {
        
        public string text { get; set; }
        public int count { get; set; }
    }
}