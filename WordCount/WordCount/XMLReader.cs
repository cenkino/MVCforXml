using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WordCount.Models;

namespace WordCount
{
    public class XMLReader
    {
        public List<WordsList> ReturnWord()
        {
            string xmlData = HttpContext.Current.Server.MapPath("~/App_Data/mobydick.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(xmlData);
            var wordList = new List<WordsList>();
            wordList = (from rows in ds.Tables[0].AsEnumerable()
                        select new WordsList
                        {
                            text = rows[1].ToString(),
                            count = rows[0]!=null ? Convert.ToInt32(rows[0]) : 0
                        }).OrderByDescending(x => x.count).ToList();
            return wordList;
        }
    }
}