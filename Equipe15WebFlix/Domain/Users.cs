using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator.Constraints;


namespace Equipe15WebFlix.domain {
    
    public class Users {
        public virtual decimal Userid { get; set; }
        [NotNullNotEmpty]
        [Length(50)]
        public virtual string Nom { get; set; }
        [NotNullNotEmpty]
        [Length(50)]
        public virtual string Prenom { get; set; }
        [Length(100)]
        public virtual string Courriel { get; set; }
        [NotNullNotEmpty]
        [Length(250)]
        public virtual string Adresse { get; set; }
        [NotNullNotEmpty]
        [Length(50)]
        public virtual string Ville { get; set; }
        [NotNullNotEmpty]
        [Length(20)]
        public virtual string Province { get; set; }
        [NotNullNotEmpty]
        [Length(7)]
        public virtual string Codepostal { get; set; }
        [NotNullNotEmpty]
        [Length(12)]
        public virtual string Notelephone { get; set; }
        [NotNullNotEmpty]
        public virtual DateTime Datenaissance { get; set; }
        [NotNullNotEmpty]
        [Length(21)]
        public virtual string Motdepass { get; set; }
    }
}
