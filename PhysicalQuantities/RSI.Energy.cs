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
      public static partial class Energy
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Joule
        /// </summary>
        public static BaseUnit Joule { get; private set; }
        // Prefix Table: RISUPrefixes
        public static ScaledUnit GigaJoule { get; private set; }
        public static ScaledUnit MegaJoule { get; private set; }
        public static ScaledUnit KiloJoule { get; private set; }
        public static ScaledUnit HectoJoule { get; private set; }
        public static ScaledUnit DecaJoule { get; private set; }
        public static ScaledUnit DeciJoule { get; private set; }
        public static ScaledUnit CentiJoule { get; private set; }
        public static ScaledUnit MilliJoule { get; private set; }
        public static ScaledUnit MicroJoule { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Electron-volt
        /// </summary>
        public static ScaledUnit Electronvolt { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Electron-volt
        /// </summary>
        public static ScaledUnit MilliElectronvolt { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Electron-volt
        /// </summary>
        public static ScaledUnit KiloElectronvolt { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Electron-volt
        /// </summary>
        public static ScaledUnit MegaElectronvolt { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Electron-volt
        /// </summary>
        public static ScaledUnit GigaElectronvolt { get; private set; }

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
          Joule = new BaseUnit(@"Joule", @"J", PhysicalQuantities.Quantities.Energy, unitSystem) { Caption = @"joule" };
          GigaJoule = new ScaledUnit(@"GigaJoule", @"GJ", Joule, 1000000000, 0.0) { Caption = @"gigajoule" };
          MegaJoule = new ScaledUnit(@"MegaJoule", @"MJ", Joule, 1000000, 0.0) { Caption = @"megajoule" };
          KiloJoule = new ScaledUnit(@"KiloJoule", @"kJ", Joule, 1000, 0.0) { Caption = @"kilojoule" };
          HectoJoule = new ScaledUnit(@"HectoJoule", @"hJ", Joule, 100, 0.0) { Caption = @"hectojoule" };
          DecaJoule = new ScaledUnit(@"DecaJoule", @"daJ", Joule, 10, 0.0) { Caption = @"decajoule" };
          DeciJoule = new ScaledUnit(@"DeciJoule", @"dJ", Joule, 0.1, 0.0) { Caption = @"decijoule" };
          CentiJoule = new ScaledUnit(@"CentiJoule", @"cJ", Joule, 0.01, 0.0) { Caption = @"centijoule" };
          MilliJoule = new ScaledUnit(@"MilliJoule", @"mJ", Joule, 0.001, 0.0) { Caption = @"milijoule" };
          MicroJoule = new ScaledUnit(@"MicroJoule", @"μJ", Joule, 1E-06, 0.0) { Caption = @"microjoule" };
          Electronvolt = new ScaledUnit(@"Electronvolt", @"eV", Joule, 1.602176487E-19, 0) { Caption = @"electronvoltio" };
          MilliElectronvolt = new ScaledUnit(@"MilliElectronvolt", @"meV", Electronvolt, 0.001, 0) { Caption = @"milielectronvoltio" };
          KiloElectronvolt = new ScaledUnit(@"KiloElectronvolt", @"keV", Electronvolt, 1000, 0) { Caption = @"kiloelectronvoltio" };
          MegaElectronvolt = new ScaledUnit(@"MegaElectronvolt", @"MeV", Electronvolt, 1000000, 0) { Caption = @"megaelectronvoltio" };
          GigaElectronvolt = new ScaledUnit(@"GigaElectronvolt", @"GeV", Electronvolt, 1000000000, 0) { Caption = @"gigaelectronvoltio" };

          allUnits = new Dictionary<string, Unit>
          {
            { Joule.Name, Joule },
            { GigaJoule.Name, GigaJoule },
            { MegaJoule.Name, MegaJoule },
            { KiloJoule.Name, KiloJoule },
            { HectoJoule.Name, HectoJoule },
            { DecaJoule.Name, DecaJoule },
            { DeciJoule.Name, DeciJoule },
            { CentiJoule.Name, CentiJoule },
            { MilliJoule.Name, MilliJoule },
            { MicroJoule.Name, MicroJoule },
            { Electronvolt.Name, Electronvolt },
            { MilliElectronvolt.Name, MilliElectronvolt },
            { KiloElectronvolt.Name, KiloElectronvolt },
            { MegaElectronvolt.Name, MegaElectronvolt },
            { GigaElectronvolt.Name, GigaElectronvolt },
          };
        }

        static Energy()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
