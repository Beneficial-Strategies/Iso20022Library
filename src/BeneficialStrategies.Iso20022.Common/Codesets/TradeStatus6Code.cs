// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a trade in a central matching and settlement system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_krjDEZU7EeaYkf5FCqYMeA")]
[Description(@"Specifies the status of a trade in a central matching and settlement system.")]
[DerivedFrom(typeof(TradeStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TradeStatus6Code>))]
#endif
public enum TradeStatus6Code
{
    /// <summary>
    /// Trade is invalid.
    /// Encoded/decoded by serializers as &quot;INVA&quot;.
    /// </summary>
    [EnumMember(Value = "INVA")]
    [IsoId("_k2IicZU7EeaYkf5FCqYMeA")]
    [Description(@"Trade is invalid.")]
    Invalid = TradeStatusCode.Invalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade is matched.
    /// Encoded/decoded by serializers as &quot;FMTC&quot;.
    /// </summary>
    [EnumMember(Value = "FMTC")]
    [IsoId("_k2Iic5U7EeaYkf5FCqYMeA")]
    [Description(@"Trade is matched.")]
    Matched = TradeStatusCode.Matched, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade has been selected for settlement and is pending.
    /// Encoded/decoded by serializers as &quot;SMAP&quot;.
    /// </summary>
    [EnumMember(Value = "SMAP")]
    [IsoId("_k2Iid5U7EeaYkf5FCqYMeA")]
    [Description(@"Trade has been selected for settlement and is pending.")]
    SettlementMaturePending = TradeStatusCode.SettlementMaturePending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade is rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_k2Iie5U7EeaYkf5FCqYMeA")]
    [Description(@"Trade is rejected.")]
    Rejected = TradeStatusCode.Rejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade is rescinded.
    /// Encoded/decoded by serializers as &quot;RSCD&quot;.
    /// </summary>
    [EnumMember(Value = "RSCD")]
    [IsoId("_k2IifZU7EeaYkf5FCqYMeA")]
    [Description(@"Trade is rescinded.")]
    Rescinded = TradeStatusCode.Rescinded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement is complete.
    /// Encoded/decoded by serializers as &quot;STLD&quot;.
    /// </summary>
    [EnumMember(Value = "STLD")]
    [IsoId("_k2Iif5U7EeaYkf5FCqYMeA")]
    [Description(@"Settlement is complete.")]
    Settled = TradeStatusCode.Settled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade has been split into subtrades for settlement efficiency.
    /// Encoded/decoded by serializers as &quot;SPLI&quot;.
    /// </summary>
    [EnumMember(Value = "SPLI")]
    [IsoId("_k2IihZU7EeaYkf5FCqYMeA")]
    [Description(@"Trade has been split into subtrades for settlement efficiency.")]
    Split = TradeStatusCode.Split, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade is unmatched.
    /// Encoded/decoded by serializers as &quot;UMTC&quot;.
    /// </summary>
    [EnumMember(Value = "UMTC")]
    [IsoId("_k2IiiZU7EeaYkf5FCqYMeA")]
    [Description(@"Trade is unmatched.")]
    Unmatched = TradeStatusCode.Unmatched, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade has been selected for settlement.
    /// Encoded/decoded by serializers as &quot;SMAT&quot;.
    /// </summary>
    [EnumMember(Value = "SMAT")]
    [IsoId("_k2Iii5U7EeaYkf5FCqYMeA")]
    [Description(@"Trade has been selected for settlement.")]
    SettlementMature = TradeStatusCode.SettlementMature, // same ordinal as derivation source for type conversions

    /// <summary>
    /// For NDF instructions, if a party has submitted both the open and fix confirmations and the counterparty is yet to submit the open and fix confirmation the instruction is updated to ‘Fix Unmatched’ Status.
    /// Encoded/decoded by serializers as &quot;FUMT&quot;.
    /// </summary>
    [EnumMember(Value = "FUMT")]
    [IsoId("_jEGx4ZVAEeaYkf5FCqYMeA")]
    [Description(
        @"For NDF instructions, if a party has submitted both the open and fix confirmations and the counterparty is yet to submit the open and fix confirmation the instruction is updated to ‘Fix Unmatched’ Status."
    )]
    FixUnmatched = TradeStatusCode.FixUnmatched, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade has been netted by the central system.
    /// Encoded/decoded by serializers as &quot;NETT&quot;.
    /// </summary>
    [EnumMember(Value = "NETT")]
    [IsoId("_j--espVAEeaYkf5FCqYMeA")]
    [Description(@"Trade has been netted by the central system.")]
    Netted = TradeStatusCode.Netted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// For NDF instructions, open confirmations are matched and the Fix confirmations are not matched.
    /// Encoded/decoded by serializers as &quot;PFIX&quot;.
    /// </summary>
    [EnumMember(Value = "PFIX")]
    [IsoId("_lPS3EpVAEeaYkf5FCqYMeA")]
    [Description(
        @"For NDF instructions, open confirmations are matched and the Fix confirmations are not matched."
    )]
    PartialFix = TradeStatusCode.PartialFix, // same ordinal as derivation source for type conversions

    /// <summary>
    /// For NDF trades, the trade is marked as open match when both open confirmations from both parties match.
    /// Encoded/decoded by serializers as &quot;OMTC&quot;.
    /// </summary>
    [EnumMember(Value = "OMTC")]
    [IsoId("_Idn3QaAcEea9x5aZm6UTkw")]
    [Description(
        @"For NDF trades, the trade is marked as open match when both open confirmations from both parties match."
    )]
    OpenMatched = TradeStatusCode.OpenMatched, // same ordinal as derivation source for type conversions
}
