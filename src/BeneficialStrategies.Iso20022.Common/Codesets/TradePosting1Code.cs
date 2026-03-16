// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the trade is maintained as a separate individual position in the clearing account, or not.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-fsj16MOEeCojJW5vEuTEQ_-1075208421")]
[Description(
    @"Specifies the trade is maintained as a separate individual position in the clearing account, or not."
)]
[DerivedFrom(typeof(TradePostingCode))]
public enum TradePosting1Code
{
    /// <summary>
    /// Trade is maintained as a separate individual position in the clearing account.
    /// Encoded/decoded by serializers as &quot;GROS&quot;.
    /// </summary>
    [EnumMember(Value = "GROS")]
    [IsoId("_-fsj2KMOEeCojJW5vEuTEQ_142944546")]
    [Description(@"Trade is maintained as a separate individual position in the clearing account.")]
    Gross = TradePostingCode.Gross, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade is maintained as a net position in the clearing account.
    /// Encoded/decoded by serializers as &quot;NETT&quot;.
    /// </summary>
    [EnumMember(Value = "NETT")]
    [IsoId("_-fsj2aMOEeCojJW5vEuTEQ_1610093309")]
    [Description(@"Trade is maintained as a net position in the clearing account.")]
    Net = TradePostingCode.Net, // same ordinal as derivation source for type conversions
}
