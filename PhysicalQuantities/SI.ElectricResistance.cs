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
      public static partial class ElectricResistance
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Ohm_(unit)
        /// </summary>
        public static BaseUnit Ohm { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaOhm { get; private set; }
        public static ScaledUnit ZettaOhm { get; private set; }
        public static ScaledUnit ExaOhm { get; private set; }
        public static ScaledUnit PetaOhm { get; private set; }
        public static ScaledUnit TeraOhm { get; private set; }
        public static ScaledUnit GigaOhm { get; private set; }
        public static ScaledUnit MegaOhm { get; private set; }
        public static ScaledUnit KiloOhm { get; private set; }
        public static ScaledUnit HectoOhm { get; private set; }
        public static ScaledUnit DecaOhm { get; private set; }
        public static ScaledUnit DeciOhm { get; private set; }
        public static ScaledUnit CentiOhm { get; private set; }
        public static ScaledUnit MilliOhm { get; private set; }
        public static ScaledUnit MicroOhm { get; private set; }
        public static ScaledUnit NanoOhm { get; private set; }
        public static ScaledUnit PicoOhm { get; private set; }
        public static ScaledUnit FemtoOhm { get; private set; }
        public static ScaledUnit AttoOhm { get; private set; }
        public static ScaledUnit ZeptoOhm { get; private set; }
        public static ScaledUnit YoctoOhm { get; private set; }

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
          Ohm = new BaseUnit(@"Ohm", @"Ω", PhysicalQuantities.Quantities.ElectricResistance, unitSystem) { Caption = @"ohmio" };
          YottaOhm = new ScaledUnit(@"YottaOhm", @"YΩ", Ohm, 1E+24, 0.0) { Caption = @"yottaohmio" };
          ZettaOhm = new ScaledUnit(@"ZettaOhm", @"ZΩ", Ohm, 1E+21, 0.0) { Caption = @"zettaohmio" };
          ExaOhm = new ScaledUnit(@"ExaOhm", @"EΩ", Ohm, 1E+18, 0.0) { Caption = @"exaohmio" };
          PetaOhm = new ScaledUnit(@"PetaOhm", @"PΩ", Ohm, 1E+15, 0.0) { Caption = @"petaohmio" };
          TeraOhm = new ScaledUnit(@"TeraOhm", @"TΩ", Ohm, 1000000000000, 0.0) { Caption = @"teraohmio" };
          GigaOhm = new ScaledUnit(@"GigaOhm", @"GΩ", Ohm, 1000000000, 0.0) { Caption = @"gigaohmio" };
          MegaOhm = new ScaledUnit(@"MegaOhm", @"MΩ", Ohm, 1000000, 0.0) { Caption = @"megaohmio" };
          KiloOhm = new ScaledUnit(@"KiloOhm", @"kΩ", Ohm, 1000, 0.0) { Caption = @"kiloohmio" };
          HectoOhm = new ScaledUnit(@"HectoOhm", @"hΩ", Ohm, 100, 0.0) { Caption = @"hectoohmio" };
          DecaOhm = new ScaledUnit(@"DecaOhm", @"daΩ", Ohm, 10, 0.0) { Caption = @"decaohmio" };
          DeciOhm = new ScaledUnit(@"DeciOhm", @"dΩ", Ohm, 0.1, 0.0) { Caption = @"deciohmio" };
          CentiOhm = new ScaledUnit(@"CentiOhm", @"cΩ", Ohm, 0.01, 0.0) { Caption = @"centiohmio" };
          MilliOhm = new ScaledUnit(@"MilliOhm", @"mΩ", Ohm, 0.001, 0.0) { Caption = @"miliohmio" };
          MicroOhm = new ScaledUnit(@"MicroOhm", @"μΩ", Ohm, 1E-06, 0.0) { Caption = @"microohmio" };
          NanoOhm = new ScaledUnit(@"NanoOhm", @"nΩ", Ohm, 1E-09, 0.0) { Caption = @"nanoohmio" };
          PicoOhm = new ScaledUnit(@"PicoOhm", @"pΩ", Ohm, 1E-12, 0.0) { Caption = @"picoohmio" };
          FemtoOhm = new ScaledUnit(@"FemtoOhm", @"fΩ", Ohm, 1E-15, 0.0) { Caption = @"femtoohmio" };
          AttoOhm = new ScaledUnit(@"AttoOhm", @"aΩ", Ohm, 1E-18, 0.0) { Caption = @"attoohmio" };
          ZeptoOhm = new ScaledUnit(@"ZeptoOhm", @"zΩ", Ohm, 1E-21, 0.0) { Caption = @"zeptoohmio" };
          YoctoOhm = new ScaledUnit(@"YoctoOhm", @"yΩ", Ohm, 1E-24, 0.0) { Caption = @"yoctoohmio" };

          allUnits = new Dictionary<string, Unit>
          {
            { Ohm.Name, Ohm },
            { YottaOhm.Name, YottaOhm },
            { ZettaOhm.Name, ZettaOhm },
            { ExaOhm.Name, ExaOhm },
            { PetaOhm.Name, PetaOhm },
            { TeraOhm.Name, TeraOhm },
            { GigaOhm.Name, GigaOhm },
            { MegaOhm.Name, MegaOhm },
            { KiloOhm.Name, KiloOhm },
            { HectoOhm.Name, HectoOhm },
            { DecaOhm.Name, DecaOhm },
            { DeciOhm.Name, DeciOhm },
            { CentiOhm.Name, CentiOhm },
            { MilliOhm.Name, MilliOhm },
            { MicroOhm.Name, MicroOhm },
            { NanoOhm.Name, NanoOhm },
            { PicoOhm.Name, PicoOhm },
            { FemtoOhm.Name, FemtoOhm },
            { AttoOhm.Name, AttoOhm },
            { ZeptoOhm.Name, ZeptoOhm },
            { YoctoOhm.Name, YoctoOhm },
          };
        }

        static ElectricResistance()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
