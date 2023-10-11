﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Kommentar
    {
        public Kommentar(Bruger? bruger, string tekst) 
        {
        this.Bruger = bruger;
        this.Tekst = tekst;
        Dato = DateTime.Now;
        Antal_Stemmer = 0;
        Upvote = 0;
        Downvote = 0;
        }
        public int Kommentar_Id { get; set; }
        public string Tekst { get; set; }
        public DateTime Dato { get; set; }
        public int? Antal_Stemmer { get; set; }
        public int? Upvote { get; set; }
        public int? Downvote { get; set; }
        public Bruger? Bruger { get; set; }

    }
}
