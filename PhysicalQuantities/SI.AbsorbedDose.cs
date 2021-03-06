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
      public static partial class AbsorbedDose
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Gray_(unit)
        /// </summary>
        public static BaseUnit Gray { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaGray { get; private set; }
        public static ScaledUnit ZettaGray { get; private set; }
        public static ScaledUnit ExaGray { get; private set; }
        public static ScaledUnit PetaGray { get; private set; }
        public static ScaledUnit TeraGray { get; private set; }
        public static ScaledUnit GigaGray { get; private set; }
        public static ScaledUnit MegaGray { get; private set; }
        public static ScaledUnit KiloGray { get; private set; }
        public static ScaledUnit HectoGray { get; private set; }
        public static ScaledUnit DecaGray { get; private set; }
        public static ScaledUnit DeciGray { get; private set; }
        public static ScaledUnit CentiGray { get; private set; }
        public static ScaledUnit MilliGray { get; private set; }
        public static ScaledUnit MicroGray { get; private set; }
        public static ScaledUnit NanoGray { get; private set; }
        public static ScaledUnit PicoGray { get; private set; }
        public static ScaledUnit FemtoGray { get; private set; }
        public static ScaledUnit AttoGray { get; private set; }
        public static ScaledUnit ZeptoGray { get; private set; }
        public static ScaledUnit YoctoGray { get; private set; }

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
          Gray = new BaseUnit(@"Gray", @"Gy", PhysicalQuantities.Quantities.AbsorbedDose, unitSystem) { Caption = @"gray" };
          YottaGray = new ScaledUnit(@"YottaGray", @"YGy", Gray, 1E+24, 0.0) { Caption = @"yottagray" };
          ZettaGray = new ScaledUnit(@"ZettaGray", @"ZGy", Gray, 1E+21, 0.0) { Caption = @"zettagray" };
          ExaGray = new ScaledUnit(@"ExaGray", @"EGy", Gray, 1E+18, 0.0) { Caption = @"exagray" };
          PetaGray = new ScaledUnit(@"PetaGray", @"PGy", Gray, 1E+15, 0.0) { Caption = @"petagray" };
          TeraGray = new ScaledUnit(@"TeraGray", @"TGy", Gray, 1000000000000, 0.0) { Caption = @"teragray" };
          GigaGray = new ScaledUnit(@"GigaGray", @"GGy", Gray, 1000000000, 0.0) { Caption = @"gigagray" };
          MegaGray = new ScaledUnit(@"MegaGray", @"MGy", Gray, 1000000, 0.0) { Caption = @"megagray" };
          KiloGray = new ScaledUnit(@"KiloGray", @"kGy", Gray, 1000, 0.0) { Caption = @"kilogray" };
          HectoGray = new ScaledUnit(@"HectoGray", @"hGy", Gray, 100, 0.0) { Caption = @"hectogray" };
          DecaGray = new ScaledUnit(@"DecaGray", @"daGy", Gray, 10, 0.0) { Caption = @"decagray" };
          DeciGray = new ScaledUnit(@"DeciGray", @"dGy", Gray, 0.1, 0.0) { Caption = @"decigray" };
          CentiGray = new ScaledUnit(@"CentiGray", @"cGy", Gray, 0.01, 0.0) { Caption = @"centigray" };
          MilliGray = new ScaledUnit(@"MilliGray", @"mGy", Gray, 0.001, 0.0) { Caption = @"miligray" };
          MicroGray = new ScaledUnit(@"MicroGray", @"μGy", Gray, 1E-06, 0.0) { Caption = @"microgray" };
          NanoGray = new ScaledUnit(@"NanoGray", @"nGy", Gray, 1E-09, 0.0) { Caption = @"nanogray" };
          PicoGray = new ScaledUnit(@"PicoGray", @"pGy", Gray, 1E-12, 0.0) { Caption = @"picogray" };
          FemtoGray = new ScaledUnit(@"FemtoGray", @"fGy", Gray, 1E-15, 0.0) { Caption = @"femtogray" };
          AttoGray = new ScaledUnit(@"AttoGray", @"aGy", Gray, 1E-18, 0.0) { Caption = @"attogray" };
          ZeptoGray = new ScaledUnit(@"ZeptoGray", @"zGy", Gray, 1E-21, 0.0) { Caption = @"zeptogray" };
          YoctoGray = new ScaledUnit(@"YoctoGray", @"yGy", Gray, 1E-24, 0.0) { Caption = @"yoctogray" };

          allUnits = new Dictionary<string, Unit>
          {
            { Gray.Name, Gray },
            { YottaGray.Name, YottaGray },
            { ZettaGray.Name, ZettaGray },
            { ExaGray.Name, ExaGray },
            { PetaGray.Name, PetaGray },
            { TeraGray.Name, TeraGray },
            { GigaGray.Name, GigaGray },
            { MegaGray.Name, MegaGray },
            { KiloGray.Name, KiloGray },
            { HectoGray.Name, HectoGray },
            { DecaGray.Name, DecaGray },
            { DeciGray.Name, DeciGray },
            { CentiGray.Name, CentiGray },
            { MilliGray.Name, MilliGray },
            { MicroGray.Name, MicroGray },
            { NanoGray.Name, NanoGray },
            { PicoGray.Name, PicoGray },
            { FemtoGray.Name, FemtoGray },
            { AttoGray.Name, AttoGray },
            { ZeptoGray.Name, ZeptoGray },
            { YoctoGray.Name, YoctoGray },
          };
        }

        static AbsorbedDose()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
