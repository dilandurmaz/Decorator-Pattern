using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Siparis;

namespace Siparis
{
  public abstract class Hamburger
    {
        string açıklama = "Hamburger bilinmiyor";
        public string Açıklama()
        {
            return açıklama;
        }
        public abstract double cost();
    }
    public abstract class Decorator:Hamburger
    {
        public new abstract string Açıklama();
    }
    public class TavukluHamburger : Hamburger
    {   
        public new string Açıklama()
        {
            return "Tavuklu Hamburger";

        }

        public override double cost()
        {
            return 10;
        }
    }

    public class EtliHamburger : Hamburger
    {
        public new string Açıklama()
        {
            return "Etli Hamburger";

        }

        public override double cost()
        {
            return 15;
        }
    }
    public class VeganHamburger : Hamburger
    {
        public new string Açıklama()
        {
            return "Vegan Hamburger";

        }

        public override double cost()
        {
            return 13;
        }
    }
    public class Ketçap : Decorator
    {
        Hamburger hamburger;
        public Ketçap(Hamburger hamburger)
        {
            this.hamburger = hamburger;
        }
        public override string Açıklama()
        {
            return hamburger.Açıklama()+"Ketçap";
        }

        public override double cost()
        {
            return 0.25 + hamburger.cost();
        }
    }
    public class Mayonez : Decorator
    {
        Hamburger hamburger;
        public Mayonez(Hamburger hamburger)
        {
            this.hamburger = hamburger;
        }
        public override string Açıklama()
        {
            return hamburger.Açıklama() + "Mayonez";
        }

        public override double cost()
        {
            return 0.25 + hamburger.cost();
        }
    }
    public class RanchSos: Decorator
    {
        Hamburger hamburger;
        public RanchSos(Hamburger hamburger)
        {
            this.hamburger = hamburger;
        }
        public override string Açıklama()
        {
            return hamburger.Açıklama() + "Ranch Sos";
        }

        public override double cost()
        {
            return 1.25 + hamburger.cost();
        }
    }
    public class Domates : Decorator
    {
        Hamburger hamburger;
        public Domates(Hamburger hamburger)
        {
            this.hamburger = hamburger;
        }
        public override string Açıklama()
        {
            return hamburger.Açıklama() + "Domates";
        }

        public override double cost()
        {
            return 0.75 + hamburger.cost();
        }
    }
    public class Cheddar : Decorator
    {
        Hamburger hamburger;
        public Cheddar(Hamburger hamburger)
        {
            this.hamburger = hamburger;
        }
        public override string Açıklama()
        {
            return hamburger.Açıklama() + "Cheddar";
        }

        public override double cost()
        {
            return 1.00 + hamburger.cost();
        }
    }
    public class Turşu : Decorator
    {
        Hamburger hamburger;
        public Turşu(Hamburger hamburger)
        {
            this.hamburger = hamburger;
        }
        public override string Açıklama()
        {
            return hamburger.Açıklama() + "Turşu";
        }

        public override double cost()
        {
            return 0.50 + hamburger.cost();
        }
    }

}
