using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public static partial class UnitSystems
  {
    public static partial class US
    {
      public static partial class Volume
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Cubic_foot
        /// </summary>
        public static BaseUnit CubicFoot { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Cubic_inch
        /// </summary>
        public static ScaledUnit CubicInch { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Cubic_yard
        /// </summary>
        public static ScaledUnit CubicYard { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Acre-foot
        /// </summary>
        public static ScaledUnit AcreFoot { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Board-foot
        /// </summary>
        public static ScaledUnit BoardFoot { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Gallon
        /// </summary>
        public static ScaledUnit USGallon { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Barrel_(unit)
        /// </summary>
        public static ScaledUnit Barrel { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Barrel_(unit)
        /// </summary>
        public static ScaledUnit OilBarrel { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Hogshead
        /// </summary>
        public static ScaledUnit Hogshead { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Quart
        /// </summary>
        public static ScaledUnit USQuart { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Pint
        /// </summary>
        public static ScaledUnit USPint { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Cup_(unit)
        /// </summary>
        public static ScaledUnit USCup { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Gill_(unit)
        /// </summary>
        public static ScaledUnit USGill { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Fluid_ounce
        /// </summary>
        public static ScaledUnit USFluidOunce { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Tablespoon
        /// </summary>
        public static ScaledUnit Tablespoon { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Teaspoon
        /// </summary>
        public static ScaledUnit Teaspoon { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Jigger_(bartending)#Jigger
        /// </summary>
        public static ScaledUnit Jigger { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Fluid_dram
        /// </summary>
        public static ScaledUnit USFluidDram { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Minim_(unit)
        /// </summary>
        public static ScaledUnit Minim { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Pint
        /// </summary>
        public static ScaledUnit DryPint { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Quart
        /// </summary>
        public static ScaledUnit DryQuart { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Gallon
        /// </summary>
        public static ScaledUnit DryGallon { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Peck
        /// </summary>
        public static ScaledUnit Peck { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Bushel
        /// </summary>
        public static ScaledUnit Bushel { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Barrel_(unit)
        /// </summary>
        public static ScaledUnit DryBarrel { get; private set; }

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
          CubicFoot = new BaseUnit(@"CubicFoot", @"ft³", PhysicalQuantities.Quantities.Volume, unitSystem) { Caption = @"pie cúbico" };
          CubicInch = new ScaledUnit(@"CubicInch", @"in³", CubicFoot, 0.000578703703703704, 0) { Caption = @"pulgada cúbica" };
          CubicYard = new ScaledUnit(@"CubicYard", @"yd³", CubicFoot, 27, 0) { Caption = @"yarda cúbica" };
          AcreFoot = new ScaledUnit(@"AcreFoot", @"acre mi", CubicFoot, 43560, 0) { Caption = @"acre-pie" };
          BoardFoot = new ScaledUnit(@"BoardFoot", @"FBM", CubicInch, 144, 0) { Caption = @"pie tabla" };
          USGallon = new ScaledUnit(@"USGallon", @"gal", CubicInch, 231, 0) { Caption = @"pulgada cúbica" };
          Barrel = new ScaledUnit(@"Barrel", @"bbl", USGallon, 31.5, 0) { Caption = @"barril" };
          OilBarrel = new ScaledUnit(@"OilBarrel", @"bbl", USGallon, 42, 0) { Caption = @"barril de petróleo" };
          Hogshead = new ScaledUnit(@"Hogshead", null, USGallon, 63, 0) { Caption = @"tonel" };
          USQuart = new ScaledUnit(@"USQuart", @"qt", USGallon, 0.25, 0) { Caption = @"cuarto de galón" };
          USPint = new ScaledUnit(@"USPint", @"pt", USQuart, 0.5, 0) { Caption = @"pinta" };
          USCup = new ScaledUnit(@"USCup", @"cp", USPint, 0.5, 0) { Caption = @"copa" };
          USGill = new ScaledUnit(@"USGill", @"gi", USCup, 0.5, 0) { Caption = @"media copa" };
          USFluidOunce = new ScaledUnit(@"USFluidOunce", @"fl oz", USGill, 0.25, 0) { Caption = @"onza líquida" };
          Tablespoon = new ScaledUnit(@"Tablespoon", @"Tbsp", USFluidOunce, 0.5, 0) { Caption = @"cucharada" };
          Teaspoon = new ScaledUnit(@"Teaspoon", @"tsp", Tablespoon, 0.333333333333333, 0) { Caption = @"cucharadita" };
          Jigger = new ScaledUnit(@"Jigger", @"jig", Tablespoon, 3, 0) { Caption = @"medida" };
          USFluidDram = new ScaledUnit(@"USFluidDram", @"fl dr", Tablespoon, 0.25, 0) { Caption = @"dracma líquido" };
          Minim = new ScaledUnit(@"Minim", @"min", Teaspoon, 0.0125, 0) { Caption = @"pizca" };
          DryPint = new ScaledUnit(@"DryPint", @"pt", CubicInch, 33.6, 0) { Caption = @"pinta seca" };
          DryQuart = new ScaledUnit(@"DryQuart", @"qt", DryPint, 2, 0) { Caption = @"cuarto seco" };
          DryGallon = new ScaledUnit(@"DryGallon", @"gal", DryQuart, 4, 0) { Caption = @"galón seco" };
          Peck = new ScaledUnit(@"Peck", @"pk", DryGallon, 2, 0) { Caption = @"peck" };
          Bushel = new ScaledUnit(@"Bushel", @"bu", Peck, 4, 0) { Caption = @"bushel" };
          DryBarrel = new ScaledUnit(@"DryBarrel", @"bbl", CubicInch, 7056, 0) { Caption = @"barril seco" };

          allUnits = new Dictionary<string, Unit>
          {
            { CubicFoot.Name, CubicFoot },
            { CubicInch.Name, CubicInch },
            { CubicYard.Name, CubicYard },
            { AcreFoot.Name, AcreFoot },
            { BoardFoot.Name, BoardFoot },
            { USGallon.Name, USGallon },
            { Barrel.Name, Barrel },
            { OilBarrel.Name, OilBarrel },
            { Hogshead.Name, Hogshead },
            { USQuart.Name, USQuart },
            { USPint.Name, USPint },
            { USCup.Name, USCup },
            { USGill.Name, USGill },
            { USFluidOunce.Name, USFluidOunce },
            { Tablespoon.Name, Tablespoon },
            { Teaspoon.Name, Teaspoon },
            { Jigger.Name, Jigger },
            { USFluidDram.Name, USFluidDram },
            { Minim.Name, Minim },
            { DryPint.Name, DryPint },
            { DryQuart.Name, DryQuart },
            { DryGallon.Name, DryGallon },
            { Peck.Name, Peck },
            { Bushel.Name, Bushel },
            { DryBarrel.Name, DryBarrel },
          };
        }

        static Volume()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
