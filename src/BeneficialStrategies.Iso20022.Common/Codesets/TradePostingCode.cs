// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the trade is maintained as a separate individual position in the clearing account, or not.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-fsj1KMOEeCojJW5vEuTEQ_1016949174")]
[Description(
    @"Specifies the trade is maintained as a separate individual position in the clearing account, or not."
)]
[Derivations(typeof(TradePosting1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TradePostingCode>))]
#endif
public enum TradePostingCode
{
    /// <summary>
    /// Trade is maintained as a separate individual position in the clearing account.
    /// Encoded/decoded by serializers as &quot;GROS&quot;.
    /// </summary>
    [EnumMember(Value = "GROS")]
    [IsoId("_-fsj1aMOEeCojJW5vEuTEQ_-309637518")]
    [Description(@"Trade is maintained as a separate individual position in the clearing account.")]
    Gross,

    /// <summary>
    /// Trade is maintained as a net position in the clearing account.
    /// Encoded/decoded by serializers as &quot;NETT&quot;.
    /// </summary>
    [EnumMember(Value = "NETT")]
    [IsoId("_-fsj1qMOEeCojJW5vEuTEQ_-1574089543")]
    [Description(@"Trade is maintained as a net position in the clearing account.")]
    Net,
}
