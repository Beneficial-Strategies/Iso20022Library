// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates if the method for interest calculation is simple or compounding.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Ya3Rhtp-Ed-ak6NoX_4Aeg_147505423")]
[Description(@"Indicates if the method for interest calculation is simple or compounding.")]
[DerivedFrom(typeof(CalculationMethodCode))]
public enum CalculationMethod1Code
{
    /// <summary>
    /// Calculation method by which interest is calculated on the original principal only. Accumulated interest from prior periods is not used in calculations for the following periods.
    /// Encoded/decoded by serializers as &quot;SIMP&quot;.
    /// </summary>
    [EnumMember(Value = "SIMP")]
    [IsoId("_Ya3Rh9p-Ed-ak6NoX_4Aeg_-26581330")]
    [Description(
        @"Calculation method by which interest is calculated on the original principal only. Accumulated interest from prior periods is not used in calculations for the following periods."
    )]
    Simple = CalculationMethodCode.Simple, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Calculation method by which interest is calculated each period on the original principal and all interest accumulated during past periods.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_Ya3RiNp-Ed-ak6NoX_4Aeg_1910643843")]
    [Description(
        @"Calculation method by which interest is calculated each period on the original principal and all interest accumulated during past periods."
    )]
    Compounding = CalculationMethodCode.Compounding, // same ordinal as derivation source for type conversions
}
