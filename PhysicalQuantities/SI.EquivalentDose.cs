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
      public static partial class EquivalentDose
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Sievert
        /// </summary>
        public static BaseUnit Sievert { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaSievert { get; private set; }
        public static ScaledUnit ZettaSievert { get; private set; }
        public static ScaledUnit ExaSievert { get; private set; }
        public static ScaledUnit PetaSievert { get; private set; }
        public static ScaledUnit TeraSievert { get; private set; }
        public static ScaledUnit GigaSievert { get; private set; }
        public static ScaledUnit MegaSievert { get; private set; }
        public static ScaledUnit KiloSievert { get; private set; }
        public static ScaledUnit HectoSievert { get; private set; }
        public static ScaledUnit DecaSievert { get; private set; }
        public static ScaledUnit DeciSievert { get; private set; }
        public static ScaledUnit CentiSievert { get; private set; }
        public static ScaledUnit MilliSievert { get; private set; }
        public static ScaledUnit MicroSievert { get; private set; }
        public static ScaledUnit NanoSievert { get; private set; }
        public static ScaledUnit PicoSievert { get; private set; }
        public static ScaledUnit FemtoSievert { get; private set; }
        public static ScaledUnit AttoSievert { get; private set; }
        public static ScaledUnit ZeptoSievert { get; private set; }
        public static ScaledUnit YoctoSievert { get; private set; }

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
          Sievert = new BaseUnit(@"Sievert", @"Sv", PhysicalQuantities.Quantities.EquivalentDose, unitSystem) { Caption = @"sievert" };
          YottaSievert = new ScaledUnit(@"YottaSievert", @"YSv", Sievert, 1E+24, 0.0) { Caption = @"yottasievert" };
          ZettaSievert = new ScaledUnit(@"ZettaSievert", @"ZSv", Sievert, 1E+21, 0.0) { Caption = @"zettasievert" };
          ExaSievert = new ScaledUnit(@"ExaSievert", @"ESv", Sievert, 1E+18, 0.0) { Caption = @"exasievert" };
          PetaSievert = new ScaledUnit(@"PetaSievert", @"PSv", Sievert, 1E+15, 0.0) { Caption = @"petasievert" };
          TeraSievert = new ScaledUnit(@"TeraSievert", @"TSv", Sievert, 1000000000000, 0.0) { Caption = @"terasievert" };
          GigaSievert = new ScaledUnit(@"GigaSievert", @"GSv", Sievert, 1000000000, 0.0) { Caption = @"gigasievert" };
          MegaSievert = new ScaledUnit(@"MegaSievert", @"MSv", Sievert, 1000000, 0.0) { Caption = @"megasievert" };
          KiloSievert = new ScaledUnit(@"KiloSievert", @"kSv", Sievert, 1000, 0.0) { Caption = @"kilosievert" };
          HectoSievert = new ScaledUnit(@"HectoSievert", @"hSv", Sievert, 100, 0.0) { Caption = @"hectosievert" };
          DecaSievert = new ScaledUnit(@"DecaSievert", @"daSv", Sievert, 10, 0.0) { Caption = @"decasievert" };
          DeciSievert = new ScaledUnit(@"DeciSievert", @"dSv", Sievert, 0.1, 0.0) { Caption = @"decisievert" };
          CentiSievert = new ScaledUnit(@"CentiSievert", @"cSv", Sievert, 0.01, 0.0) { Caption = @"centisievert" };
          MilliSievert = new ScaledUnit(@"MilliSievert", @"mSv", Sievert, 0.001, 0.0) { Caption = @"milisievert" };
          MicroSievert = new ScaledUnit(@"MicroSievert", @"μSv", Sievert, 1E-06, 0.0) { Caption = @"microsievert" };
          NanoSievert = new ScaledUnit(@"NanoSievert", @"nSv", Sievert, 1E-09, 0.0) { Caption = @"nanosievert" };
          PicoSievert = new ScaledUnit(@"PicoSievert", @"pSv", Sievert, 1E-12, 0.0) { Caption = @"picosievert" };
          FemtoSievert = new ScaledUnit(@"FemtoSievert", @"fSv", Sievert, 1E-15, 0.0) { Caption = @"femtosievert" };
          AttoSievert = new ScaledUnit(@"AttoSievert", @"aSv", Sievert, 1E-18, 0.0) { Caption = @"attosievert" };
          ZeptoSievert = new ScaledUnit(@"ZeptoSievert", @"zSv", Sievert, 1E-21, 0.0) { Caption = @"zeptosievert" };
          YoctoSievert = new ScaledUnit(@"YoctoSievert", @"ySv", Sievert, 1E-24, 0.0) { Caption = @"yoctosievert" };

          allUnits = new Dictionary<string, Unit>
          {
            { Sievert.Name, Sievert },
            { YottaSievert.Name, YottaSievert },
            { ZettaSievert.Name, ZettaSievert },
            { ExaSievert.Name, ExaSievert },
            { PetaSievert.Name, PetaSievert },
            { TeraSievert.Name, TeraSievert },
            { GigaSievert.Name, GigaSievert },
            { MegaSievert.Name, MegaSievert },
            { KiloSievert.Name, KiloSievert },
            { HectoSievert.Name, HectoSievert },
            { DecaSievert.Name, DecaSievert },
            { DeciSievert.Name, DeciSievert },
            { CentiSievert.Name, CentiSievert },
            { MilliSievert.Name, MilliSievert },
            { MicroSievert.Name, MicroSievert },
            { NanoSievert.Name, NanoSievert },
            { PicoSievert.Name, PicoSievert },
            { FemtoSievert.Name, FemtoSievert },
            { AttoSievert.Name, AttoSievert },
            { ZeptoSievert.Name, ZeptoSievert },
            { YoctoSievert.Name, YoctoSievert },
          };
        }

        static EquivalentDose()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
