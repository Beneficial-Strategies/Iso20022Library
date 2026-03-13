// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related specifically to counterparty.
/// </summary>
[IsoId("_4f64UbHYEemRPNDOvJwndA")]
[DisplayName("Counterparty Data")]
public partial record CounterpartyData76
{
    #nullable enable
    
    /// <summary>
    /// Date and time of submission of the report to the trade repository.
    /// </summary>
    [IsoId("_4j8csbHYEemRPNDOvJwndA")]
    [DisplayName("Reporting Date Time")]
    [IsoXmlTag("RptgDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ReportingDateTime { get; init; } 
    
    /// <summary>
    /// Unique code identifying the entity which submits the report. In the case where submission of the report has been delegated to a third party or to the other counterparty, a unique code identifying that entity.
    /// </summary>
    [IsoId("_4j8cs7HYEemRPNDOvJwndA")]
    [DisplayName("Report Submitting Entity")]
    [IsoXmlTag("RptSubmitgNtty")]
    public required OrganisationIdentification9Choice_ ReportSubmittingEntity { get; init; } 
    
    /// <summary>
    /// Data specific to counterparties.
    /// </summary>
    [IsoId("_4j8ctbHYEemRPNDOvJwndA")]
    [DisplayName("Counterparty Data")]
    [IsoXmlTag("CtrPtyData")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<CounterpartyData77> CounterpartyData { get; init; } = [];
    
    
    #nullable disable
    
}
