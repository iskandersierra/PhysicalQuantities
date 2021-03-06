using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public static partial class UnitSystems
  {
    public static partial class SI
    {
      public static partial class Angle
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Radian
        /// </summary>
        public static BaseUnit Radian { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaRadian { get; private set; }
        public static ScaledUnit ZettaRadian { get; private set; }
        public static ScaledUnit ExaRadian { get; private set; }
        public static ScaledUnit PetaRadian { get; private set; }
        public static ScaledUnit TeraRadian { get; private set; }
        public static ScaledUnit GigaRadian { get; private set; }
        public static ScaledUnit MegaRadian { get; private set; }
        public static ScaledUnit KiloRadian { get; private set; }
        public static ScaledUnit HectoRadian { get; private set; }
        public static ScaledUnit DecaRadian { get; private set; }
        public static ScaledUnit DeciRadian { get; private set; }
        public static ScaledUnit CentiRadian { get; private set; }
        public static ScaledUnit MilliRadian { get; private set; }
        public static ScaledUnit MicroRadian { get; private set; }
        public static ScaledUnit NanoRadian { get; private set; }
        public static ScaledUnit PicoRadian { get; private set; }
        public static ScaledUnit FemtoRadian { get; private set; }
        public static ScaledUnit AttoRadian { get; private set; }
        public static ScaledUnit ZeptoRadian { get; private set; }
        public static ScaledUnit YoctoRadian { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Degree_(angle)
        /// </summary>
        public static ScaledUnit Degree { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Arcminute
        /// </summary>
        public static ScaledUnit Arcminute { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Arcsecond
        /// </summary>
        public static ScaledUnit Arcsecond { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Arcsecond#Symbols_and_abbreviations
        /// </summary>
        public static ScaledUnit Milliarcsecond { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Arcsecond#Symbols_and_abbreviations
        /// </summary>
        public static ScaledUnit Microarcsecond { get; private set; }

        #region [ Lookup ]
        private static Dictionary<string, Unit> allUnits;
        public static Unit GetUnit(string unitName)
        {
          Unit result;
          if (allUnits.TryGetValue(unitName, out result))
            return result;
          return null;
        }
        public static IEnumerable<Unit> AllUnits
        {
          get
          {
            return allUnits.Values;
          }
        }
        #endregion [ Lookup ]

        internal static void Initialize(UnitSystem unitSystem)
        {
          Radian = new BaseUnit(@"Radian", @"rad", PhysicalQuantities.Quantities.Angle, unitSystem) { Caption = @"radian" };
          YottaRadian = new ScaledUnit(@"YottaRadian", @"Yrad", Radian, 1E+24, 0.0) { Caption = @"yottaradian" };
          ZettaRadian = new ScaledUnit(@"ZettaRadian", @"Zrad", Radian, 1E+21, 0.0) { Caption = @"zettaradian" };
          ExaRadian = new ScaledUnit(@"ExaRadian", @"Erad", Radian, 1E+18, 0.0) { Caption = @"exaradian" };
          PetaRadian = new ScaledUnit(@"PetaRadian", @"Prad", Radian, 1E+15, 0.0) { Caption = @"petaradian" };
          TeraRadian = new ScaledUnit(@"TeraRadian", @"Trad", Radian, 1000000000000, 0.0) { Caption = @"teraradian" };
          GigaRadian = new ScaledUnit(@"GigaRadian", @"Grad", Radian, 1000000000, 0.0) { Caption = @"gigaradian" };
          MegaRadian = new ScaledUnit(@"MegaRadian", @"Mrad", Radian, 1000000, 0.0) { Caption = @"megaradian" };
          KiloRadian = new ScaledUnit(@"KiloRadian", @"krad", Radian, 1000, 0.0) { Caption = @"kiloradian" };
          HectoRadian = new ScaledUnit(@"HectoRadian", @"hrad", Radian, 100, 0.0) { Caption = @"hectoradian" };
          DecaRadian = new ScaledUnit(@"DecaRadian", @"darad", Radian, 10, 0.0) { Caption = @"decaradian" };
          DeciRadian = new ScaledUnit(@"DeciRadian", @"drad", Radian, 0.1, 0.0) { Caption = @"deciradian" };
          CentiRadian = new ScaledUnit(@"CentiRadian", @"crad", Radian, 0.01, 0.0) { Caption = @"centiradian" };
          MilliRadian = new ScaledUnit(@"MilliRadian", @"mrad", Radian, 0.001, 0.0) { Caption = @"miliradian" };
          MicroRadian = new ScaledUnit(@"MicroRadian", @"μrad", Radian, 1E-06, 0.0) { Caption = @"microradian" };
          NanoRadian = new ScaledUnit(@"NanoRadian", @"nrad", Radian, 1E-09, 0.0) { Caption = @"nanoradian" };
          PicoRadian = new ScaledUnit(@"PicoRadian", @"prad", Radian, 1E-12, 0.0) { Caption = @"picoradian" };
          FemtoRadian = new ScaledUnit(@"FemtoRadian", @"frad", Radian, 1E-15, 0.0) { Caption = @"femtoradian" };
          AttoRadian = new ScaledUnit(@"AttoRadian", @"arad", Radian, 1E-18, 0.0) { Caption = @"attoradian" };
          ZeptoRadian = new ScaledUnit(@"ZeptoRadian", @"zrad", Radian, 1E-21, 0.0) { Caption = @"zeptoradian" };
          YoctoRadian = new ScaledUnit(@"YoctoRadian", @"yrad", Radian, 1E-24, 0.0) { Caption = @"yoctoradian" };
          Degree = new ScaledUnit(@"Degree", @"°", Radian, 0.0174532925199433, 0) { Caption = @"grado" };
          Arcminute = new ScaledUnit(@"Arcminute", @"'", Degree, 0.0166666666666667, 0) { Caption = @"minuto de arco" };
          Arcsecond = new ScaledUnit(@"Arcsecond", @"""", Arcminute, 0.0166666666666667, 0) { Caption = @"segundo de arco" };
          Milliarcsecond = new ScaledUnit(@"Milliarcsecond", @"mas", Arcsecond, 0.001, 0) { Caption = @"milisegundo de arco" };
          Microarcsecond = new ScaledUnit(@"Microarcsecond", @"μas", Milliarcsecond, 0.001, 0) { Caption = @"microsegundo de arco" };

          allUnits = new Dictionary<string, Unit>
          {
            { Radian.Name, Radian },
            { YottaRadian.Name, YottaRadian },
            { ZettaRadian.Name, ZettaRadian },
            { ExaRadian.Name, ExaRadian },
            { PetaRadian.Name, PetaRadian },
            { TeraRadian.Name, TeraRadian },
            { GigaRadian.Name, GigaRadian },
            { MegaRadian.Name, MegaRadian },
            { KiloRadian.Name, KiloRadian },
            { HectoRadian.Name, HectoRadian },
            { DecaRadian.Name, DecaRadian },
            { DeciRadian.Name, DeciRadian },
            { CentiRadian.Name, CentiRadian },
            { MilliRadian.Name, MilliRadian },
            { MicroRadian.Name, MicroRadian },
            { NanoRadian.Name, NanoRadian },
            { PicoRadian.Name, PicoRadian },
            { FemtoRadian.Name, FemtoRadian },
            { AttoRadian.Name, AttoRadian },
            { ZeptoRadian.Name, ZeptoRadian },
            { YoctoRadian.Name, YoctoRadian },
            { Degree.Name, Degree },
            { Arcminute.Name, Arcminute },
            { Arcsecond.Name, Arcsecond },
            { Milliarcsecond.Name, Milliarcsecond },
            { Microarcsecond.Name, Microarcsecond },
          };
        }

        static Angle()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
