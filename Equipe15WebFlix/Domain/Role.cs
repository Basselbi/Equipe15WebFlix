using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator.Constraints;


namespace Equipe15WebFlix.domain {
    
    public class Role {
        public virtual Film Film { get; set; }
        public virtual Informationpersonnel Informationpersonnel { get; set; }
        [Length(100)]
        public virtual string Nompersonnage { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Role;
			if (t == null) return false;
			if (Film.Filmid == t.Film.Filmid
			 && Informationpersonnel.Personelid == t.Informationpersonnel.Personelid)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ Film.Filmid.GetHashCode();
			hash = (hash * 397) ^ Informationpersonnel.Personelid.GetHashCode();

			return hash;
        }
        #endregion
    }
}
