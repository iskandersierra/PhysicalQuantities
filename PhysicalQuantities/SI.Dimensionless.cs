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
      public static partial class Dimensionless
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Dimensionless_quantity
        /// </summary>
        public static BaseUnit Unity { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaUnity { get; private set; }
        public static ScaledUnit ZettaUnity { get; private set; }
        public static ScaledUnit ExaUnity { get; private set; }
        public static ScaledUnit PetaUnity { get; private set; }
        public static ScaledUnit TeraUnity { get; private set; }
        public static ScaledUnit GigaUnity { get; private set; }
        public static ScaledUnit MegaUnity { get; private set; }
        public static ScaledUnit KiloUnity { get; private set; }
        public static ScaledUnit HectoUnity { get; private set; }
        public static ScaledUnit DecaUnity { get; private set; }
        public static ScaledUnit DeciUnity { get; private set; }
        public static ScaledUnit CentiUnity { get; private set; }
        public static ScaledUnit MilliUnity { get; private set; }
        public static ScaledUnit MicroUnity { get; private set; }
        public static ScaledUnit NanoUnity { get; private set; }
        public static ScaledUnit PicoUnity { get; private set; }
        public static ScaledUnit FemtoUnity { get; private set; }
        public static ScaledUnit AttoUnity { get; private set; }
        public static ScaledUnit ZeptoUnity { get; private set; }
        public static ScaledUnit YoctoUnity { get; private set; }

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
          Unity = new BaseUnit(@"Unity", null, PhysicalQuantities.Quantities.Dimensionless, unitSystem) { Caption = @"unidad" };
          YottaUnity = new ScaledUnit(@"YottaUnity", null, Unity, 1E+24, 0.0) { Caption = @"yottaunidad" };
          ZettaUnity = new ScaledUnit(@"ZettaUnity", null, Unity, 1E+21, 0.0) { Caption = @"zettaunidad" };
          ExaUnity = new ScaledUnit(@"ExaUnity", null, Unity, 1E+18, 0.0) { Caption = @"exaunidad" };
          PetaUnity = new ScaledUnit(@"PetaUnity", null, Unity, 1E+15, 0.0) { Caption = @"petaunidad" };
          TeraUnity = new ScaledUnit(@"TeraUnity", null, Unity, 1000000000000, 0.0) { Caption = @"teraunidad" };
          GigaUnity = new ScaledUnit(@"GigaUnity", null, Unity, 1000000000, 0.0) { Caption = @"gigaunidad" };
          MegaUnity = new ScaledUnit(@"MegaUnity", null, Unity, 1000000, 0.0) { Caption = @"megaunidad" };
          KiloUnity = new ScaledUnit(@"KiloUnity", null, Unity, 1000, 0.0) { Caption = @"kilounidad" };
          HectoUnity = new ScaledUnit(@"HectoUnity", null, Unity, 100, 0.0) { Caption = @"hectounidad" };
          DecaUnity = new ScaledUnit(@"DecaUnity", null, Unity, 10, 0.0) { Caption = @"decaunidad" };
          DeciUnity = new ScaledUnit(@"DeciUnity", null, Unity, 0.1, 0.0) { Caption = @"deciunidad" };
          CentiUnity = new ScaledUnit(@"CentiUnity", null, Unity, 0.01, 0.0) { Caption = @"centiunidad" };
          MilliUnity = new ScaledUnit(@"MilliUnity", null, Unity, 0.001, 0.0) { Caption = @"miliunidad" };
          MicroUnity = new ScaledUnit(@"MicroUnity", null, Unity, 1E-06, 0.0) { Caption = @"microunidad" };
          NanoUnity = new ScaledUnit(@"NanoUnity", null, Unity, 1E-09, 0.0) { Caption = @"nanounidad" };
          PicoUnity = new ScaledUnit(@"PicoUnity", null, Unity, 1E-12, 0.0) { Caption = @"picounidad" };
          FemtoUnity = new ScaledUnit(@"FemtoUnity", null, Unity, 1E-15, 0.0) { Caption = @"femtounidad" };
          AttoUnity = new ScaledUnit(@"AttoUnity", null, Unity, 1E-18, 0.0) { Caption = @"attounidad" };
          ZeptoUnity = new ScaledUnit(@"ZeptoUnity", null, Unity, 1E-21, 0.0) { Caption = @"zeptounidad" };
          YoctoUnity = new ScaledUnit(@"YoctoUnity", null, Unity, 1E-24, 0.0) { Caption = @"yoctounidad" };

          allUnits = new Dictionary<string, Unit>
          {
            { Unity.Name, Unity },
            { YottaUnity.Name, YottaUnity },
            { ZettaUnity.Name, ZettaUnity },
            { ExaUnity.Name, ExaUnity },
            { PetaUnity.Name, PetaUnity },
            { TeraUnity.Name, TeraUnity },
            { GigaUnity.Name, GigaUnity },
            { MegaUnity.Name, MegaUnity },
            { KiloUnity.Name, KiloUnity },
            { HectoUnity.Name, HectoUnity },
            { DecaUnity.Name, DecaUnity },
            { DeciUnity.Name, DeciUnity },
            { CentiUnity.Name, CentiUnity },
            { MilliUnity.Name, MilliUnity },
            { MicroUnity.Name, MicroUnity },
            { NanoUnity.Name, NanoUnity },
            { PicoUnity.Name, PicoUnity },
            { FemtoUnity.Name, FemtoUnity },
            { AttoUnity.Name, AttoUnity },
            { ZeptoUnity.Name, ZeptoUnity },
            { YoctoUnity.Name, YoctoUnity },
          };
        }

        static Dimensionless()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
