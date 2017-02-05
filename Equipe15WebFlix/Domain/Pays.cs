using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator.Constraints;


namespace Equipe15WebFlix.domain {
    
    public class Pays {
        public Pays() {
			Filmpays = new List<Filmpays>();
        }
        public virtual decimal Paysid { get; set; }
        [Length(100)]
        public virtual string Nom { get; set; }
        public virtual IList<Filmpays> Filmpays { get; set; }
    }
}
