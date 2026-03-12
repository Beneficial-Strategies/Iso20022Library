// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Attributes of a settlement service.
/// </summary>
[IsoId("_6-z1ISbUEeyhZIgCcGlTyA")]
[DisplayName("Settlement Service")]
public partial record SettlementService4
{
    #nullable enable
    
    /// <summary>
    /// Settlement service actually applied to the transaction.
    /// </summary>
    [IsoId("_7G-5sSbUEeyhZIgCcGlTyA")]
    [DisplayName("Settlement Service Applied")]
    [IsoXmlTag("SttlmSvcApld")]
    public SettlementServiceMode1? SettlementServiceApplied { get; init; } 
    
    /// <summary>
    /// Dates related to the settlement service related to the transaction.
    /// </summary>
    [IsoId("_7G-5sybUEeyhZIgCcGlTyA")]
    [DisplayName("Settlement Service Dates")]
    [IsoXmlTag("SttlmSvcDts")]
    public SettlementServiceDate2? SettlementServiceDates { get; init; } 
    
    /// <summary>
    /// Entity in charge of the settlement reporting service.
    /// </summary>
    [IsoId("_7G-5tSbUEeyhZIgCcGlTyA")]
    [DisplayName("Settlement Reporting Entity")]
    [IsoXmlTag("SttlmRptgNtty")]
    public SettlementReportingEntity1? SettlementReportingEntity { get; init; } 
    
    /// <summary>
    /// Additional Settlement Information.
    /// </summary>
    [IsoId("_FAjm4SbVEeyhZIgCcGlTyA")]
    [DisplayName("Additional Settlement Information")]
    [IsoXmlTag("AddtlSttlmInf")]
    public AdditionalData1? AdditionalSettlementInformation { get; init; } 
    
    
    #nullable disable
    
}
