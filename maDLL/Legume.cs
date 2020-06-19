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
    }
}
