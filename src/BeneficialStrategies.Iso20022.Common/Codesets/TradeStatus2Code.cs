// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a trade in a central matching and settlement system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vp_FV9p-Ed-ak6NoX_4Aeg_1212704740")]
[Description(@"Specifies the status of a trade in a central matching and settlement system.")]
[DerivedFrom(typeof(TradeStatusCode))]
public enum TradeStatus2Code
{
    /// <summary>
    /// Trade is validated.
    /// Encoded/decoded by serializers as &quot;VALI&quot;.
    /// </summary>
    [EnumMember(Value = "VALI")]
    [IsoId("_Vp_FWNp-Ed-ak6NoX_4Aeg_1624593448")]
    [Description(@"Trade is validated.")]
    Validated = TradeStatusCode.Validated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade passed regulatory check.
    /// Encoded/decoded by serializers as &quot;REGC&quot;.
    /// </summary>
    [EnumMember(Value = "REGC")]
    [IsoId("_VqIPQNp-Ed-ak6NoX_4Aeg_1624593076")]
    [Description(@"Trade passed regulatory check.")]
    RegulatoryChecked = TradeStatusCode.RegulatoryChecked, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade is invalid.
    /// Encoded/decoded by serializers as &quot;INVA&quot;.
    /// </summary>
    [EnumMember(Value = "INVA")]
    [IsoId("_VqIPQdp-Ed-ak6NoX_4Aeg_1624593077")]
    [Description(@"Trade is invalid.")]
    Invalid = TradeStatusCode.Invalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade settlement is rejected.
    /// Encoded/decoded by serializers as &quot;SRJC&quot;.
    /// </summary>
    [EnumMember(Value = "SRJC")]
    [IsoId("_VqIPQtp-Ed-ak6NoX_4Aeg_1624593094")]
    [Description(@"Trade settlement is rejected.")]
    SettlementRejected = TradeStatusCode.SettlementRejected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade is suspended for regulatory reasons.
    /// Encoded/decoded by serializers as &quot;REGS&quot;.
    /// </summary>
    [EnumMember(Value = "REGS")]
    [IsoId("_VqIPQ9p-Ed-ak6NoX_4Aeg_1624593111")]
    [Description(@"Trade is suspended for regulatory reasons.")]
    RegulatorySuspended = TradeStatusCode.RegulatorySuspended, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade is unmatched.
    /// Encoded/decoded by serializers as &quot;UMTC&quot;.
    /// </summary>
    [EnumMember(Value = "UMTC")]
    [IsoId("_VqIPRNp-Ed-ak6NoX_4Aeg_1624593129")]
    [Description(@"Trade is unmatched.")]
    Unmatched = TradeStatusCode.Unmatched, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade is matched.
    /// Encoded/decoded by serializers as &quot;FMTC&quot;.
    /// </summary>
    [EnumMember(Value = "FMTC")]
    [IsoId("_VqIPRdp-Ed-ak6NoX_4Aeg_1624593137")]
    [Description(@"Trade is matched.")]
    Matched = TradeStatusCode.Matched, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade is rescinded.
    /// Encoded/decoded by serializers as &quot;RSCD&quot;.
    /// </summary>
    [EnumMember(Value = "RSCD")]
    [IsoId("_VqIPRtp-Ed-ak6NoX_4Aeg_1624593154")]
    [Description(@"Trade is rescinded.")]
    Rescinded = TradeStatusCode.Rescinded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement is complete.
    /// Encoded/decoded by serializers as &quot;STLD&quot;.
    /// </summary>
    [EnumMember(Value = "STLD")]
    [IsoId("_VqIPR9p-Ed-ak6NoX_4Aeg_1624593171")]
    [Description(@"Settlement is complete.")]
    Settled = TradeStatusCode.Settled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Part, but not all, of a Trade&apos;s value has settled, and no further elements of the Trade&apos;s value are expected to be settled.
    /// Encoded/decoded by serializers as &quot;PSTL&quot;.
    /// </summary>
    [EnumMember(Value = "PSTL")]
    [IsoId("_VqIPSNp-Ed-ak6NoX_4Aeg_1624593189")]
    [Description(@"Part, but not all, of a Trade's value has settled, and no further elements of the Trade's value are expected to be settled.")]
    PartiallySettled = TradeStatusCode.PartiallySettled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Both the Opening and the Valuation details of an NDF trade have been matched with corresponding details of a counterparty&apos;s NDF trade.
    /// Encoded/decoded by serializers as &quot;VMTC&quot;.
    /// </summary>
    [EnumMember(Value = "VMTC")]
    [IsoId("_VqIPSdp-Ed-ak6NoX_4Aeg_1624593431")]
    [Description(@"Both the Opening and the Valuation details of an NDF trade have been matched with corresponding details of a counterparty's NDF trade.")]
    MatchedValued = TradeStatusCode.MatchedValued, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade is rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_VqIPStp-Ed-ak6NoX_4Aeg_1624593432")]
    [Description(@"Trade is rejected.")]
    Rejected = TradeStatusCode.Rejected, // same ordinal as derivation source for type conversions
    
}
