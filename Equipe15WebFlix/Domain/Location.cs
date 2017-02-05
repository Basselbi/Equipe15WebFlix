using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator.Constraints;


namespace Equipe15WebFlix.domain {
    
    public class Location {
        public virtual decimal Locationid { get; set; }
        public virtual Film Film { get; set; }
        public virtual Client Client { get; set; }
        [NotNullNotEmpty]
        public virtual DateTime Datedebut { get; set; }
        public virtual DateTime? Dateretour { get; set; }
    }
}
