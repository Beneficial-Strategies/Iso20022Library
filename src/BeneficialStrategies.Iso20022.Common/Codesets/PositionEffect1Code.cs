// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the resulting position after a trade should be an opening position or closing position.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aHWBddp-Ed-ak6NoX_4Aeg_-238274604")]
[Description(
    @"Indicates whether the resulting position after a trade should be an opening position or closing position."
)]
[DerivedFrom(typeof(PositionEffectCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PositionEffect1Code>))]
#endif
public enum PositionEffect1Code
{
    /// <summary>
    /// Position after the trade should be open.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_aHWBdtp-Ed-ak6NoX_4Aeg_-191177094")]
    [Description(@"Position after the trade should be open.")]
    Open = PositionEffectCode.Open, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Position after the trade should be closed.
    /// Encoded/decoded by serializers as &quot;CLOS&quot;.
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_aHWBd9p-Ed-ak6NoX_4Aeg_-191177059")]
    [Description(@"Position after the trade should be closed.")]
    Close = PositionEffectCode.Close, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Results in a position obtained in a security previously held, sold and repurchased.
    /// Encoded/decoded by serializers as &quot;ROLL&quot;.
    /// </summary>
    [EnumMember(Value = "ROLL")]
    [IsoId("_aHfLYNp-Ed-ak6NoX_4Aeg_-191177016")]
    [Description(
        @"Results in a position obtained in a security previously held, sold and repurchased."
    )]
    Rolled = PositionEffectCode.Rolled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// First in, first out. Results in a position obtained after having sold in priority the securities bought chronologically.
    /// Encoded/decoded by serializers as &quot;FIFO&quot;.
    /// </summary>
    [EnumMember(Value = "FIFO")]
    [IsoId("_aHfLYdp-Ed-ak6NoX_4Aeg_-191176981")]
    [Description(
        @"First in, first out. Results in a position obtained after having sold in priority the securities bought chronologically."
    )]
    Fifo = PositionEffectCode.Fifo, // same ordinal as derivation source for type conversions
}
