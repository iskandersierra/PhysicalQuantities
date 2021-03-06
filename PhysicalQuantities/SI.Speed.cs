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
      public static partial class Speed
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Metre_per_second
        /// </summary>
        public static BaseUnit MetrePerSecond { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaMetrePerSecond { get; private set; }
        public static ScaledUnit ZettaMetrePerSecond { get; private set; }
        public static ScaledUnit ExaMetrePerSecond { get; private set; }
        public static ScaledUnit PetaMetrePerSecond { get; private set; }
        public static ScaledUnit TeraMetrePerSecond { get; private set; }
        public static ScaledUnit GigaMetrePerSecond { get; private set; }
        public static ScaledUnit MegaMetrePerSecond { get; private set; }
        public static ScaledUnit KiloMetrePerSecond { get; private set; }
        public static ScaledUnit HectoMetrePerSecond { get; private set; }
        public static ScaledUnit DecaMetrePerSecond { get; private set; }
        public static ScaledUnit DeciMetrePerSecond { get; private set; }
        public static ScaledUnit CentiMetrePerSecond { get; private set; }
        public static ScaledUnit MilliMetrePerSecond { get; private set; }
        public static ScaledUnit MicroMetrePerSecond { get; private set; }
        public static ScaledUnit NanoMetrePerSecond { get; private set; }
        public static ScaledUnit PicoMetrePerSecond { get; private set; }
        public static ScaledUnit FemtoMetrePerSecond { get; private set; }
        public static ScaledUnit AttoMetrePerSecond { get; private set; }
        public static ScaledUnit ZeptoMetrePerSecond { get; private set; }
        public static ScaledUnit YoctoMetrePerSecond { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Kilometers_per_hour
        /// </summary>
        public static ScaledUnit KilometerPerHour { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Speed_of_light
        /// </summary>
        public static ScaledUnit SpeedOfLight { get; private set; }

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
          MetrePerSecond = new BaseUnit(@"MetrePerSecond", @"m/s", PhysicalQuantities.Quantities.Speed, unitSystem) { Caption = @"metro por segundo" };
          YottaMetrePerSecond = new ScaledUnit(@"YottaMetrePerSecond", @"Ym/s", MetrePerSecond, 1E+24, 0.0) { Caption = @"yottametro por segundo" };
          ZettaMetrePerSecond = new ScaledUnit(@"ZettaMetrePerSecond", @"Zm/s", MetrePerSecond, 1E+21, 0.0) { Caption = @"zettametro por segundo" };
          ExaMetrePerSecond = new ScaledUnit(@"ExaMetrePerSecond", @"Em/s", MetrePerSecond, 1E+18, 0.0) { Caption = @"exametro por segundo" };
          PetaMetrePerSecond = new ScaledUnit(@"PetaMetrePerSecond", @"Pm/s", MetrePerSecond, 1E+15, 0.0) { Caption = @"petametro por segundo" };
          TeraMetrePerSecond = new ScaledUnit(@"TeraMetrePerSecond", @"Tm/s", MetrePerSecond, 1000000000000, 0.0) { Caption = @"terametro por segundo" };
          GigaMetrePerSecond = new ScaledUnit(@"GigaMetrePerSecond", @"Gm/s", MetrePerSecond, 1000000000, 0.0) { Caption = @"gigametro por segundo" };
          MegaMetrePerSecond = new ScaledUnit(@"MegaMetrePerSecond", @"Mm/s", MetrePerSecond, 1000000, 0.0) { Caption = @"megametro por segundo" };
          KiloMetrePerSecond = new ScaledUnit(@"KiloMetrePerSecond", @"km/s", MetrePerSecond, 1000, 0.0) { Caption = @"kilometro por segundo" };
          HectoMetrePerSecond = new ScaledUnit(@"HectoMetrePerSecond", @"hm/s", MetrePerSecond, 100, 0.0) { Caption = @"hectometro por segundo" };
          DecaMetrePerSecond = new ScaledUnit(@"DecaMetrePerSecond", @"dam/s", MetrePerSecond, 10, 0.0) { Caption = @"decametro por segundo" };
          DeciMetrePerSecond = new ScaledUnit(@"DeciMetrePerSecond", @"dm/s", MetrePerSecond, 0.1, 0.0) { Caption = @"decimetro por segundo" };
          CentiMetrePerSecond = new ScaledUnit(@"CentiMetrePerSecond", @"cm/s", MetrePerSecond, 0.01, 0.0) { Caption = @"centimetro por segundo" };
          MilliMetrePerSecond = new ScaledUnit(@"MilliMetrePerSecond", @"mm/s", MetrePerSecond, 0.001, 0.0) { Caption = @"milimetro por segundo" };
          MicroMetrePerSecond = new ScaledUnit(@"MicroMetrePerSecond", @"μm/s", MetrePerSecond, 1E-06, 0.0) { Caption = @"micrometro por segundo" };
          NanoMetrePerSecond = new ScaledUnit(@"NanoMetrePerSecond", @"nm/s", MetrePerSecond, 1E-09, 0.0) { Caption = @"nanometro por segundo" };
          PicoMetrePerSecond = new ScaledUnit(@"PicoMetrePerSecond", @"pm/s", MetrePerSecond, 1E-12, 0.0) { Caption = @"picometro por segundo" };
          FemtoMetrePerSecond = new ScaledUnit(@"FemtoMetrePerSecond", @"fm/s", MetrePerSecond, 1E-15, 0.0) { Caption = @"femtometro por segundo" };
          AttoMetrePerSecond = new ScaledUnit(@"AttoMetrePerSecond", @"am/s", MetrePerSecond, 1E-18, 0.0) { Caption = @"attometro por segundo" };
          ZeptoMetrePerSecond = new ScaledUnit(@"ZeptoMetrePerSecond", @"zm/s", MetrePerSecond, 1E-21, 0.0) { Caption = @"zeptometro por segundo" };
          YoctoMetrePerSecond = new ScaledUnit(@"YoctoMetrePerSecond", @"ym/s", MetrePerSecond, 1E-24, 0.0) { Caption = @"yoctometro por segundo" };
          KilometerPerHour = new ScaledUnit(@"KilometerPerHour", @"km/h", MetrePerSecond, 0.277777777777778, 0) { Caption = @"kilómetro por hora" };
          SpeedOfLight = new ScaledUnit(@"SpeedOfLight", @"c", MetrePerSecond, 299792458, 0) { Caption = @"velocidad de la luz" };

          allUnits = new Dictionary<string, Unit>
          {
            { MetrePerSecond.Name, MetrePerSecond },
            { YottaMetrePerSecond.Name, YottaMetrePerSecond },
            { ZettaMetrePerSecond.Name, ZettaMetrePerSecond },
            { ExaMetrePerSecond.Name, ExaMetrePerSecond },
            { PetaMetrePerSecond.Name, PetaMetrePerSecond },
            { TeraMetrePerSecond.Name, TeraMetrePerSecond },
            { GigaMetrePerSecond.Name, GigaMetrePerSecond },
            { MegaMetrePerSecond.Name, MegaMetrePerSecond },
            { KiloMetrePerSecond.Name, KiloMetrePerSecond },
            { HectoMetrePerSecond.Name, HectoMetrePerSecond },
            { DecaMetrePerSecond.Name, DecaMetrePerSecond },
            { DeciMetrePerSecond.Name, DeciMetrePerSecond },
            { CentiMetrePerSecond.Name, CentiMetrePerSecond },
            { MilliMetrePerSecond.Name, MilliMetrePerSecond },
            { MicroMetrePerSecond.Name, MicroMetrePerSecond },
            { NanoMetrePerSecond.Name, NanoMetrePerSecond },
            { PicoMetrePerSecond.Name, PicoMetrePerSecond },
            { FemtoMetrePerSecond.Name, FemtoMetrePerSecond },
            { AttoMetrePerSecond.Name, AttoMetrePerSecond },
            { ZeptoMetrePerSecond.Name, ZeptoMetrePerSecond },
            { YoctoMetrePerSecond.Name, YoctoMetrePerSecond },
            { KilometerPerHour.Name, KilometerPerHour },
            { SpeedOfLight.Name, SpeedOfLight },
          };
        }

        static Speed()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
