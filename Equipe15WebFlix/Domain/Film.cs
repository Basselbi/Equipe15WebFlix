using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator.Constraints;


namespace Equipe15WebFlix.domain {
    
    public class Film {
        public Film() {
			Filmgenre = new List<Filmgenre>();
			Scenaristefilm = new List<Scenaristefilm>();
			Location = new List<Location>();
			Role = new List<Role>();
			Filmpays = new List<Filmpays>();
        }
        public virtual decimal Filmid { get; set; }
        public virtual Informationpersonnel Informationpersonnel { get; set; }
        [Length(150)]
        public virtual string Titre { get; set; }
        public virtual decimal? Annesortie { get; set; }
        [Length(50)]
        public virtual string Langue { get; set; }
        public virtual decimal? Duree { get; set; }
        [Length(4000)]
        public virtual string Resume { get; set; }
        [Length(250)]
        public virtual string Poster { get; set; }
        public virtual decimal? Qtytotal { get; set; }
        public virtual decimal? Qtydisponible { get; set; }
        public virtual IList<Filmgenre> Filmgenre { get; set; }
        public virtual IList<Scenaristefilm> Scenaristefilm { get; set; }
        public virtual IList<Location> Location { get; set; }
        public virtual IList<Role> Role { get; set; }
        public virtual IList<Filmpays> Filmpays { get; set; }
    }
}
