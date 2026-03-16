// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the resulting position after a trade should be an opening position or closing position.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__viXlNojEeC60axPepSq7g_-268470699")]
[Description(
    @"Indicates whether the resulting position after a trade should be an opening position or closing position."
)]
[DerivedFrom(typeof(PositionEffectV2Code))]
public enum PositionEffect2Code
{
    /// <summary>
    /// Position after the trade the position should be open.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("__viXldojEeC60axPepSq7g_-1942211273")]
    [Description(@"Position after the trade the position should be open.")]
    OpenPosition = PositionEffectV2Code.OpenPosition, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Position after the trade the position should be closed.
    /// Encoded/decoded by serializers as &quot;CLOS&quot;.
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("__viXltojEeC60axPepSq7g_-2056050339")]
    [Description(@"Position after the trade the position should be closed.")]
    ClosePosition = PositionEffectV2Code.ClosePosition, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Results in a position obtained in a security previously held, sold and repurchased.
    /// Encoded/decoded by serializers as &quot;ROLL&quot;.
    /// </summary>
    [EnumMember(Value = "ROLL")]
    [IsoId("__vrhgNojEeC60axPepSq7g_-686072263")]
    [Description(
        @"Results in a position obtained in a security previously held, sold and repurchased."
    )]
    Rolled = PositionEffectV2Code.Rolled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// First in, first out. Results in a position obtained after having sold in priority the securities bought chronologically.
    /// Encoded/decoded by serializers as &quot;FIFO&quot;.
    /// </summary>
    [EnumMember(Value = "FIFO")]
    [IsoId("__vrhgdojEeC60axPepSq7g_-100125237")]
    [Description(
        @"First in, first out. Results in a position obtained after having sold in priority the securities bought chronologically."
    )]
    Fifo = PositionEffectV2Code.Fifo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade relates to a closure of an account.
    /// Encoded/decoded by serializers as &quot;CLOA&quot;.
    /// </summary>
    [EnumMember(Value = "CLOA")]
    [IsoId("__vrhgtojEeC60axPepSq7g_1367023526")]
    [Description(@"Trade relates to a closure of an account.")]
    CloseAccount = PositionEffectV2Code.CloseAccount, // same ordinal as derivation source for type conversions
}
