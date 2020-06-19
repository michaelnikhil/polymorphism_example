using System;
using System.Collections.Generic;
using System.Text;

namespace maDLL {
    public class Fruit : Vegetal {
        public bool HasPepins = false;

        //constructeurs surchages
        public Fruit() { }
        public Fruit(bool arg) {
            HasPepins = arg;
        }

        public override string SeMange() {
            return "au dessert";
        }

        public override string SeNourrit() {
            return "pluie et soleil";
        }

        public override string SeReproduit() {
            return "abeilles et oiseaux";
        }

        public string PresenceDePepins() {
            if (HasPepins) {
                return "oui, il y a des pepins";
            } else {
                return "non, pas de pepins";
            }
        }

        }

    public class Pomme : Fruit {

        public Pomme() {
            this.HasPepins = true;
        }

        public override string SeMange() {
            return "au dessert et au gouter";
        }
    }
    }

