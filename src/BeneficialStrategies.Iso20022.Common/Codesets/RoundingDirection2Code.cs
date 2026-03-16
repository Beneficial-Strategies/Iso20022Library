// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the rounding direction applied to nearest unit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y-LZ8dp-Ed-ak6NoX_4Aeg_114226731")]
[Description(@"Specifies the rounding direction applied to nearest unit.")]
[DerivedFrom(typeof(RoundingDirectionCode))]
public enum RoundingDirection2Code
{
    /// <summary>
    /// Round up to the nearest whole number.
    /// Encoded/decoded by serializers as &quot;RDUP&quot;.
    /// </summary>
    [EnumMember(Value = "RDUP")]
    [IsoId("_Y-LZ8tp-Ed-ak6NoX_4Aeg_498412566")]
    [Description(@"Round up to the nearest whole number.")]
    RoundUp = RoundingDirectionCode.RoundUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Round down to the nearest whole number.
    /// Encoded/decoded by serializers as &quot;RDWN&quot;.
    /// </summary>
    [EnumMember(Value = "RDWN")]
    [IsoId("_Y-LZ89p-Ed-ak6NoX_4Aeg_498413939")]
    [Description(@"Round down to the nearest whole number.")]
    RoundDown = RoundingDirectionCode.RoundDown, // same ordinal as derivation source for type conversions
}
