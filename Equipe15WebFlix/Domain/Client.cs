using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator.Constraints;


namespace Equipe15WebFlix.domain {
    
    public class Client {
        public Client() {
			Cartecredit = new List<Cartecredit>();
			Location = new List<Location>();
        }
        public virtual decimal Userid { get; set; }
        public virtual Forfait Forfait { get; set; }
        public virtual IList<Cartecredit> Cartecredit { get; set; }
        public virtual IList<Location> Location { get; set; }
    }
}
