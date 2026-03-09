// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// See narrative field for reason.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a1h9Itp-Ed-ak6NoX_4Aeg_1210390507")]
[Description(@"See narrative field for reason.")]
[Derivations(typeof(CancelledStatusReason7Code),typeof(CancelledStatusReason13Code),typeof(CancelledStatusReason4Code),typeof(CancelledStatusReason12Code),typeof(CancelledStatusReason11Code),typeof(CancelledStatusReason14Code),typeof(CancelledStatusReason9Code),typeof(CancelledStatusReason5Code),typeof(CancelledStatusReason15Code),typeof(CancelledStatusReason6Code),typeof(CancelledStatusReason10Code),typeof(CancelledStatusReason16Code))]
public enum CancelledStatusReasonV2Code
{
    /// <summary>
    /// Transaction is cancelled by yourself.
    /// Encoded/decoded by serializers as &quot;CANI&quot;.
    /// </summary>
    [EnumMember(Value = "CANI")]
    [IsoId("_a1h9I9p-Ed-ak6NoX_4Aeg_1210390516")]
    [Description(@"Transaction is cancelled by yourself.")]
    CancelledByYourself,
    
    /// <summary>
    /// Transaction is cancelled by the system.
    /// Encoded/decoded by serializers as &quot;CANS&quot;.
    /// </summary>
    [EnumMember(Value = "CANS")]
    [IsoId("_a1h9JNp-Ed-ak6NoX_4Aeg_1210390532")]
    [Description(@"Transaction is cancelled by the system.")]
    CancelledBySystem,
    
    /// <summary>
    /// Instruction has been cancelled by the agent due to an event deadline extension.
    /// Encoded/decoded by serializers as &quot;CSUB&quot;.
    /// </summary>
    [EnumMember(Value = "CSUB")]
    [IsoId("_a1h9Jdp-Ed-ak6NoX_4Aeg_1210390549")]
    [Description(@"Instruction has been cancelled by the agent due to an event deadline extension.")]
    CancelledByAgent,
    
    /// <summary>
    /// Transaction is cancelled by the hub.
    /// Encoded/decoded by serializers as &quot;CANH&quot;.
    /// </summary>
    [EnumMember(Value = "CANH")]
    [IsoId("_a1h9Jtp-Ed-ak6NoX_4Aeg_1210390592")]
    [Description(@"Transaction is cancelled by the hub.")]
    CancelledByHub,
    
    /// <summary>
    /// Transaction is cancelled by the instructing party.
    /// Encoded/decoded by serializers as &quot;CANP&quot;.
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_a1h9J9p-Ed-ak6NoX_4Aeg_1210390593")]
    [Description(@"Transaction is cancelled by the instructing party.")]
    CancelledByInstructingParty,
    
    /// <summary>
    /// Transaction is rejected by the executing party, the rejection is final therefore the order is cancelled in the system.
    /// Encoded/decoded by serializers as &quot;CXLR&quot;.
    /// </summary>
    [EnumMember(Value = "CXLR")]
    [IsoId("_a1h9KNp-Ed-ak6NoX_4Aeg_1210390609")]
    [Description(@"Transaction is rejected by the executing party, the rejection is final therefore the order is cancelled in the system.")]
    EndOfLife,
    
    /// <summary>
    /// Transaction is cancelled by a party other than the instructing party, for example, a market infrastructure such as a stock exchange.
    /// Encoded/decoded by serializers as &quot;CANO&quot;.
    /// </summary>
    [EnumMember(Value = "CANO")]
    [IsoId("_a1ruINp-Ed-ak6NoX_4Aeg_1210390610")]
    [Description(@"Transaction is cancelled by a party other than the instructing party, for example, a market infrastructure such as a stock exchange.")]
    CancelledByOther,
    
    /// <summary>
    /// Transaction is cancelled by the transfer agent.
    /// Encoded/decoded by serializers as &quot;CNTA&quot;.
    /// </summary>
    [EnumMember(Value = "CNTA")]
    [IsoId("_a1ruIdp-Ed-ak6NoX_4Aeg_1210390627")]
    [Description(@"Transaction is cancelled by the transfer agent.")]
    CancelledByTransferAgent,
    
    /// <summary>
    /// Transaction is cancelled by the client.
    /// Encoded/decoded by serializers as &quot;CNCL&quot;.
    /// </summary>
    [EnumMember(Value = "CNCL")]
    [IsoId("_a1ruItp-Ed-ak6NoX_4Aeg_1210390644")]
    [Description(@"Transaction is cancelled by the client.")]
    CancelledByClient,
    
    /// <summary>
    /// Transaction is cancelled by the intermediary.
    /// Encoded/decoded by serializers as &quot;CNIN&quot;.
    /// </summary>
    [EnumMember(Value = "CNIN")]
    [IsoId("_a1ruI9p-Ed-ak6NoX_4Aeg_1210390645")]
    [Description(@"Transaction is cancelled by the intermediary.")]
    CancelledByIntermediary,
    
    /// <summary>
    /// Original transaction has been cancelled and replaced due to a corporate action.
    /// Encoded/decoded by serializers as &quot;CANT&quot;.
    /// </summary>
    [EnumMember(Value = "CANT")]
    [IsoId("_a1ruJNp-Ed-ak6NoX_4Aeg_1040198338")]
    [Description(@"Original transaction has been cancelled and replaced due to a corporate action.")]
    CancelledDueToTransformation,
    
    /// <summary>
    /// Original transaction has been cancelled and replaced to allow a partial or split settlement.
    /// Encoded/decoded by serializers as &quot;CANZ&quot;.
    /// </summary>
    [EnumMember(Value = "CANZ")]
    [IsoId("_a1ruJdp-Ed-ak6NoX_4Aeg_1124237850")]
    [Description(@"Original transaction has been cancelled and replaced to allow a partial or split settlement.")]
    CancelledSplitPartialSettlement,
    
    /// <summary>
    /// Transaction has been cancelled due to a corporate action.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_a1ruJtp-Ed-ak6NoX_4Aeg_1420685614")]
    [Description(@"Transaction has been cancelled due to a corporate action.")]
    CancelledDueToCorporateAction,
    
    /// <summary>
    /// Transaction has been cancelled by the issuer/registrar.
    /// Encoded/decoded by serializers as &quot;CREG&quot;.
    /// </summary>
    [EnumMember(Value = "CREG")]
    [IsoId("_a1ruJ9p-Ed-ak6NoX_4Aeg_1510268130")]
    [Description(@"Transaction has been cancelled by the issuer/registrar.")]
    CancelledByIssuerRegistrar,
    
    /// <summary>
    /// Transaction has been cancelled; the security no longer exists or is no longer eligible on the market instructed. For corporate action related cancellation, CORP should be used.
    /// Encoded/decoded by serializers as &quot;SCEX&quot;.
    /// </summary>
    [EnumMember(Value = "SCEX")]
    [IsoId("_a1ruKNp-Ed-ak6NoX_4Aeg_1822417371")]
    [Description(@"Transaction has been cancelled; the security no longer exists or is no longer eligible on the market instructed. For corporate action related cancellation, CORP should be used.")]
    SecuritiesNoLongerEligible,
    
    /// <summary>
    /// See narrative field for reason.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_a1ruKdp-Ed-ak6NoX_4Aeg_905447230")]
    [Description(@"See narrative field for reason.")]
    NarrativeReason,
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_a11fINp-Ed-ak6NoX_4Aeg_91595256")]
    [Description(@"Other. See Narrative.")]
    Other,
    
    /// <summary>
    /// Instruction is cancelled by a Third party.
    /// Encoded/decoded by serializers as &quot;CTHP&quot;.
    /// </summary>
    [EnumMember(Value = "CTHP")]
    [IsoId("_DRBwh_5DEeClUvPNHKL9Zw")]
    [Description(@"Instruction is cancelled by a Third party.")]
    CancelledByThirdParty,
    
    /// <summary>
    /// Instruction has been cancelled because a buy-in has been initiated.
    /// Encoded/decoded by serializers as &quot;BYIY&quot;.
    /// </summary>
    [EnumMember(Value = "BYIY")]
    [IsoId("_Fyz1UNB6EeihG9bKfarOOA")]
    [Description(@"Instruction has been cancelled because a buy-in has been initiated.")]
    CancelledDueToBuyIn,
    
}
