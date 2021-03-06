using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public static partial class UnitSystems
  {
    public static partial class Imperial
    {
      public static partial class Pressure
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Pounds_per_square_inch
        /// </summary>
        public static BaseUnit PoundPerSquareFoot { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Pounds_per_square_inch
        /// </summary>
        public static ScaledUnit PoundPerSquareInch { get; private set; }

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
          PoundPerSquareFoot = new BaseUnit(@"PoundPerSquareFoot", @"lb/ft²", PhysicalQuantities.Quantities.Pressure, unitSystem) { Caption = @"libra por pie cuadrado" };
          PoundPerSquareInch = new ScaledUnit(@"PoundPerSquareInch", @"lb/in²", PoundPerSquareFoot, 144, 0) { Caption = @"libra por pulgada cuadrada" };

          allUnits = new Dictionary<string, Unit>
          {
            { PoundPerSquareFoot.Name, PoundPerSquareFoot },
            { PoundPerSquareInch.Name, PoundPerSquareInch },
          };
        }

        static Pressure()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
