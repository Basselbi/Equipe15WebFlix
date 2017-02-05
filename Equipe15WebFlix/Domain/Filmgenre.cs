using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator.Constraints;


namespace Equipe15WebFlix.domain {
    
    public class Filmgenre {
        public virtual Genre Genre { get; set; }
        public virtual Film Film { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Filmgenre;
			if (t == null) return false;
			if (Genre.Genreid == t.Genre.Genreid
			 && Film.Filmid == t.Film.Filmid)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ Genre.Genreid.GetHashCode();
			hash = (hash * 397) ^ Film.Filmid.GetHashCode();

			return hash;
        }
        #endregion
    }
}
