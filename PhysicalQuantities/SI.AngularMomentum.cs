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
      public static partial class AngularMomentum
      {
        public static BaseUnit NewtonMetreSecond { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaNewtonMetreSecond { get; private set; }
        public static ScaledUnit ZettaNewtonMetreSecond { get; private set; }
        public static ScaledUnit ExaNewtonMetreSecond { get; private set; }
        public static ScaledUnit PetaNewtonMetreSecond { get; private set; }
        public static ScaledUnit TeraNewtonMetreSecond { get; private set; }
        public static ScaledUnit GigaNewtonMetreSecond { get; private set; }
        public static ScaledUnit MegaNewtonMetreSecond { get; private set; }
        public static ScaledUnit KiloNewtonMetreSecond { get; private set; }
        public static ScaledUnit HectoNewtonMetreSecond { get; private set; }
        public static ScaledUnit DecaNewtonMetreSecond { get; private set; }
        public static ScaledUnit DeciNewtonMetreSecond { get; private set; }
        public static ScaledUnit CentiNewtonMetreSecond { get; private set; }
        public static ScaledUnit MilliNewtonMetreSecond { get; private set; }
        public static ScaledUnit MicroNewtonMetreSecond { get; private set; }
        public static ScaledUnit NanoNewtonMetreSecond { get; private set; }
        public static ScaledUnit PicoNewtonMetreSecond { get; private set; }
        public static ScaledUnit FemtoNewtonMetreSecond { get; private set; }
        public static ScaledUnit AttoNewtonMetreSecond { get; private set; }
        public static ScaledUnit ZeptoNewtonMetreSecond { get; private set; }
        public static ScaledUnit YoctoNewtonMetreSecond { get; private set; }

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
          NewtonMetreSecond = new BaseUnit(@"NewtonMetreSecond", @"N·m·s", PhysicalQuantities.Quantities.AngularMomentum, unitSystem) { Caption = @"newton-metro-segundo" };
          YottaNewtonMetreSecond = new ScaledUnit(@"YottaNewtonMetreSecond", @"YN·m·s", NewtonMetreSecond, 1E+24, 0.0) { Caption = @"yottanewton-metro-segundo" };
          ZettaNewtonMetreSecond = new ScaledUnit(@"ZettaNewtonMetreSecond", @"ZN·m·s", NewtonMetreSecond, 1E+21, 0.0) { Caption = @"zettanewton-metro-segundo" };
          ExaNewtonMetreSecond = new ScaledUnit(@"ExaNewtonMetreSecond", @"EN·m·s", NewtonMetreSecond, 1E+18, 0.0) { Caption = @"exanewton-metro-segundo" };
          PetaNewtonMetreSecond = new ScaledUnit(@"PetaNewtonMetreSecond", @"PN·m·s", NewtonMetreSecond, 1E+15, 0.0) { Caption = @"petanewton-metro-segundo" };
          TeraNewtonMetreSecond = new ScaledUnit(@"TeraNewtonMetreSecond", @"TN·m·s", NewtonMetreSecond, 1000000000000, 0.0) { Caption = @"teranewton-metro-segundo" };
          GigaNewtonMetreSecond = new ScaledUnit(@"GigaNewtonMetreSecond", @"GN·m·s", NewtonMetreSecond, 1000000000, 0.0) { Caption = @"giganewton-metro-segundo" };
          MegaNewtonMetreSecond = new ScaledUnit(@"MegaNewtonMetreSecond", @"MN·m·s", NewtonMetreSecond, 1000000, 0.0) { Caption = @"meganewton-metro-segundo" };
          KiloNewtonMetreSecond = new ScaledUnit(@"KiloNewtonMetreSecond", @"kN·m·s", NewtonMetreSecond, 1000, 0.0) { Caption = @"kilonewton-metro-segundo" };
          HectoNewtonMetreSecond = new ScaledUnit(@"HectoNewtonMetreSecond", @"hN·m·s", NewtonMetreSecond, 100, 0.0) { Caption = @"hectonewton-metro-segundo" };
          DecaNewtonMetreSecond = new ScaledUnit(@"DecaNewtonMetreSecond", @"daN·m·s", NewtonMetreSecond, 10, 0.0) { Caption = @"decanewton-metro-segundo" };
          DeciNewtonMetreSecond = new ScaledUnit(@"DeciNewtonMetreSecond", @"dN·m·s", NewtonMetreSecond, 0.1, 0.0) { Caption = @"decinewton-metro-segundo" };
          CentiNewtonMetreSecond = new ScaledUnit(@"CentiNewtonMetreSecond", @"cN·m·s", NewtonMetreSecond, 0.01, 0.0) { Caption = @"centinewton-metro-segundo" };
          MilliNewtonMetreSecond = new ScaledUnit(@"MilliNewtonMetreSecond", @"mN·m·s", NewtonMetreSecond, 0.001, 0.0) { Caption = @"milinewton-metro-segundo" };
          MicroNewtonMetreSecond = new ScaledUnit(@"MicroNewtonMetreSecond", @"μN·m·s", NewtonMetreSecond, 1E-06, 0.0) { Caption = @"micronewton-metro-segundo" };
          NanoNewtonMetreSecond = new ScaledUnit(@"NanoNewtonMetreSecond", @"nN·m·s", NewtonMetreSecond, 1E-09, 0.0) { Caption = @"nanonewton-metro-segundo" };
          PicoNewtonMetreSecond = new ScaledUnit(@"PicoNewtonMetreSecond", @"pN·m·s", NewtonMetreSecond, 1E-12, 0.0) { Caption = @"piconewton-metro-segundo" };
          FemtoNewtonMetreSecond = new ScaledUnit(@"FemtoNewtonMetreSecond", @"fN·m·s", NewtonMetreSecond, 1E-15, 0.0) { Caption = @"femtonewton-metro-segundo" };
          AttoNewtonMetreSecond = new ScaledUnit(@"AttoNewtonMetreSecond", @"aN·m·s", NewtonMetreSecond, 1E-18, 0.0) { Caption = @"attonewton-metro-segundo" };
          ZeptoNewtonMetreSecond = new ScaledUnit(@"ZeptoNewtonMetreSecond", @"zN·m·s", NewtonMetreSecond, 1E-21, 0.0) { Caption = @"zeptonewton-metro-segundo" };
          YoctoNewtonMetreSecond = new ScaledUnit(@"YoctoNewtonMetreSecond", @"yN·m·s", NewtonMetreSecond, 1E-24, 0.0) { Caption = @"yoctonewton-metro-segundo" };

          allUnits = new Dictionary<string, Unit>
          {
            { NewtonMetreSecond.Name, NewtonMetreSecond },
            { YottaNewtonMetreSecond.Name, YottaNewtonMetreSecond },
            { ZettaNewtonMetreSecond.Name, ZettaNewtonMetreSecond },
            { ExaNewtonMetreSecond.Name, ExaNewtonMetreSecond },
            { PetaNewtonMetreSecond.Name, PetaNewtonMetreSecond },
            { TeraNewtonMetreSecond.Name, TeraNewtonMetreSecond },
            { GigaNewtonMetreSecond.Name, GigaNewtonMetreSecond },
            { MegaNewtonMetreSecond.Name, MegaNewtonMetreSecond },
            { KiloNewtonMetreSecond.Name, KiloNewtonMetreSecond },
            { HectoNewtonMetreSecond.Name, HectoNewtonMetreSecond },
            { DecaNewtonMetreSecond.Name, DecaNewtonMetreSecond },
            { DeciNewtonMetreSecond.Name, DeciNewtonMetreSecond },
            { CentiNewtonMetreSecond.Name, CentiNewtonMetreSecond },
            { MilliNewtonMetreSecond.Name, MilliNewtonMetreSecond },
            { MicroNewtonMetreSecond.Name, MicroNewtonMetreSecond },
            { NanoNewtonMetreSecond.Name, NanoNewtonMetreSecond },
            { PicoNewtonMetreSecond.Name, PicoNewtonMetreSecond },
            { FemtoNewtonMetreSecond.Name, FemtoNewtonMetreSecond },
            { AttoNewtonMetreSecond.Name, AttoNewtonMetreSecond },
            { ZeptoNewtonMetreSecond.Name, ZeptoNewtonMetreSecond },
            { YoctoNewtonMetreSecond.Name, YoctoNewtonMetreSecond },
          };
        }

        static AngularMomentum()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
