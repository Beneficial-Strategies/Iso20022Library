// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a trade in a central matching and settlement system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YnFIkdp-Ed-ak6NoX_4Aeg_1584669409")]
[Description(@"Specifies the status of a trade in a central matching and settlement system.")]
[Derivations(typeof(TradeStatus5Code),typeof(TradeStatus7Code),typeof(TradeStatus4Code),typeof(TradeStatus3Code),typeof(TradeStatus6Code),typeof(TradeStatus2Code),typeof(TradeStatus1Code))]
public enum TradeStatusCode
{
    /// <summary>
    /// Trade is validated.
    /// Encoded/decoded by serializers as &quot;VALI&quot;.
    /// </summary>
    [EnumMember(Value = "VALI")]
    [IsoId("_YnFIktp-Ed-ak6NoX_4Aeg_668271251")]
    [Description(@"Trade is validated.")]
    Validated,
    
    /// <summary>
    /// Trade passed regulatory check.
    /// Encoded/decoded by serializers as &quot;REGC&quot;.
    /// </summary>
    [EnumMember(Value = "REGC")]
    [IsoId("_YnFIk9p-Ed-ak6NoX_4Aeg_-1009437897")]
    [Description(@"Trade passed regulatory check.")]
    RegulatoryChecked,
    
    /// <summary>
    /// Trade is invalid.
    /// Encoded/decoded by serializers as &quot;INVA&quot;.
    /// </summary>
    [EnumMember(Value = "INVA")]
    [IsoId("_YnFIlNp-Ed-ak6NoX_4Aeg_-967880102")]
    [Description(@"Trade is invalid.")]
    Invalid,
    
    /// <summary>
    /// Trade settlement is rejected.
    /// Encoded/decoded by serializers as &quot;SRJC&quot;.
    /// </summary>
    [EnumMember(Value = "SRJC")]
    [IsoId("_YnFIldp-Ed-ak6NoX_4Aeg_-966955204")]
    [Description(@"Trade settlement is rejected.")]
    SettlementRejected,
    
    /// <summary>
    /// Trade is suspended for regulatory reasons.
    /// Encoded/decoded by serializers as &quot;REGS&quot;.
    /// </summary>
    [EnumMember(Value = "REGS")]
    [IsoId("_YnFIltp-Ed-ak6NoX_4Aeg_-639105106")]
    [Description(@"Trade is suspended for regulatory reasons.")]
    RegulatorySuspended,
    
    /// <summary>
    /// Trade is unmatched.
    /// Encoded/decoded by serializers as &quot;UMTC&quot;.
    /// </summary>
    [EnumMember(Value = "UMTC")]
    [IsoId("_YnFIl9p-Ed-ak6NoX_4Aeg_-596623705")]
    [Description(@"Trade is unmatched.")]
    Unmatched,
    
    /// <summary>
    /// Trade is matched.
    /// Encoded/decoded by serializers as &quot;FMTC&quot;.
    /// </summary>
    [EnumMember(Value = "FMTC")]
    [IsoId("_YnFImNp-Ed-ak6NoX_4Aeg_-504270578")]
    [Description(@"Trade is matched.")]
    Matched,
    
    /// <summary>
    /// Trade is rescinded.
    /// Encoded/decoded by serializers as &quot;RSCD&quot;.
    /// </summary>
    [EnumMember(Value = "RSCD")]
    [IsoId("_YnO5kNp-Ed-ak6NoX_4Aeg_-222599234")]
    [Description(@"Trade is rescinded.")]
    Rescinded,
    
    /// <summary>
    /// Settlement is complete.
    /// Encoded/decoded by serializers as &quot;STLD&quot;.
    /// </summary>
    [EnumMember(Value = "STLD")]
    [IsoId("_YnO5kdp-Ed-ak6NoX_4Aeg_-191198402")]
    [Description(@"Settlement is complete.")]
    Settled,
    
    /// <summary>
    /// Part, but not all, of a Trade&apos;s value has settled, and no further elements of the Trade&apos;s value are expected to be settled.
    /// Encoded/decoded by serializers as &quot;PSTL&quot;.
    /// </summary>
    [EnumMember(Value = "PSTL")]
    [IsoId("_YnO5ktp-Ed-ak6NoX_4Aeg_374918978")]
    [Description(@"Part, but not all, of a Trade's value has settled, and no further elements of the Trade's value are expected to be settled.")]
    PartiallySettled,
    
    /// <summary>
    /// Both the Opening and the Valuation details of an NDF trade have been matched with corresponding details of a counterparty&apos;s NDF trade.
    /// Encoded/decoded by serializers as &quot;VMTC&quot;.
    /// </summary>
    [EnumMember(Value = "VMTC")]
    [IsoId("_YnO5k9p-Ed-ak6NoX_4Aeg_1197286254")]
    [Description(@"Both the Opening and the Valuation details of an NDF trade have been matched with corresponding details of a counterparty's NDF trade.")]
    MatchedValued,
    
    /// <summary>
    /// Trade is rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_YnO5lNp-Ed-ak6NoX_4Aeg_-364848834")]
    [Description(@"Trade is rejected.")]
    Rejected,
    
    /// <summary>
    /// Option has matured.
    /// Encoded/decoded by serializers as &quot;OPMA&quot;.
    /// </summary>
    [EnumMember(Value = "OPMA")]
    [IsoId("_YnO5ldp-Ed-ak6NoX_4Aeg_-2125018890")]
    [Description(@"Option has matured.")]
    OptionMature,
    
    /// <summary>
    /// Trade has been authorised by the settlement member guaranteeing payment.
    /// Encoded/decoded by serializers as &quot;SMAU&quot;.
    /// </summary>
    [EnumMember(Value = "SMAU")]
    [IsoId("_TXIYsAEcEeCQm6a_G2yO_w_-1476343454")]
    [Description(@"Trade has been authorised by the settlement member guaranteeing payment.")]
    SettlementMemberAuthorised,
    
    /// <summary>
    /// Trade has not been authorised by the settlement member guaranteeing payment.
    /// Encoded/decoded by serializers as &quot;SMNA&quot;.
    /// </summary>
    [EnumMember(Value = "SMNA")]
    [IsoId("_TXIYsQEcEeCQm6a_G2yO_w_-507682625")]
    [Description(@"Trade has not been authorised by the settlement member guaranteeing payment.")]
    SettlementMemberNotAuthorised,
    
    /// <summary>
    /// Trade has been selected for settlement.
    /// Encoded/decoded by serializers as &quot;SMAT&quot;.
    /// </summary>
    [EnumMember(Value = "SMAT")]
    [IsoId("_TXIYsgEcEeCQm6a_G2yO_w_-214067986")]
    [Description(@"Trade has been selected for settlement.")]
    SettlementMature,
    
    /// <summary>
    /// Trade has been split into subtrades for settlement efficiency.
    /// Encoded/decoded by serializers as &quot;SPLI&quot;.
    /// </summary>
    [EnumMember(Value = "SPLI")]
    [IsoId("_TXIYswEcEeCQm6a_G2yO_w_1116960621")]
    [Description(@"Trade has been split into subtrades for settlement efficiency.")]
    Split,
    
    /// <summary>
    /// Trade has been marked not ready for settlement.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_TXIYtAEcEeCQm6a_G2yO_w_1676857510")]
    [Description(@"Trade has been marked not ready for settlement.")]
    Suspended,
    
    /// <summary>
    /// Trade is not authorised.
    /// Encoded/decoded by serializers as &quot;NAUT&quot;.
    /// </summary>
    [EnumMember(Value = "NAUT")]
    [IsoId("_TXIYtQEcEeCQm6a_G2yO_w_1108438667")]
    [Description(@"Trade is not authorised.")]
    NotAuthorised,
    
    /// <summary>
    /// Trade is amended.
    /// Encoded/decoded by serializers as &quot;AMUI&quot;.
    /// </summary>
    [EnumMember(Value = "AMUI")]
    [IsoId("_xkKnQL74EeKP7-K7N5UExg_-1620147750")]
    [Description(@"Trade is amended.")]
    Amended,
    
    /// <summary>
    /// Trade has been selected for settlement and is pending.
    /// Encoded/decoded by serializers as &quot;SMAP&quot;.
    /// </summary>
    [EnumMember(Value = "SMAP")]
    [IsoId("_xkKnQb74EeKP7-K7N5UExg_2039787700")]
    [Description(@"Trade has been selected for settlement and is pending.")]
    SettlementMaturePending,
    
    /// <summary>
    /// Trade has been netted by the central system.
    /// Encoded/decoded by serializers as &quot;NETT&quot;.
    /// </summary>
    [EnumMember(Value = "NETT")]
    [IsoId("_21Y18JU-EeaYkf5FCqYMeA")]
    [Description(@"Trade has been netted by the central system.")]
    Netted,
    
    /// <summary>
    /// For NDF trades, the trade is marked as open match when both open confirmations from both parties match.
    /// Encoded/decoded by serializers as &quot;OMTC&quot;.
    /// </summary>
    [EnumMember(Value = "OMTC")]
    [IsoId("_-MaG0JU-EeaYkf5FCqYMeA")]
    [Description(@"For NDF trades, the trade is marked as open match when both open confirmations from both parties match.")]
    OpenMatched,
    
    /// <summary>
    /// For NDF instructions, if a party has submitted both the open and fix confirmations and the counterparty is yet to submit the open and fix confirmation the instruction is updated to ‘Fix Unmatched’ Status.
    /// Encoded/decoded by serializers as &quot;FUMT&quot;.
    /// </summary>
    [EnumMember(Value = "FUMT")]
    [IsoId("_gZW4UJU_EeaYkf5FCqYMeA")]
    [Description(@"For NDF instructions, if a party has submitted both the open and fix confirmations and the counterparty is yet to submit the open and fix confirmation the instruction is updated to ‘Fix Unmatched’ Status.")]
    FixUnmatched,
    
    /// <summary>
    /// For NDF instructions, open confirmations are matched and the Fix confirmations are not matched.
    /// Encoded/decoded by serializers as &quot;PFIX&quot;.
    /// </summary>
    [EnumMember(Value = "PFIX")]
    [IsoId("_0EPHgJU_EeaYkf5FCqYMeA")]
    [Description(@"For NDF instructions, open confirmations are matched and the Fix confirmations are not matched.")]
    PartialFix,
    
}
