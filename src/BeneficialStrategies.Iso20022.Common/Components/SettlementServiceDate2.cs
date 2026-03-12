// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Date related to the settlement of the transaction.
/// </summary>
[IsoId("_7tOX8SuCEeyg-aG5nXcnfg")]
[DisplayName("Settlement Service Date")]
public partial record SettlementServiceDate2
{
    #nullable enable
    
    /// <summary>
    /// Date requested for settlement.
    /// </summary>
    [IsoId("_7zILoSuCEeyg-aG5nXcnfg")]
    [DisplayName("Requested Settlement Date")]
    [IsoXmlTag("ReqdSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedSettlementDate { get; init; } 
    
    /// <summary>
    /// Indicate a deferred Settlement date.
    /// </summary>
    [IsoId("_JK2asCuDEeyg-aG5nXcnfg")]
    [DisplayName("Deferred Settlement Indicator")]
    [IsoXmlTag("DfrrdSttlmInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? DeferredSettlementIndicator { get; init; } 
    
    /// <summary>
    /// Actual date of settlement.
    /// </summary>
    [IsoId("_7zILoyuCEeyg-aG5nXcnfg")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SettlementDate { get; init; } 
    
    /// <summary>
    /// Actual time of settlement.
    /// </summary>
    [IsoId("_7zILpSuCEeyg-aG5nXcnfg")]
    [DisplayName("Settlement Time")]
    [IsoXmlTag("SttlmTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? SettlementTime { get; init; } 
    
    /// <summary>
    /// Identifies the settlement period, cycle or group. May contain settlement frequency or the identification of specific settlement period. For example, daily, monthly or settlementperiod123acd.
    /// </summary>
    [IsoId("_7zILpyuCEeyg-aG5nXcnfg")]
    [DisplayName("Settlement Period")]
    [IsoXmlTag("SttlmPrd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SettlementPeriod { get; init; } 
    
    /// <summary>
    /// Identifies the effective end time of the settlement date and/or period. 
    /// </summary>
    [IsoId("_7zILqSuCEeyg-aG5nXcnfg")]
    [DisplayName("Settlement Cut Off Time")]
    [IsoXmlTag("SttlmCutOffTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? SettlementCutOffTime { get; init; } 
    
    
    #nullable disable
    
}
