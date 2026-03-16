// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of interest rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xwTEsLtKEeSmENFdxjMqzQ")]
[Description(@"Specifies the type of interest rate.")]
[DerivedFrom(typeof(InterestRateTypeCode))]
public enum InterestRateType1Code
{
    /// <summary>
    /// Rate is fixed.
    /// Encoded/decoded by serializers as &quot;FIXE&quot;.
    /// </summary>
    [EnumMember(Value = "FIXE")]
    [IsoId("_y3adwbtKEeSmENFdxjMqzQ")]
    [Description(@"Rate is fixed.")]
    Fixed = InterestRateTypeCode.Fixed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate is variable.
    /// Encoded/decoded by serializers as &quot;VARI&quot;.
    /// </summary>
    [EnumMember(Value = "VARI")]
    [IsoId("_zCH48btKEeSmENFdxjMqzQ")]
    [Description(@"Rate is variable.")]
    Variable = InterestRateTypeCode.Variable, // same ordinal as derivation source for type conversions
}
