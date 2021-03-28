using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace laba1
{
    class ResearchTeam
    {
        string topic;
        string organization;
        int regNum;
        TimeFrame info;
        Paper[] papersList;

        public string Topic
        {
            get { return topic; }
            set { topic = value; }
        }

        public string Organization
        {
            get { return organization; }
            set { organization = value; }
        }

        public int RegNum
        {
            get { return regNum; }
            set { regNum = value; }
        }

        public TimeFrame Info
        {
            get { return info; }
            set { info = value; }
        }

        public Paper[] PapersList
        {
            get { return papersList; }
            set { papersList = value; }
        }

        public ResearchTeam(string topic, string org, int regNum, TimeFrame info)
        {
            Topic = topic;
            Organization = org;
            RegNum = regNum;
            Info = info;
            papersList = new Paper[] { new Paper() };
        }

        public ResearchTeam()
        {
            Topic = "NoTopic";
            Organization = "NoNameOrg";
            RegNum = 0;
            Info = 0;
            papersList = new Paper[] { new Paper() };
        }

        public Paper LastPaper
        {
            get { return papersList[papersList.Length - 1]; }
        }

        public bool this[TimeFrame timeFr]
        {
            get
            {
                if (timeFr == info) return true;
                else return false;
            }
        }

        public void AddPapers(params Paper[] p)
        {
            Paper[] temp = new Paper[papersList.Length + p.Length];
            temp = papersList.Concat(p).ToArray();
            papersList = temp;
        }

        public override string ToString()
        {
            string s = "Topic: " +  topic + "; Organization: " + organization + "; RegNum: " + regNum + "; Info: " + info + "\n" + "Papers\n";
            for (int i = 0; i < papersList.Length; i++)
            {
                s += papersList[i].ToString();
                s += "\n";
            }
            return s;
        }

        public virtual string ToShortString()
        {
            string s = topic + " " + organization + " " + regNum + " " + info;
            return s;
        }
    }
}
