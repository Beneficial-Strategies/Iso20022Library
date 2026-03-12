// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Compares information related to both sides of a loan.
/// </summary>
[IsoId("_2rK2ccgxEeuGrNSsxk3B0A")]
[DisplayName("Counterparty Matching Criteria")]
public partial record CounterpartyMatchingCriteria4
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the information on the reporting counterparties are matching or not.
    /// </summary>
    [IsoId("_2tACc8gxEeuGrNSsxk3B0A")]
    [DisplayName("Reporting Counterparty")]
    [IsoXmlTag("RptgCtrPty")]
    public CompareOrganisationIdentification6? ReportingCounterparty { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the other counterparties are matching or not.
    /// </summary>
    [IsoId("_2tACdcgxEeuGrNSsxk3B0A")]
    [DisplayName("Other Counterparty")]
    [IsoXmlTag("OthrCtrPty")]
    public CompareOrganisationIdentification7? OtherCounterparty { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the counterparty side are matching or not.
    /// </summary>
    [IsoId("_2tACd8gxEeuGrNSsxk3B0A")]
    [DisplayName("Counterparty Side")]
    [IsoXmlTag("CtrPtySd")]
    public CompareCounterpartySide2? CounterpartySide { get; init; } 
    
    
    #nullable disable
    
}
