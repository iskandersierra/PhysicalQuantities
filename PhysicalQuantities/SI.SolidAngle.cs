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
      public static partial class SolidAngle
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Steradian
        /// </summary>
        public static BaseUnit Steradian { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaSteradian { get; private set; }
        public static ScaledUnit ZettaSteradian { get; private set; }
        public static ScaledUnit ExaSteradian { get; private set; }
        public static ScaledUnit PetaSteradian { get; private set; }
        public static ScaledUnit TeraSteradian { get; private set; }
        public static ScaledUnit GigaSteradian { get; private set; }
        public static ScaledUnit MegaSteradian { get; private set; }
        public static ScaledUnit KiloSteradian { get; private set; }
        public static ScaledUnit HectoSteradian { get; private set; }
        public static ScaledUnit DecaSteradian { get; private set; }
        public static ScaledUnit DeciSteradian { get; private set; }
        public static ScaledUnit CentiSteradian { get; private set; }
        public static ScaledUnit MilliSteradian { get; private set; }
        public static ScaledUnit MicroSteradian { get; private set; }
        public static ScaledUnit NanoSteradian { get; private set; }
        public static ScaledUnit PicoSteradian { get; private set; }
        public static ScaledUnit FemtoSteradian { get; private set; }
        public static ScaledUnit AttoSteradian { get; private set; }
        public static ScaledUnit ZeptoSteradian { get; private set; }
        public static ScaledUnit YoctoSteradian { get; private set; }

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
          Steradian = new BaseUnit(@"Steradian", @"sr", PhysicalQuantities.Quantities.SolidAngle, unitSystem) { Caption = @"estereoradián" };
          YottaSteradian = new ScaledUnit(@"YottaSteradian", @"Ysr", Steradian, 1E+24, 0.0) { Caption = @"yottaestereoradián" };
          ZettaSteradian = new ScaledUnit(@"ZettaSteradian", @"Zsr", Steradian, 1E+21, 0.0) { Caption = @"zettaestereoradián" };
          ExaSteradian = new ScaledUnit(@"ExaSteradian", @"Esr", Steradian, 1E+18, 0.0) { Caption = @"exaestereoradián" };
          PetaSteradian = new ScaledUnit(@"PetaSteradian", @"Psr", Steradian, 1E+15, 0.0) { Caption = @"petaestereoradián" };
          TeraSteradian = new ScaledUnit(@"TeraSteradian", @"Tsr", Steradian, 1000000000000, 0.0) { Caption = @"teraestereoradián" };
          GigaSteradian = new ScaledUnit(@"GigaSteradian", @"Gsr", Steradian, 1000000000, 0.0) { Caption = @"gigaestereoradián" };
          MegaSteradian = new ScaledUnit(@"MegaSteradian", @"Msr", Steradian, 1000000, 0.0) { Caption = @"megaestereoradián" };
          KiloSteradian = new ScaledUnit(@"KiloSteradian", @"ksr", Steradian, 1000, 0.0) { Caption = @"kiloestereoradián" };
          HectoSteradian = new ScaledUnit(@"HectoSteradian", @"hsr", Steradian, 100, 0.0) { Caption = @"hectoestereoradián" };
          DecaSteradian = new ScaledUnit(@"DecaSteradian", @"dasr", Steradian, 10, 0.0) { Caption = @"decaestereoradián" };
          DeciSteradian = new ScaledUnit(@"DeciSteradian", @"dsr", Steradian, 0.1, 0.0) { Caption = @"deciestereoradián" };
          CentiSteradian = new ScaledUnit(@"CentiSteradian", @"csr", Steradian, 0.01, 0.0) { Caption = @"centiestereoradián" };
          MilliSteradian = new ScaledUnit(@"MilliSteradian", @"msr", Steradian, 0.001, 0.0) { Caption = @"miliestereoradián" };
          MicroSteradian = new ScaledUnit(@"MicroSteradian", @"μsr", Steradian, 1E-06, 0.0) { Caption = @"microestereoradián" };
          NanoSteradian = new ScaledUnit(@"NanoSteradian", @"nsr", Steradian, 1E-09, 0.0) { Caption = @"nanoestereoradián" };
          PicoSteradian = new ScaledUnit(@"PicoSteradian", @"psr", Steradian, 1E-12, 0.0) { Caption = @"picoestereoradián" };
          FemtoSteradian = new ScaledUnit(@"FemtoSteradian", @"fsr", Steradian, 1E-15, 0.0) { Caption = @"femtoestereoradián" };
          AttoSteradian = new ScaledUnit(@"AttoSteradian", @"asr", Steradian, 1E-18, 0.0) { Caption = @"attoestereoradián" };
          ZeptoSteradian = new ScaledUnit(@"ZeptoSteradian", @"zsr", Steradian, 1E-21, 0.0) { Caption = @"zeptoestereoradián" };
          YoctoSteradian = new ScaledUnit(@"YoctoSteradian", @"ysr", Steradian, 1E-24, 0.0) { Caption = @"yoctoestereoradián" };

          allUnits = new Dictionary<string, Unit>
          {
            { Steradian.Name, Steradian },
            { YottaSteradian.Name, YottaSteradian },
            { ZettaSteradian.Name, ZettaSteradian },
            { ExaSteradian.Name, ExaSteradian },
            { PetaSteradian.Name, PetaSteradian },
            { TeraSteradian.Name, TeraSteradian },
            { GigaSteradian.Name, GigaSteradian },
            { MegaSteradian.Name, MegaSteradian },
            { KiloSteradian.Name, KiloSteradian },
            { HectoSteradian.Name, HectoSteradian },
            { DecaSteradian.Name, DecaSteradian },
            { DeciSteradian.Name, DeciSteradian },
            { CentiSteradian.Name, CentiSteradian },
            { MilliSteradian.Name, MilliSteradian },
            { MicroSteradian.Name, MicroSteradian },
            { NanoSteradian.Name, NanoSteradian },
            { PicoSteradian.Name, PicoSteradian },
            { FemtoSteradian.Name, FemtoSteradian },
            { AttoSteradian.Name, AttoSteradian },
            { ZeptoSteradian.Name, ZeptoSteradian },
            { YoctoSteradian.Name, YoctoSteradian },
          };
        }

        static SolidAngle()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
