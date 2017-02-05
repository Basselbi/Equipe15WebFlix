using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator.Constraints;


namespace Equipe15WebFlix.domain {
    
    public class Employe {
        public virtual decimal Userid { get; set; }
        [NotNullNotEmpty]
        [Length(24)]
        public virtual string Matricule { get; set; }
    }
}
