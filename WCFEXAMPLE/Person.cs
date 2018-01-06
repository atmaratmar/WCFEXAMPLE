using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFEXAMPLE
{
    [DataContract]
    public class Person
    {


        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Navn { get; set; }
        [DataMember]
        public string Art { get; set; }
        [DataMember]
        public double Vaegt { get; set; }
        [DataMember]
        public string Sted { get; set; }
        [DataMember]
        public int Uge { get; set; }

        public Person(int id, string navn, string art, double vaegt, string sted, int uge)
        {
            ID = id;
            Navn = navn;
            Art = art;
            Vaegt = vaegt;
            Sted = sted;
            Uge = uge;
        }

        public Person()
        {

        }

    }
}