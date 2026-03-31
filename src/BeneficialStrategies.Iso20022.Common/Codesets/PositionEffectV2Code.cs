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
[IsoId("__tJx8tojEeC60axPepSq7g_1840994325")]
[Description(
    @"Indicates whether the resulting position after a trade should be an opening position or closing position."
)]
[Derivations(typeof(PositionEffect2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PositionEffectV2Code>))]
#endif
public enum PositionEffectV2Code
{
    /// <summary>
    /// Position after the trade the position should be open.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("__tJx89ojEeC60axPepSq7g_1727155259")]
    [Description(@"Position after the trade the position should be open.")]
    OpenPosition,

    /// <summary>
    /// Position after the trade the position should be closed.
    /// Encoded/decoded by serializers as &quot;CLOS&quot;.
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("__tJx9NojEeC60axPepSq7g_1022040644")]
    [Description(@"Position after the trade the position should be closed.")]
    ClosePosition,

    /// <summary>
    /// Results in a position obtained in a security previously held, sold and repurchased.
    /// Encoded/decoded by serializers as &quot;ROLL&quot;.
    /// </summary>
    [EnumMember(Value = "ROLL")]
    [IsoId("__tJx9dojEeC60axPepSq7g_-153150381")]
    [Description(
        @"Results in a position obtained in a security previously held, sold and repurchased."
    )]
    Rolled,

    /// <summary>
    /// First in, first out. Results in a position obtained after having sold in priority the securities bought chronologically.
    /// Encoded/decoded by serializers as &quot;FIFO&quot;.
    /// </summary>
    [EnumMember(Value = "FIFO")]
    [IsoId("__tS74NojEeC60axPepSq7g_1492117054")]
    [Description(
        @"First in, first out. Results in a position obtained after having sold in priority the securities bought chronologically."
    )]
    Fifo,

    /// <summary>
    /// Trade relates to a closure of an account.
    /// Encoded/decoded by serializers as &quot;CLOA&quot;.
    /// </summary>
    [EnumMember(Value = "CLOA")]
    [IsoId("__tS74dojEeC60axPepSq7g_1101005930")]
    [Description(@"Trade relates to a closure of an account.")]
    CloseAccount,
}
