using System;
using System.Collections.Generic;
using System.Text;

namespace maDLL {
    public class Legume : Vegetal {
        public override string SeMange() {
            return "cuisson vapeur";
        }

        public override string SeNourrit() {
            return "arrosage intensif";
        }

        public override string SeReproduit() {
            return "semences";
        }

        public string Preparation() {
            return "epluchage";
        }
    }

    public class Haricots : Legume {

        //polymorphisme de substitution forcee
        public new string Preparation() {
            return "pas d'epluchage";
        }
    }
    public class Poireaux : Legume {
        public override string SeMange() {
            return "cuisson vapeur et wok";
        }
    }
    }
