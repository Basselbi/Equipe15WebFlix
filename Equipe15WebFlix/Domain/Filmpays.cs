using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator.Constraints;


namespace Equipe15WebFlix.domain {
    
    public class Filmpays {
        public virtual Pays Pays { get; set; }
        public virtual Film Film { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Filmpays;
			if (t == null) return false;
			if (Pays.Paysid == t.Pays.Paysid
			 && Film.Filmid == t.Film.Filmid)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ Pays.Paysid.GetHashCode();
			hash = (hash * 397) ^ Film.Filmid.GetHashCode();

			return hash;
        }
        #endregion
    }
}
