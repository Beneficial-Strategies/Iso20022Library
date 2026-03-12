// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Compares information related to both sides of a counterparty.
/// </summary>
[IsoId("_h9g0mTAlEe2Ne600gC45nw")]
[DisplayName("Counterparty Matching Criteria")]
public partial record CounterpartyMatchingCriteria6
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the information on the reporting counterparties are matching or not.
    /// </summary>
    [IsoId("_h-ed4TAlEe2Ne600gC45nw")]
    [DisplayName("Reporting Counterparty")]
    [IsoXmlTag("RptgCtrPty")]
    public CompareOrganisationIdentification6? ReportingCounterparty { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the other counterparties are matching or not.
    /// </summary>
    [IsoId("_h-ed4zAlEe2Ne600gC45nw")]
    [DisplayName("Other Counterparty")]
    [IsoXmlTag("OthrCtrPty")]
    public CompareOrganisationIdentification7? OtherCounterparty { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the direction and side of leg are matching or not.
    /// </summary>
    [IsoId("_h-ed5zAlEe2Ne600gC45nw")]
    [DisplayName("Direction Or Side")]
    [IsoXmlTag("DrctnOrSd")]
    public CompareLegDirection2? DirectionOrSide { get; init; } 
    
    
    #nullable disable
    
}
