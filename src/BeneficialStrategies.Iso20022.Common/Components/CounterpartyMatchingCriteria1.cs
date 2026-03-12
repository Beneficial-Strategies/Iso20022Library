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
[IsoId("_bHPnAKxaEem81-uIvTF5rQ")]
[DisplayName("Counterparty Matching Criteria")]
public partial record CounterpartyMatchingCriteria1
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the information on the reporting counterparties are matching or not.
    /// </summary>
    [IsoId("_KrOioa-eEemF0ZVFnxVu4g")]
    [DisplayName("Reporting Counterparty")]
    [IsoXmlTag("RptgCtrPty")]
    public CompareOrganisationIdentification1? ReportingCounterparty { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the other counterparties are matching or not.
    /// </summary>
    [IsoId("_2BxTwKxaEem81-uIvTF5rQ")]
    [DisplayName("Other Counterparty")]
    [IsoXmlTag("OthrCtrPty")]
    public CompareOrganisationIdentification1? OtherCounterparty { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the counterparty side are matching or not.
    /// </summary>
    [IsoId("_qzbzEKxaEem81-uIvTF5rQ")]
    [DisplayName("Counterparty Side")]
    [IsoXmlTag("CtrPtySd")]
    public CompareCounterpartySide1? CounterpartySide { get; init; } 
    
    
    #nullable disable
    
}
