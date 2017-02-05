using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator.Constraints;


namespace Equipe15WebFlix.domain {
    
    public class Scenariste {
        public Scenariste() {
			Scenaristefilm = new List<Scenaristefilm>();
        }
        public virtual decimal Scenaristeid { get; set; }
        [Length(100)]
        public virtual string Nomscenariste { get; set; }
        public virtual IList<Scenaristefilm> Scenaristefilm { get; set; }
    }
}
