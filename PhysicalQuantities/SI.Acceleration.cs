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
      public static partial class Acceleration
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Metre_per_second_squared
        /// </summary>
        public static BaseUnit MetrePerSecondSquared { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaMetrePerSecondSquared { get; private set; }
        public static ScaledUnit ZettaMetrePerSecondSquared { get; private set; }
        public static ScaledUnit ExaMetrePerSecondSquared { get; private set; }
        public static ScaledUnit PetaMetrePerSecondSquared { get; private set; }
        public static ScaledUnit TeraMetrePerSecondSquared { get; private set; }
        public static ScaledUnit GigaMetrePerSecondSquared { get; private set; }
        public static ScaledUnit MegaMetrePerSecondSquared { get; private set; }
        public static ScaledUnit KiloMetrePerSecondSquared { get; private set; }
        public static ScaledUnit HectoMetrePerSecondSquared { get; private set; }
        public static ScaledUnit DecaMetrePerSecondSquared { get; private set; }
        public static ScaledUnit DeciMetrePerSecondSquared { get; private set; }
        public static ScaledUnit CentiMetrePerSecondSquared { get; private set; }
        public static ScaledUnit MilliMetrePerSecondSquared { get; private set; }
        public static ScaledUnit MicroMetrePerSecondSquared { get; private set; }
        public static ScaledUnit NanoMetrePerSecondSquared { get; private set; }
        public static ScaledUnit PicoMetrePerSecondSquared { get; private set; }
        public static ScaledUnit FemtoMetrePerSecondSquared { get; private set; }
        public static ScaledUnit AttoMetrePerSecondSquared { get; private set; }
        public static ScaledUnit ZeptoMetrePerSecondSquared { get; private set; }
        public static ScaledUnit YoctoMetrePerSecondSquared { get; private set; }

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
          MetrePerSecondSquared = new BaseUnit(@"MetrePerSecondSquared", @"m/s²", PhysicalQuantities.Quantities.Acceleration, unitSystem) { Caption = @"metro por segundo al cuadrado" };
          YottaMetrePerSecondSquared = new ScaledUnit(@"YottaMetrePerSecondSquared", @"Ym/s²", MetrePerSecondSquared, 1E+24, 0.0) { Caption = @"yottametro por segundo al cuadrado" };
          ZettaMetrePerSecondSquared = new ScaledUnit(@"ZettaMetrePerSecondSquared", @"Zm/s²", MetrePerSecondSquared, 1E+21, 0.0) { Caption = @"zettametro por segundo al cuadrado" };
          ExaMetrePerSecondSquared = new ScaledUnit(@"ExaMetrePerSecondSquared", @"Em/s²", MetrePerSecondSquared, 1E+18, 0.0) { Caption = @"exametro por segundo al cuadrado" };
          PetaMetrePerSecondSquared = new ScaledUnit(@"PetaMetrePerSecondSquared", @"Pm/s²", MetrePerSecondSquared, 1E+15, 0.0) { Caption = @"petametro por segundo al cuadrado" };
          TeraMetrePerSecondSquared = new ScaledUnit(@"TeraMetrePerSecondSquared", @"Tm/s²", MetrePerSecondSquared, 1000000000000, 0.0) { Caption = @"terametro por segundo al cuadrado" };
          GigaMetrePerSecondSquared = new ScaledUnit(@"GigaMetrePerSecondSquared", @"Gm/s²", MetrePerSecondSquared, 1000000000, 0.0) { Caption = @"gigametro por segundo al cuadrado" };
          MegaMetrePerSecondSquared = new ScaledUnit(@"MegaMetrePerSecondSquared", @"Mm/s²", MetrePerSecondSquared, 1000000, 0.0) { Caption = @"megametro por segundo al cuadrado" };
          KiloMetrePerSecondSquared = new ScaledUnit(@"KiloMetrePerSecondSquared", @"km/s²", MetrePerSecondSquared, 1000, 0.0) { Caption = @"kilometro por segundo al cuadrado" };
          HectoMetrePerSecondSquared = new ScaledUnit(@"HectoMetrePerSecondSquared", @"hm/s²", MetrePerSecondSquared, 100, 0.0) { Caption = @"hectometro por segundo al cuadrado" };
          DecaMetrePerSecondSquared = new ScaledUnit(@"DecaMetrePerSecondSquared", @"dam/s²", MetrePerSecondSquared, 10, 0.0) { Caption = @"decametro por segundo al cuadrado" };
          DeciMetrePerSecondSquared = new ScaledUnit(@"DeciMetrePerSecondSquared", @"dm/s²", MetrePerSecondSquared, 0.1, 0.0) { Caption = @"decimetro por segundo al cuadrado" };
          CentiMetrePerSecondSquared = new ScaledUnit(@"CentiMetrePerSecondSquared", @"cm/s²", MetrePerSecondSquared, 0.01, 0.0) { Caption = @"centimetro por segundo al cuadrado" };
          MilliMetrePerSecondSquared = new ScaledUnit(@"MilliMetrePerSecondSquared", @"mm/s²", MetrePerSecondSquared, 0.001, 0.0) { Caption = @"milimetro por segundo al cuadrado" };
          MicroMetrePerSecondSquared = new ScaledUnit(@"MicroMetrePerSecondSquared", @"μm/s²", MetrePerSecondSquared, 1E-06, 0.0) { Caption = @"micrometro por segundo al cuadrado" };
          NanoMetrePerSecondSquared = new ScaledUnit(@"NanoMetrePerSecondSquared", @"nm/s²", MetrePerSecondSquared, 1E-09, 0.0) { Caption = @"nanometro por segundo al cuadrado" };
          PicoMetrePerSecondSquared = new ScaledUnit(@"PicoMetrePerSecondSquared", @"pm/s²", MetrePerSecondSquared, 1E-12, 0.0) { Caption = @"picometro por segundo al cuadrado" };
          FemtoMetrePerSecondSquared = new ScaledUnit(@"FemtoMetrePerSecondSquared", @"fm/s²", MetrePerSecondSquared, 1E-15, 0.0) { Caption = @"femtometro por segundo al cuadrado" };
          AttoMetrePerSecondSquared = new ScaledUnit(@"AttoMetrePerSecondSquared", @"am/s²", MetrePerSecondSquared, 1E-18, 0.0) { Caption = @"attometro por segundo al cuadrado" };
          ZeptoMetrePerSecondSquared = new ScaledUnit(@"ZeptoMetrePerSecondSquared", @"zm/s²", MetrePerSecondSquared, 1E-21, 0.0) { Caption = @"zeptometro por segundo al cuadrado" };
          YoctoMetrePerSecondSquared = new ScaledUnit(@"YoctoMetrePerSecondSquared", @"ym/s²", MetrePerSecondSquared, 1E-24, 0.0) { Caption = @"yoctometro por segundo al cuadrado" };

          allUnits = new Dictionary<string, Unit>
          {
            { MetrePerSecondSquared.Name, MetrePerSecondSquared },
            { YottaMetrePerSecondSquared.Name, YottaMetrePerSecondSquared },
            { ZettaMetrePerSecondSquared.Name, ZettaMetrePerSecondSquared },
            { ExaMetrePerSecondSquared.Name, ExaMetrePerSecondSquared },
            { PetaMetrePerSecondSquared.Name, PetaMetrePerSecondSquared },
            { TeraMetrePerSecondSquared.Name, TeraMetrePerSecondSquared },
            { GigaMetrePerSecondSquared.Name, GigaMetrePerSecondSquared },
            { MegaMetrePerSecondSquared.Name, MegaMetrePerSecondSquared },
            { KiloMetrePerSecondSquared.Name, KiloMetrePerSecondSquared },
            { HectoMetrePerSecondSquared.Name, HectoMetrePerSecondSquared },
            { DecaMetrePerSecondSquared.Name, DecaMetrePerSecondSquared },
            { DeciMetrePerSecondSquared.Name, DeciMetrePerSecondSquared },
            { CentiMetrePerSecondSquared.Name, CentiMetrePerSecondSquared },
            { MilliMetrePerSecondSquared.Name, MilliMetrePerSecondSquared },
            { MicroMetrePerSecondSquared.Name, MicroMetrePerSecondSquared },
            { NanoMetrePerSecondSquared.Name, NanoMetrePerSecondSquared },
            { PicoMetrePerSecondSquared.Name, PicoMetrePerSecondSquared },
            { FemtoMetrePerSecondSquared.Name, FemtoMetrePerSecondSquared },
            { AttoMetrePerSecondSquared.Name, AttoMetrePerSecondSquared },
            { ZeptoMetrePerSecondSquared.Name, ZeptoMetrePerSecondSquared },
            { YoctoMetrePerSecondSquared.Name, YoctoMetrePerSecondSquared },
          };
        }

        static Acceleration()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
