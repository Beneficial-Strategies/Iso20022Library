// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currency Control Group Status3.
/// </summary>
[IsoId("_8AN7sTEyEe6g-ffJsqGiSA")]
[DisplayName("Currency Control Group Status3")]
public partial record CurrencyControlGroupStatus3
{
    #nullable enable

    /// <summary>
    /// Original References.
    /// </summary>
    [DisplayName("Original References")]
    [IsoXmlTag("OrgnlRefs")]
    public required OriginalMessage7 OriginalReferences { get; init; } 

    /// <summary>
    /// Registration Agent.
    /// </summary>
    [DisplayName("Registration Agent")]
    [IsoXmlTag("RegnAgt")]
    public required BranchAndFinancialInstitutionIdentification8 RegistrationAgent { get; init; } 

    /// <summary>
    /// Reporting Party.
    /// </summary>
    [DisplayName("Reporting Party")]
    [IsoXmlTag("RptgPty")]
    public required TradeParty6 ReportingParty { get; init; } 

    /// <summary>
    /// Reporting Period.
    /// </summary>
    [DisplayName("Reporting Period")]
    [IsoXmlTag("RptgPrd")]
    public Period4Choice_? ReportingPeriod { get; init; } 

    /// <summary>
    /// Status.
    /// </summary>
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public StatisticalReportingStatus1Code? Status { get; init; } 

    /// <summary>
    /// Status Date Time.
    /// </summary>
    [DisplayName("Status Date Time")]
    [IsoXmlTag("StsDtTm")]
    public IsoISODateTime? StatusDateTime { get; init; } 

    /// <summary>
    /// Status Reason.
    /// </summary>
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public ValueList<ValidationStatusReason3> StatusReason { get; init; } = [];

    
    #nullable disable
    
}
