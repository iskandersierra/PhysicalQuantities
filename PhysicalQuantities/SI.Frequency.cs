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
      public static partial class Frequency
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Hertz
        /// </summary>
        public static BaseUnit Hertz { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaHertz { get; private set; }
        public static ScaledUnit ZettaHertz { get; private set; }
        public static ScaledUnit ExaHertz { get; private set; }
        public static ScaledUnit PetaHertz { get; private set; }
        public static ScaledUnit TeraHertz { get; private set; }
        public static ScaledUnit GigaHertz { get; private set; }
        public static ScaledUnit MegaHertz { get; private set; }
        public static ScaledUnit KiloHertz { get; private set; }
        public static ScaledUnit HectoHertz { get; private set; }
        public static ScaledUnit DecaHertz { get; private set; }
        public static ScaledUnit DeciHertz { get; private set; }
        public static ScaledUnit CentiHertz { get; private set; }
        public static ScaledUnit MilliHertz { get; private set; }
        public static ScaledUnit MicroHertz { get; private set; }
        public static ScaledUnit NanoHertz { get; private set; }
        public static ScaledUnit PicoHertz { get; private set; }
        public static ScaledUnit FemtoHertz { get; private set; }
        public static ScaledUnit AttoHertz { get; private set; }
        public static ScaledUnit ZeptoHertz { get; private set; }
        public static ScaledUnit YoctoHertz { get; private set; }

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
          Hertz = new BaseUnit(@"Hertz", @"Hz", PhysicalQuantities.Quantities.Frequency, unitSystem) { Caption = @"hertz" };
          YottaHertz = new ScaledUnit(@"YottaHertz", @"YHz", Hertz, 1E+24, 0.0) { Caption = @"yottahertz" };
          ZettaHertz = new ScaledUnit(@"ZettaHertz", @"ZHz", Hertz, 1E+21, 0.0) { Caption = @"zettahertz" };
          ExaHertz = new ScaledUnit(@"ExaHertz", @"EHz", Hertz, 1E+18, 0.0) { Caption = @"exahertz" };
          PetaHertz = new ScaledUnit(@"PetaHertz", @"PHz", Hertz, 1E+15, 0.0) { Caption = @"petahertz" };
          TeraHertz = new ScaledUnit(@"TeraHertz", @"THz", Hertz, 1000000000000, 0.0) { Caption = @"terahertz" };
          GigaHertz = new ScaledUnit(@"GigaHertz", @"GHz", Hertz, 1000000000, 0.0) { Caption = @"gigahertz" };
          MegaHertz = new ScaledUnit(@"MegaHertz", @"MHz", Hertz, 1000000, 0.0) { Caption = @"megahertz" };
          KiloHertz = new ScaledUnit(@"KiloHertz", @"kHz", Hertz, 1000, 0.0) { Caption = @"kilohertz" };
          HectoHertz = new ScaledUnit(@"HectoHertz", @"hHz", Hertz, 100, 0.0) { Caption = @"hectohertz" };
          DecaHertz = new ScaledUnit(@"DecaHertz", @"daHz", Hertz, 10, 0.0) { Caption = @"decahertz" };
          DeciHertz = new ScaledUnit(@"DeciHertz", @"dHz", Hertz, 0.1, 0.0) { Caption = @"decihertz" };
          CentiHertz = new ScaledUnit(@"CentiHertz", @"cHz", Hertz, 0.01, 0.0) { Caption = @"centihertz" };
          MilliHertz = new ScaledUnit(@"MilliHertz", @"mHz", Hertz, 0.001, 0.0) { Caption = @"milihertz" };
          MicroHertz = new ScaledUnit(@"MicroHertz", @"μHz", Hertz, 1E-06, 0.0) { Caption = @"microhertz" };
          NanoHertz = new ScaledUnit(@"NanoHertz", @"nHz", Hertz, 1E-09, 0.0) { Caption = @"nanohertz" };
          PicoHertz = new ScaledUnit(@"PicoHertz", @"pHz", Hertz, 1E-12, 0.0) { Caption = @"picohertz" };
          FemtoHertz = new ScaledUnit(@"FemtoHertz", @"fHz", Hertz, 1E-15, 0.0) { Caption = @"femtohertz" };
          AttoHertz = new ScaledUnit(@"AttoHertz", @"aHz", Hertz, 1E-18, 0.0) { Caption = @"attohertz" };
          ZeptoHertz = new ScaledUnit(@"ZeptoHertz", @"zHz", Hertz, 1E-21, 0.0) { Caption = @"zeptohertz" };
          YoctoHertz = new ScaledUnit(@"YoctoHertz", @"yHz", Hertz, 1E-24, 0.0) { Caption = @"yoctohertz" };

          allUnits = new Dictionary<string, Unit>
          {
            { Hertz.Name, Hertz },
            { YottaHertz.Name, YottaHertz },
            { ZettaHertz.Name, ZettaHertz },
            { ExaHertz.Name, ExaHertz },
            { PetaHertz.Name, PetaHertz },
            { TeraHertz.Name, TeraHertz },
            { GigaHertz.Name, GigaHertz },
            { MegaHertz.Name, MegaHertz },
            { KiloHertz.Name, KiloHertz },
            { HectoHertz.Name, HectoHertz },
            { DecaHertz.Name, DecaHertz },
            { DeciHertz.Name, DeciHertz },
            { CentiHertz.Name, CentiHertz },
            { MilliHertz.Name, MilliHertz },
            { MicroHertz.Name, MicroHertz },
            { NanoHertz.Name, NanoHertz },
            { PicoHertz.Name, PicoHertz },
            { FemtoHertz.Name, FemtoHertz },
            { AttoHertz.Name, AttoHertz },
            { ZeptoHertz.Name, ZeptoHertz },
            { YoctoHertz.Name, YoctoHertz },
          };
        }

        static Frequency()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
