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
      public static partial class AreaDensity
      {
        public static BaseUnit KilogramPerSquareMetre { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit ZettaKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit ExaKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit PetaKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit TeraKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit GigaKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit MegaKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit KiloKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit HectoKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit DecaKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit DeciKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit CentiKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit MilliKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit MicroKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit NanoKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit PicoKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit FemtoKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit AttoKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit ZeptoKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit YoctoKilogramPerSquareMetre { get; private set; }

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
          KilogramPerSquareMetre = new BaseUnit(@"KilogramPerSquareMetre", @"kg/m²", PhysicalQuantities.Quantities.AreaDensity, unitSystem) { Caption = @"kilogramo por metro cuadrado" };
          YottaKilogramPerSquareMetre = new ScaledUnit(@"YottaKilogramPerSquareMetre", @"Ykg/m²", KilogramPerSquareMetre, 1E+24, 0.0) { Caption = @"yottakilogramo por metro cuadrado" };
          ZettaKilogramPerSquareMetre = new ScaledUnit(@"ZettaKilogramPerSquareMetre", @"Zkg/m²", KilogramPerSquareMetre, 1E+21, 0.0) { Caption = @"zettakilogramo por metro cuadrado" };
          ExaKilogramPerSquareMetre = new ScaledUnit(@"ExaKilogramPerSquareMetre", @"Ekg/m²", KilogramPerSquareMetre, 1E+18, 0.0) { Caption = @"exakilogramo por metro cuadrado" };
          PetaKilogramPerSquareMetre = new ScaledUnit(@"PetaKilogramPerSquareMetre", @"Pkg/m²", KilogramPerSquareMetre, 1E+15, 0.0) { Caption = @"petakilogramo por metro cuadrado" };
          TeraKilogramPerSquareMetre = new ScaledUnit(@"TeraKilogramPerSquareMetre", @"Tkg/m²", KilogramPerSquareMetre, 1000000000000, 0.0) { Caption = @"terakilogramo por metro cuadrado" };
          GigaKilogramPerSquareMetre = new ScaledUnit(@"GigaKilogramPerSquareMetre", @"Gkg/m²", KilogramPerSquareMetre, 1000000000, 0.0) { Caption = @"gigakilogramo por metro cuadrado" };
          MegaKilogramPerSquareMetre = new ScaledUnit(@"MegaKilogramPerSquareMetre", @"Mkg/m²", KilogramPerSquareMetre, 1000000, 0.0) { Caption = @"megakilogramo por metro cuadrado" };
          KiloKilogramPerSquareMetre = new ScaledUnit(@"KiloKilogramPerSquareMetre", @"kkg/m²", KilogramPerSquareMetre, 1000, 0.0) { Caption = @"kilokilogramo por metro cuadrado" };
          HectoKilogramPerSquareMetre = new ScaledUnit(@"HectoKilogramPerSquareMetre", @"hkg/m²", KilogramPerSquareMetre, 100, 0.0) { Caption = @"hectokilogramo por metro cuadrado" };
          DecaKilogramPerSquareMetre = new ScaledUnit(@"DecaKilogramPerSquareMetre", @"dakg/m²", KilogramPerSquareMetre, 10, 0.0) { Caption = @"decakilogramo por metro cuadrado" };
          DeciKilogramPerSquareMetre = new ScaledUnit(@"DeciKilogramPerSquareMetre", @"dkg/m²", KilogramPerSquareMetre, 0.1, 0.0) { Caption = @"decikilogramo por metro cuadrado" };
          CentiKilogramPerSquareMetre = new ScaledUnit(@"CentiKilogramPerSquareMetre", @"ckg/m²", KilogramPerSquareMetre, 0.01, 0.0) { Caption = @"centikilogramo por metro cuadrado" };
          MilliKilogramPerSquareMetre = new ScaledUnit(@"MilliKilogramPerSquareMetre", @"mkg/m²", KilogramPerSquareMetre, 0.001, 0.0) { Caption = @"milikilogramo por metro cuadrado" };
          MicroKilogramPerSquareMetre = new ScaledUnit(@"MicroKilogramPerSquareMetre", @"μkg/m²", KilogramPerSquareMetre, 1E-06, 0.0) { Caption = @"microkilogramo por metro cuadrado" };
          NanoKilogramPerSquareMetre = new ScaledUnit(@"NanoKilogramPerSquareMetre", @"nkg/m²", KilogramPerSquareMetre, 1E-09, 0.0) { Caption = @"nanokilogramo por metro cuadrado" };
          PicoKilogramPerSquareMetre = new ScaledUnit(@"PicoKilogramPerSquareMetre", @"pkg/m²", KilogramPerSquareMetre, 1E-12, 0.0) { Caption = @"picokilogramo por metro cuadrado" };
          FemtoKilogramPerSquareMetre = new ScaledUnit(@"FemtoKilogramPerSquareMetre", @"fkg/m²", KilogramPerSquareMetre, 1E-15, 0.0) { Caption = @"femtokilogramo por metro cuadrado" };
          AttoKilogramPerSquareMetre = new ScaledUnit(@"AttoKilogramPerSquareMetre", @"akg/m²", KilogramPerSquareMetre, 1E-18, 0.0) { Caption = @"attokilogramo por metro cuadrado" };
          ZeptoKilogramPerSquareMetre = new ScaledUnit(@"ZeptoKilogramPerSquareMetre", @"zkg/m²", KilogramPerSquareMetre, 1E-21, 0.0) { Caption = @"zeptokilogramo por metro cuadrado" };
          YoctoKilogramPerSquareMetre = new ScaledUnit(@"YoctoKilogramPerSquareMetre", @"ykg/m²", KilogramPerSquareMetre, 1E-24, 0.0) { Caption = @"yoctokilogramo por metro cuadrado" };

          allUnits = new Dictionary<string, Unit>
          {
            { KilogramPerSquareMetre.Name, KilogramPerSquareMetre },
            { YottaKilogramPerSquareMetre.Name, YottaKilogramPerSquareMetre },
            { ZettaKilogramPerSquareMetre.Name, ZettaKilogramPerSquareMetre },
            { ExaKilogramPerSquareMetre.Name, ExaKilogramPerSquareMetre },
            { PetaKilogramPerSquareMetre.Name, PetaKilogramPerSquareMetre },
            { TeraKilogramPerSquareMetre.Name, TeraKilogramPerSquareMetre },
            { GigaKilogramPerSquareMetre.Name, GigaKilogramPerSquareMetre },
            { MegaKilogramPerSquareMetre.Name, MegaKilogramPerSquareMetre },
            { KiloKilogramPerSquareMetre.Name, KiloKilogramPerSquareMetre },
            { HectoKilogramPerSquareMetre.Name, HectoKilogramPerSquareMetre },
            { DecaKilogramPerSquareMetre.Name, DecaKilogramPerSquareMetre },
            { DeciKilogramPerSquareMetre.Name, DeciKilogramPerSquareMetre },
            { CentiKilogramPerSquareMetre.Name, CentiKilogramPerSquareMetre },
            { MilliKilogramPerSquareMetre.Name, MilliKilogramPerSquareMetre },
            { MicroKilogramPerSquareMetre.Name, MicroKilogramPerSquareMetre },
            { NanoKilogramPerSquareMetre.Name, NanoKilogramPerSquareMetre },
            { PicoKilogramPerSquareMetre.Name, PicoKilogramPerSquareMetre },
            { FemtoKilogramPerSquareMetre.Name, FemtoKilogramPerSquareMetre },
            { AttoKilogramPerSquareMetre.Name, AttoKilogramPerSquareMetre },
            { ZeptoKilogramPerSquareMetre.Name, ZeptoKilogramPerSquareMetre },
            { YoctoKilogramPerSquareMetre.Name, YoctoKilogramPerSquareMetre },
          };
        }

        static AreaDensity()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
