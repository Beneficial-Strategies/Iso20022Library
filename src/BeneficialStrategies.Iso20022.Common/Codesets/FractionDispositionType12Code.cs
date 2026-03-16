// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the processing to apply to fractions of securities.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KmzLEJFGEeanIpS4qvJ1tw")]
[Description(@"Indicates the processing to apply to fractions of securities.")]
[DerivedFrom(typeof(FractionDispositionTypeCode))]
public enum FractionDispositionType12Code
{
    /// <summary>
    /// Round down to the nearest whole number.
    /// Encoded/decoded by serializers as &quot;RDDN&quot;.
    /// </summary>
    [EnumMember(Value = "RDDN")]
    [IsoId("_Of_qMZFGEeanIpS4qvJ1tw")]
    [Description(@"Round down to the nearest whole number.")]
    RoundDown = FractionDispositionTypeCode.RoundDown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Round up to the nearest whole number.
    /// Encoded/decoded by serializers as &quot;RDUP&quot;.
    /// </summary>
    [EnumMember(Value = "RDUP")]
    [IsoId("_OqaKcZFGEeanIpS4qvJ1tw")]
    [Description(@"Round up to the nearest whole number.")]
    RoundUp = FractionDispositionTypeCode.RoundUp, // same ordinal as derivation source for type conversions
}
