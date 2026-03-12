// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data to be present in a dispute.
/// </summary>
[IsoId("_k5AXMENiEeiut6dbx3wnBg")]
[DisplayName("Dispute Data")]
public partial record DisputeData1
{
    #nullable enable
    
    /// <summary>
    /// Indicates the cycle of presentment or of the chargeback  (1= first cycle for chargeback, 2= second cycle of presentment or chargeback, etc.).
    /// </summary>
    [IsoId("_21nGsENiEeiut6dbx3wnBg")]
    [DisplayName("Presentment Cycle")]
    [IsoXmlTag("PresntmntCycl")]
    [IsoSimpleType(IsoSimpleType.Exact1NumericText)]
    public IsoExact1NumericText? PresentmentCycle { get; init; } 
    
    /// <summary>
    /// Condition of the dispute.
    /// </summary>
    [IsoId("_dBw4sENjEeiut6dbx3wnBg")]
    [DisplayName("Dispute Condition")]
    [IsoXmlTag("DsptCond")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? DisputeCondition { get; init; } 
    
    /// <summary>
    /// Status of dispute.
    /// </summary>
    [IsoId("_2aqaoENjEeiut6dbx3wnBg")]
    [DisplayName("Dispute Status")]
    [IsoXmlTag("DsptSts")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? DisputeStatus { get; init; } 
    
    /// <summary>
    /// Partial dispute indicator.
    /// </summary>
    [IsoId("_MZfCYENkEeiut6dbx3wnBg")]
    [DisplayName("Partial Dispute")]
    [IsoXmlTag("PrtlDspt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PartialDispute { get; init; } 
    
    /// <summary>
    /// Reference for the dispute.
    /// </summary>
    [IsoId("_qnBp9UNiEeiut6dbx3wnBg")]
    [DisplayName("Dispute Reference")]
    [IsoXmlTag("DsptRef")]
    public DisputeReference1? DisputeReference { get; init; } 
    
    /// <summary>
    /// Status of the dispute documentation.
    /// </summary>
    [IsoId("_qnBp-UNiEeiut6dbx3wnBg")]
    [DisplayName("Documentation Status")]
    [IsoXmlTag("DcmnttnSts")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? DocumentationStatus { get; init; } 
    
    /// <summary>
    /// Additional information related to the dispute.
    /// </summary>
    [IsoId("_33w1UENkEeiut6dbx3wnBg")]
    [DisplayName("Additional Dispute Data")]
    [IsoXmlTag("AddtlDsptData")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000 ,MinimumLength = 1)]
    public IsoMax1000Text? AdditionalDisputeData { get; init; } 
    
    /// <summary>
    /// Reason for rejecting a dispute.
    /// </summary>
    [IsoId("_ChtPgENlEeiut6dbx3wnBg")]
    [DisplayName("Dispute Reject Reason")]
    [IsoXmlTag("DsptRjctRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? DisputeRejectReason { get; init; } 
    
    /// <summary>
    /// Provides transaction chargeback eligibility conditions.
    /// </summary>
    [IsoId("_xWWa4JKaEempjNUC7bi_Ng")]
    [DisplayName("Chargeback Eligibility")]
    [IsoXmlTag("ChrgbckElgblty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ChargebackEligibility { get; init; } 
    
    
    #nullable disable
    
}
