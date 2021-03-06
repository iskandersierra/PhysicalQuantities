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
      public static partial class Action
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Joule_second
        /// </summary>
        public static BaseUnit JouleSecond { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaJouleSecond { get; private set; }
        public static ScaledUnit ZettaJouleSecond { get; private set; }
        public static ScaledUnit ExaJouleSecond { get; private set; }
        public static ScaledUnit PetaJouleSecond { get; private set; }
        public static ScaledUnit TeraJouleSecond { get; private set; }
        public static ScaledUnit GigaJouleSecond { get; private set; }
        public static ScaledUnit MegaJouleSecond { get; private set; }
        public static ScaledUnit KiloJouleSecond { get; private set; }
        public static ScaledUnit HectoJouleSecond { get; private set; }
        public static ScaledUnit DecaJouleSecond { get; private set; }
        public static ScaledUnit DeciJouleSecond { get; private set; }
        public static ScaledUnit CentiJouleSecond { get; private set; }
        public static ScaledUnit MilliJouleSecond { get; private set; }
        public static ScaledUnit MicroJouleSecond { get; private set; }
        public static ScaledUnit NanoJouleSecond { get; private set; }
        public static ScaledUnit PicoJouleSecond { get; private set; }
        public static ScaledUnit FemtoJouleSecond { get; private set; }
        public static ScaledUnit AttoJouleSecond { get; private set; }
        public static ScaledUnit ZeptoJouleSecond { get; private set; }
        public static ScaledUnit YoctoJouleSecond { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Planck_constant
        /// </summary>
        public static ScaledUnit PlanckConstant { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Reduced_Planck_constant
        /// </summary>
        public static ScaledUnit ReducedPlanckConstant { get; private set; }

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
          JouleSecond = new BaseUnit(@"JouleSecond", @"J·s", PhysicalQuantities.Quantities.Action, unitSystem) { Caption = @"joule-segundo" };
          YottaJouleSecond = new ScaledUnit(@"YottaJouleSecond", @"YJ·s", JouleSecond, 1E+24, 0.0) { Caption = @"yottajoule-segundo" };
          ZettaJouleSecond = new ScaledUnit(@"ZettaJouleSecond", @"ZJ·s", JouleSecond, 1E+21, 0.0) { Caption = @"zettajoule-segundo" };
          ExaJouleSecond = new ScaledUnit(@"ExaJouleSecond", @"EJ·s", JouleSecond, 1E+18, 0.0) { Caption = @"exajoule-segundo" };
          PetaJouleSecond = new ScaledUnit(@"PetaJouleSecond", @"PJ·s", JouleSecond, 1E+15, 0.0) { Caption = @"petajoule-segundo" };
          TeraJouleSecond = new ScaledUnit(@"TeraJouleSecond", @"TJ·s", JouleSecond, 1000000000000, 0.0) { Caption = @"terajoule-segundo" };
          GigaJouleSecond = new ScaledUnit(@"GigaJouleSecond", @"GJ·s", JouleSecond, 1000000000, 0.0) { Caption = @"gigajoule-segundo" };
          MegaJouleSecond = new ScaledUnit(@"MegaJouleSecond", @"MJ·s", JouleSecond, 1000000, 0.0) { Caption = @"megajoule-segundo" };
          KiloJouleSecond = new ScaledUnit(@"KiloJouleSecond", @"kJ·s", JouleSecond, 1000, 0.0) { Caption = @"kilojoule-segundo" };
          HectoJouleSecond = new ScaledUnit(@"HectoJouleSecond", @"hJ·s", JouleSecond, 100, 0.0) { Caption = @"hectojoule-segundo" };
          DecaJouleSecond = new ScaledUnit(@"DecaJouleSecond", @"daJ·s", JouleSecond, 10, 0.0) { Caption = @"decajoule-segundo" };
          DeciJouleSecond = new ScaledUnit(@"DeciJouleSecond", @"dJ·s", JouleSecond, 0.1, 0.0) { Caption = @"decijoule-segundo" };
          CentiJouleSecond = new ScaledUnit(@"CentiJouleSecond", @"cJ·s", JouleSecond, 0.01, 0.0) { Caption = @"centijoule-segundo" };
          MilliJouleSecond = new ScaledUnit(@"MilliJouleSecond", @"mJ·s", JouleSecond, 0.001, 0.0) { Caption = @"milijoule-segundo" };
          MicroJouleSecond = new ScaledUnit(@"MicroJouleSecond", @"μJ·s", JouleSecond, 1E-06, 0.0) { Caption = @"microjoule-segundo" };
          NanoJouleSecond = new ScaledUnit(@"NanoJouleSecond", @"nJ·s", JouleSecond, 1E-09, 0.0) { Caption = @"nanojoule-segundo" };
          PicoJouleSecond = new ScaledUnit(@"PicoJouleSecond", @"pJ·s", JouleSecond, 1E-12, 0.0) { Caption = @"picojoule-segundo" };
          FemtoJouleSecond = new ScaledUnit(@"FemtoJouleSecond", @"fJ·s", JouleSecond, 1E-15, 0.0) { Caption = @"femtojoule-segundo" };
          AttoJouleSecond = new ScaledUnit(@"AttoJouleSecond", @"aJ·s", JouleSecond, 1E-18, 0.0) { Caption = @"attojoule-segundo" };
          ZeptoJouleSecond = new ScaledUnit(@"ZeptoJouleSecond", @"zJ·s", JouleSecond, 1E-21, 0.0) { Caption = @"zeptojoule-segundo" };
          YoctoJouleSecond = new ScaledUnit(@"YoctoJouleSecond", @"yJ·s", JouleSecond, 1E-24, 0.0) { Caption = @"yoctojoule-segundo" };
          PlanckConstant = new ScaledUnit(@"PlanckConstant", @"h", JouleSecond, 6.6260695729E-34, 0) { Caption = @"constante de planck" };
          ReducedPlanckConstant = new ScaledUnit(@"ReducedPlanckConstant", @"ħ", PlanckConstant, 0.159154943091895, 0) { Caption = @"constante de planck reducida" };

          allUnits = new Dictionary<string, Unit>
          {
            { JouleSecond.Name, JouleSecond },
            { YottaJouleSecond.Name, YottaJouleSecond },
            { ZettaJouleSecond.Name, ZettaJouleSecond },
            { ExaJouleSecond.Name, ExaJouleSecond },
            { PetaJouleSecond.Name, PetaJouleSecond },
            { TeraJouleSecond.Name, TeraJouleSecond },
            { GigaJouleSecond.Name, GigaJouleSecond },
            { MegaJouleSecond.Name, MegaJouleSecond },
            { KiloJouleSecond.Name, KiloJouleSecond },
            { HectoJouleSecond.Name, HectoJouleSecond },
            { DecaJouleSecond.Name, DecaJouleSecond },
            { DeciJouleSecond.Name, DeciJouleSecond },
            { CentiJouleSecond.Name, CentiJouleSecond },
            { MilliJouleSecond.Name, MilliJouleSecond },
            { MicroJouleSecond.Name, MicroJouleSecond },
            { NanoJouleSecond.Name, NanoJouleSecond },
            { PicoJouleSecond.Name, PicoJouleSecond },
            { FemtoJouleSecond.Name, FemtoJouleSecond },
            { AttoJouleSecond.Name, AttoJouleSecond },
            { ZeptoJouleSecond.Name, ZeptoJouleSecond },
            { YoctoJouleSecond.Name, YoctoJouleSecond },
            { PlanckConstant.Name, PlanckConstant },
            { ReducedPlanckConstant.Name, ReducedPlanckConstant },
          };
        }

        static Action()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
