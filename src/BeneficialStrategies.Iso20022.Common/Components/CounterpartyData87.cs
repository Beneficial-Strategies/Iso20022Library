// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data specific to counterparties and related informations.
/// </summary>
[IsoId("_Jj8y8cg1EeuGrNSsxk3B0A")]
[DisplayName("Counterparty Data")]
public partial record CounterpartyData87
{
    #nullable enable
    
    /// <summary>
    /// Unique code identifying the entity which submits the report. In the case where submission of the report has been delegated to a third party or to the other counterparty, a unique code identifying that entity.
    /// </summary>
    [IsoId("_Jlttgcg1EeuGrNSsxk3B0A")]
    [DisplayName("Report Submitting Entity")]
    [IsoXmlTag("RptSubmitgNtty")]
    public required OrganisationIdentification15Choice_ ReportSubmittingEntity { get; init; } 
    
    /// <summary>
    /// Unique code identifying the reporting counterparty.
    /// </summary>
    [IsoId("_Jlttg8g1EeuGrNSsxk3B0A")]
    [DisplayName("Reporting Counterparty")]
    [IsoXmlTag("RptgCtrPty")]
    public required OrganisationIdentification15Choice_ ReportingCounterparty { get; init; } 
    
    /// <summary>
    /// Unique code identifying the entity in the case where a financial counterparty is responsible for reporting on behalf of the other counterparty, the unique code identifying that counterparty.
    /// </summary>
    [IsoId("_Jltthcg1EeuGrNSsxk3B0A")]
    [DisplayName("Entity Responsible For Report")]
    [IsoXmlTag("NttyRspnsblForRpt")]
    public OrganisationIdentification15Choice_? EntityResponsibleForReport { get; init; } 
    
    
    #nullable disable
    
}
