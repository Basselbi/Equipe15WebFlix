using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator.Constraints;


namespace Equipe15WebFlix.domain {
    
    public class Genre {
        public Genre() {
			Filmgenre = new List<Filmgenre>();
        }
        public virtual decimal Genreid { get; set; }
        [NotNullNotEmpty]
        [Length(50)]
        public virtual string Nomgenre { get; set; }
        public virtual IList<Filmgenre> Filmgenre { get; set; }
    }
}
