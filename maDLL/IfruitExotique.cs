using System;
using System.Collections.Generic;
using System.Text;

namespace maDLL {
    public interface IfruitExotique {
        bool SeBoit();
        string VientDe();
    }

    public class Banane : IfruitExotique {
        bool IfruitExotique.SeBoit() {
            return false;
        }
        string IfruitExotique.VientDe() {
            return "Guadeloupe";
        }
    }


}
