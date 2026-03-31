// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the rounding direction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y-Bo9dp-Ed-ak6NoX_4Aeg_2066033818")]
[Description(@"Specifies the rounding direction.")]
[DerivedFrom(typeof(RoundingDirectionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RoundingDirection1Code>))]
#endif
public enum RoundingDirection1Code
{
    /// <summary>
    /// Round up to the nearest whole number.
    /// Encoded/decoded by serializers as &quot;RDUP&quot;.
    /// </summary>
    [EnumMember(Value = "RDUP")]
    [IsoId("_Y-Bo9tp-Ed-ak6NoX_4Aeg_2066033827")]
    [Description(@"Round up to the nearest whole number.")]
    RoundUp = RoundingDirectionCode.RoundUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Round down to the nearest whole number.
    /// Encoded/decoded by serializers as &quot;RDWN&quot;.
    /// </summary>
    [EnumMember(Value = "RDWN")]
    [IsoId("_Y-Bo99p-Ed-ak6NoX_4Aeg_2066033828")]
    [Description(@"Round down to the nearest whole number.")]
    RoundDown = RoundingDirectionCode.RoundDown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Round up or down to the nearest whole number.
    /// Encoded/decoded by serializers as &quot;STAN&quot;.
    /// </summary>
    [EnumMember(Value = "STAN")]
    [IsoId("_Y-Bo-Np-Ed-ak6NoX_4Aeg_-1599090070")]
    [Description(@"Round up or down to the nearest whole number.")]
    RoundToNearest = RoundingDirectionCode.RoundToNearest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Do not round.
    /// Encoded/decoded by serializers as &quot;DIST&quot;.
    /// </summary>
    [EnumMember(Value = "DIST")]
    [IsoId("_Y-LZ8Np-Ed-ak6NoX_4Aeg_-1566769655")]
    [Description(@"Do not round.")]
    IssueFraction = RoundingDirectionCode.IssueFraction, // same ordinal as derivation source for type conversions
}
