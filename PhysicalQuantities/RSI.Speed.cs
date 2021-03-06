using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public static partial class UnitSystems
  {
    public static partial class RSI
    {
      public static partial class Speed
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Metre_per_second
        /// </summary>
        public static BaseUnit MetrePerSecond { get; private set; }
        // Prefix Table: R2ISUPrefixes
        public static ScaledUnit KiloMetrePerSecond { get; private set; }
        public static ScaledUnit HectoMetrePerSecond { get; private set; }
        public static ScaledUnit DecaMetrePerSecond { get; private set; }
        public static ScaledUnit DeciMetrePerSecond { get; private set; }
        public static ScaledUnit CentiMetrePerSecond { get; private set; }
        public static ScaledUnit MilliMetrePerSecond { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Kilometers_per_hour
        /// </summary>
        public static ScaledUnit KilometerPerHour { get; private set; }

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
          KiloMetrePerSecond = new ScaledUnit(@"KiloMetrePerSecond", @"km/s", MetrePerSecond, 1000, 0.0) { Caption = @"kilometro por segundo" };
          HectoMetrePerSecond = new ScaledUnit(@"HectoMetrePerSecond", @"hm/s", MetrePerSecond, 100, 0.0) { Caption = @"hectometro por segundo" };
          DecaMetrePerSecond = new ScaledUnit(@"DecaMetrePerSecond", @"dam/s", MetrePerSecond, 10, 0.0) { Caption = @"decametro por segundo" };
          DeciMetrePerSecond = new ScaledUnit(@"DeciMetrePerSecond", @"dm/s", MetrePerSecond, 0.1, 0.0) { Caption = @"decimetro por segundo" };
          CentiMetrePerSecond = new ScaledUnit(@"CentiMetrePerSecond", @"cm/s", MetrePerSecond, 0.01, 0.0) { Caption = @"centimetro por segundo" };
          MilliMetrePerSecond = new ScaledUnit(@"MilliMetrePerSecond", @"mm/s", MetrePerSecond, 0.001, 0.0) { Caption = @"milimetro por segundo" };
          KilometerPerHour = new ScaledUnit(@"KilometerPerHour", @"km/h", MetrePerSecond, 0.277777777777778, 0) { Caption = @"kilómetro por hora" };

          allUnits = new Dictionary<string, Unit>
          {
            { MetrePerSecond.Name, MetrePerSecond },
            { KiloMetrePerSecond.Name, KiloMetrePerSecond },
            { HectoMetrePerSecond.Name, HectoMetrePerSecond },
            { DecaMetrePerSecond.Name, DecaMetrePerSecond },
            { DeciMetrePerSecond.Name, DeciMetrePerSecond },
            { CentiMetrePerSecond.Name, CentiMetrePerSecond },
            { MilliMetrePerSecond.Name, MilliMetrePerSecond },
            { KilometerPerHour.Name, KilometerPerHour },
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
