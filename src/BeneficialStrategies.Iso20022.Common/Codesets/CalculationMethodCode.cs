// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the interest calculation method is simple or compounding.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YbAbcNp-Ed-ak6NoX_4Aeg_181218670")]
[Description(@"Specifies whether the interest calculation method is simple or compounding.")]
[Derivations(typeof(CalculationMethod1Code))]
public enum CalculationMethodCode
{
    /// <summary>
    /// Calculation method by which interest is calculated on the original principal only. Accumulated interest from prior periods is not used in calculations for the following periods.
    /// Encoded/decoded by serializers as &quot;SIMP&quot;.
    /// </summary>
    [EnumMember(Value = "SIMP")]
    [IsoId("_YbAbcdp-Ed-ak6NoX_4Aeg_-87374057")]
    [Description(
        @"Calculation method by which interest is calculated on the original principal only. Accumulated interest from prior periods is not used in calculations for the following periods."
    )]
    Simple,

    /// <summary>
    /// Calculation method by which interest is calculated each period on the original principal and all interest accumulated during past periods.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_YbAbctp-Ed-ak6NoX_4Aeg_489801188")]
    [Description(
        @"Calculation method by which interest is calculated each period on the original principal and all interest accumulated during past periods."
    )]
    Compounding,
}
