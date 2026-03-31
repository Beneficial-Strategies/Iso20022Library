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
[IsoId("_2s_Z0ZU8EeaYkf5FCqYMeA")]
[Description(@"Specifies the status of a trade in a central matching and settlement system.")]
[DerivedFrom(typeof(TradeStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TradeStatus7Code>))]
#endif
public enum TradeStatus7Code
{
    /// <summary>
    /// Trade is invalid.
    /// Encoded/decoded by serializers as &quot;INVA&quot;.
    /// </summary>
    [EnumMember(Value = "INVA")]
    [IsoId("_23ahIZU8EeaYkf5FCqYMeA")]
    [Description(@"Trade is invalid.")]
    Invalid = TradeStatusCode.Invalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade is unmatched.
    /// Encoded/decoded by serializers as &quot;UMTC&quot;.
    /// </summary>
    [EnumMember(Value = "UMTC")]
    [IsoId("_23ahI5U8EeaYkf5FCqYMeA")]
    [Description(@"Trade is unmatched.")]
    Unmatched = TradeStatusCode.Unmatched, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade is matched.
    /// Encoded/decoded by serializers as &quot;FMTC&quot;.
    /// </summary>
    [EnumMember(Value = "FMTC")]
    [IsoId("_23ahKZU8EeaYkf5FCqYMeA")]
    [Description(@"Trade is matched.")]
    Matched = TradeStatusCode.Matched, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade has been selected for settlement.
    /// Encoded/decoded by serializers as &quot;SMAT&quot;.
    /// </summary>
    [EnumMember(Value = "SMAT")]
    [IsoId("_23ahMZU8EeaYkf5FCqYMeA")]
    [Description(@"Trade has been selected for settlement.")]
    SettlementMature = TradeStatusCode.SettlementMature, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade has been marked not ready for settlement.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_23ahNZU8EeaYkf5FCqYMeA")]
    [Description(@"Trade has been marked not ready for settlement.")]
    Suspended = TradeStatusCode.Suspended, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade has been selected for settlement and is pending.
    /// Encoded/decoded by serializers as &quot;SMAP&quot;.
    /// </summary>
    [EnumMember(Value = "SMAP")]
    [IsoId("_97ExIZU8EeaYkf5FCqYMeA")]
    [Description(@"Trade has been selected for settlement and is pending.")]
    SettlementMaturePending = TradeStatusCode.SettlementMaturePending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// For NDF instructions, open confirmations are matched and the Fix confirmations are not matched.
    /// Encoded/decoded by serializers as &quot;PFIX&quot;.
    /// </summary>
    [EnumMember(Value = "PFIX")]
    [IsoId("_pX7gYZVAEeaYkf5FCqYMeA")]
    [Description(
        @"For NDF instructions, open confirmations are matched and the Fix confirmations are not matched."
    )]
    PartialFix = TradeStatusCode.PartialFix, // same ordinal as derivation source for type conversions

    /// <summary>
    /// For NDF instructions, if a party has submitted both the open and fix confirmations and the counterparty is yet to submit the open and fix confirmation the instruction is updated to ‘Fix Unmatched’ Status.
    /// Encoded/decoded by serializers as &quot;FUMT&quot;.
    /// </summary>
    [EnumMember(Value = "FUMT")]
    [IsoId("_sDcrc5VAEeaYkf5FCqYMeA")]
    [Description(
        @"For NDF instructions, if a party has submitted both the open and fix confirmations and the counterparty is yet to submit the open and fix confirmation the instruction is updated to ‘Fix Unmatched’ Status."
    )]
    FixUnmatched = TradeStatusCode.FixUnmatched, // same ordinal as derivation source for type conversions
}
