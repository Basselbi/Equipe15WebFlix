using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator.Constraints;


namespace Equipe15WebFlix.domain {
    
    public class Informationpersonel {
        public virtual decimal Personelid { get; set; }
        [Length(100)]
        public virtual string Nom { get; set; }
        public virtual DateTime? Datenaissance { get; set; }
        [Length(75)]
        public virtual string Lieunaissance { get; set; }
        [Length(4000)]
        public virtual string Biographie { get; set; }
    }
}
