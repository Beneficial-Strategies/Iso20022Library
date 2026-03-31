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
[IsoId("_TRxXkwEcEeCQm6a_G2yO_w_-1947511446")]
[Description(@"Specifies the status of a trade in a central matching and settlement system.")]
[DerivedFrom(typeof(TradeStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TradeStatus4Code>))]
#endif
public enum TradeStatus4Code
{
    /// <summary>
    /// Trade is rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_TRxXlAEcEeCQm6a_G2yO_w_1524015341")]
    [Description(@"Trade is rejected.")]
    Rejected = TradeStatusCode.Rejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade is matched.
    /// Encoded/decoded by serializers as &quot;FMTC&quot;.
    /// </summary>
    [EnumMember(Value = "FMTC")]
    [IsoId("_TRxXlQEcEeCQm6a_G2yO_w_1232057603")]
    [Description(@"Trade is matched.")]
    Matched = TradeStatusCode.Matched, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade has been marked not ready for settlement.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_TRxXlgEcEeCQm6a_G2yO_w_1410176275")]
    [Description(@"Trade has been marked not ready for settlement.")]
    Suspended = TradeStatusCode.Suspended, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade has been selected for settlement.
    /// Encoded/decoded by serializers as &quot;SMAT&quot;.
    /// </summary>
    [EnumMember(Value = "SMAT")]
    [IsoId("_TRxXlwEcEeCQm6a_G2yO_w_234985250")]
    [Description(@"Trade has been selected for settlement.")]
    SettlementMature = TradeStatusCode.SettlementMature, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade is not authorised.
    /// Encoded/decoded by serializers as &quot;NAUT&quot;.
    /// </summary>
    [EnumMember(Value = "NAUT")]
    [IsoId("_TRxXmAEcEeCQm6a_G2yO_w_2137371109")]
    [Description(@"Trade is not authorised.")]
    NotAuthorised = TradeStatusCode.NotAuthorised, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade is unmatched.
    /// Encoded/decoded by serializers as &quot;UMTC&quot;.
    /// </summary>
    [EnumMember(Value = "UMTC")]
    [IsoId("_TRxXmQEcEeCQm6a_G2yO_w_-512328752")]
    [Description(@"Trade is unmatched.")]
    Unmatched = TradeStatusCode.Unmatched, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade has been split into subtrades for settlement efficiency.
    /// Encoded/decoded by serializers as &quot;SPLI&quot;.
    /// </summary>
    [EnumMember(Value = "SPLI")]
    [IsoId("_TRxXmgEcEeCQm6a_G2yO_w_1978102610")]
    [Description(@"Trade has been split into subtrades for settlement efficiency.")]
    Split = TradeStatusCode.Split, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade is invalid.
    /// Encoded/decoded by serializers as &quot;INVA&quot;.
    /// </summary>
    [EnumMember(Value = "INVA")]
    [IsoId("_TRxXmwEcEeCQm6a_G2yO_w_-671597251")]
    [Description(@"Trade is invalid.")]
    Invalid = TradeStatusCode.Invalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade has not been authorised by the settlement member guaranteeing payment.
    /// Encoded/decoded by serializers as &quot;SMNA&quot;.
    /// </summary>
    [EnumMember(Value = "SMNA")]
    [IsoId("_TRxXnAEcEeCQm6a_G2yO_w_981030257")]
    [Description(@"Trade has not been authorised by the settlement member guaranteeing payment.")]
    SettlementMemberNotAuthorised = TradeStatusCode.SettlementMemberNotAuthorised, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement is complete.
    /// Encoded/decoded by serializers as &quot;STLD&quot;.
    /// </summary>
    [EnumMember(Value = "STLD")]
    [IsoId("_TRxXnQEcEeCQm6a_G2yO_w_-1668669604")]
    [Description(@"Settlement is complete.")]
    Settled = TradeStatusCode.Settled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade is rescinded.
    /// Encoded/decoded by serializers as &quot;RSCD&quot;.
    /// </summary>
    [EnumMember(Value = "RSCD")]
    [IsoId("_TRxXngEcEeCQm6a_G2yO_w_-16042096")]
    [Description(@"Trade is rescinded.")]
    Rescinded = TradeStatusCode.Rescinded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade has been authorised by the settlement member guaranteeing payment.
    /// Encoded/decoded by serializers as &quot;SMAU&quot;.
    /// </summary>
    [EnumMember(Value = "SMAU")]
    [IsoId("_TRxXnwEcEeCQm6a_G2yO_w_-129881162")]
    [Description(@"Trade has been authorised by the settlement member guaranteeing payment.")]
    SettlementMemberAuthorised = TradeStatusCode.SettlementMemberAuthorised, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade is validated.
    /// Encoded/decoded by serializers as &quot;VALI&quot;.
    /// </summary>
    [EnumMember(Value = "VALI")]
    [IsoId("_TRxXoAEcEeCQm6a_G2yO_w_-558429363")]
    [Description(@"Trade is validated.")]
    Validated = TradeStatusCode.Validated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade passed regulatory check.
    /// Encoded/decoded by serializers as &quot;REGC&quot;.
    /// </summary>
    [EnumMember(Value = "REGC")]
    [IsoId("_TRxXoQEcEeCQm6a_G2yO_w_-989327860")]
    [Description(@"Trade passed regulatory check.")]
    RegulatoryChecked = TradeStatusCode.RegulatoryChecked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Both the Opening and the Valuation details of an NDF trade have been matched with corresponding details of a counterparty&apos;s NDF trade.
    /// Encoded/decoded by serializers as &quot;VMTC&quot;.
    /// </summary>
    [EnumMember(Value = "VMTC")]
    [IsoId("_TRxXogEcEeCQm6a_G2yO_w_1165969437")]
    [Description(
        @"Both the Opening and the Valuation details of an NDF trade have been matched with corresponding details of a counterparty's NDF trade."
    )]
    MatchedValued = TradeStatusCode.MatchedValued, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Part, but not all, of a Trade&apos;s value has settled, and no further elements of the Trade&apos;s value are expected to be settled.
    /// Encoded/decoded by serializers as &quot;PSTL&quot;.
    /// </summary>
    [EnumMember(Value = "PSTL")]
    [IsoId("_TRxXowEcEeCQm6a_G2yO_w_-558682470")]
    [Description(
        @"Part, but not all, of a Trade's value has settled, and no further elements of the Trade's value are expected to be settled."
    )]
    PartiallySettled = TradeStatusCode.PartiallySettled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade is suspended for regulatory reasons.
    /// Encoded/decoded by serializers as &quot;REGS&quot;.
    /// </summary>
    [EnumMember(Value = "REGS")]
    [IsoId("_TRxXpAEcEeCQm6a_G2yO_w_1580732137")]
    [Description(@"Trade is suspended for regulatory reasons.")]
    RegulatorySuspended = TradeStatusCode.RegulatorySuspended, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade settlement is rejected.
    /// Encoded/decoded by serializers as &quot;SRJC&quot;.
    /// </summary>
    [EnumMember(Value = "SRJC")]
    [IsoId("_TR6hgAEcEeCQm6a_G2yO_w_-643850942")]
    [Description(@"Trade settlement is rejected.")]
    SettlementRejected = TradeStatusCode.SettlementRejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option has matured.
    /// Encoded/decoded by serializers as &quot;OPMA&quot;.
    /// </summary>
    [EnumMember(Value = "OPMA")]
    [IsoId("_TR6hgQEcEeCQm6a_G2yO_w_-456348629")]
    [Description(@"Option has matured.")]
    OptionMature = TradeStatusCode.OptionMature, // same ordinal as derivation source for type conversions
}
