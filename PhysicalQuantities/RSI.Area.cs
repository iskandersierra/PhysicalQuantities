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
      public static partial class Area
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Square_metre
        /// </summary>
        public static BaseUnit SquareMetre { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Hectare#Are
        /// </summary>
        public static ScaledUnit Are { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Hectare#Centiare
        /// </summary>
        public static ScaledUnit Centiare { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Hectare#Decare
        /// </summary>
        public static ScaledUnit Decare { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Hectare
        /// </summary>
        public static ScaledUnit Hectare { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Square_kilometer
        /// </summary>
        public static ScaledUnit SquareKilometre { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Square_centimetre
        /// </summary>
        public static ScaledUnit SquareCentimetre { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Square_millimetre
        /// </summary>
        public static ScaledUnit SquareMillimetre { get; private set; }

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
          SquareMetre = new BaseUnit(@"SquareMetre", @"m²", PhysicalQuantities.Quantities.Area, unitSystem) { Caption = @"metro cuadrado" };
          Are = new ScaledUnit(@"Are", @"a", SquareMetre, 100, 0) { Caption = @"área" };
          Centiare = new ScaledUnit(@"Centiare", @"ca", SquareMetre, 1, 0) { Caption = @"centiárea" };
          Decare = new ScaledUnit(@"Decare", @"daa", Are, 10, 0) { Caption = @"decárea" };
          Hectare = new ScaledUnit(@"Hectare", @"ha", Are, 100, 0) { Caption = @"hectárea" };
          SquareKilometre = new ScaledUnit(@"SquareKilometre", @"km²", SquareMetre, 1000000, 0) { Caption = @"kilómetro cuadrado" };
          SquareCentimetre = new ScaledUnit(@"SquareCentimetre", @"cm²", SquareMetre, 0.0001, 0) { Caption = @"centímetro cuadrado" };
          SquareMillimetre = new ScaledUnit(@"SquareMillimetre", @"mm²", SquareMetre, 1E-06, 0) { Caption = @"milímetro cuadrado" };

          allUnits = new Dictionary<string, Unit>
          {
            { SquareMetre.Name, SquareMetre },
            { Are.Name, Are },
            { Centiare.Name, Centiare },
            { Decare.Name, Decare },
            { Hectare.Name, Hectare },
            { SquareKilometre.Name, SquareKilometre },
            { SquareCentimetre.Name, SquareCentimetre },
            { SquareMillimetre.Name, SquareMillimetre },
          };
        }

        static Area()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
