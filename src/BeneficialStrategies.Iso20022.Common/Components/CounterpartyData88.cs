// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of information specific to the counterparty.
/// </summary>
[IsoId("_zwwsHcg3EeuGrNSsxk3B0A")]
[DisplayName("Counterparty Data")]
public partial record CounterpartyData88
{
    #nullable enable
    
    /// <summary>
    /// Date and time of submission of the report to the trade repository.
    /// </summary>
    [IsoId("_zyM2gcg3EeuGrNSsxk3B0A")]
    [DisplayName("Reporting Date Time")]
    [IsoXmlTag("RptgDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ReportingDateTime { get; init; } 
    
    /// <summary>
    /// Unique code identifying the entity which submits the report. In the case where submission of the report has been delegated to a third party or to the other counterparty, a unique code identifying that entity.
    /// </summary>
    [IsoId("_zyNdkcg3EeuGrNSsxk3B0A")]
    [DisplayName("Report Submitting Entity")]
    [IsoXmlTag("RptSubmitgNtty")]
    public required OrganisationIdentification15Choice_ ReportSubmittingEntity { get; init; } 
    
    /// <summary>
    /// Set of information specific to counterparties.
    /// </summary>
    [IsoId("_zyNdk8g3EeuGrNSsxk3B0A")]
    [DisplayName("Counterparty")]
    [IsoXmlTag("CtrPty")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<CounterpartyData89> Counterparty { get; init; } = [];
    
    
    #nullable disable
    
}
