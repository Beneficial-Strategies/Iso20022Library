// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the reporting counterparty.
/// </summary>
[IsoId("_4MnMWcg3EeuGrNSsxk3B0A")]
[DisplayName("Counterparty Identification")]
public partial record CounterpartyIdentification11
{
    #nullable enable
    
    /// <summary>
    /// Identification of the counterparty in the transaction.
    /// </summary>
    [IsoId("_4ODWwcg3EeuGrNSsxk3B0A")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required OrganisationIdentification15Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Nature of the reporting counterparty in accordance with the local regulation.
    /// </summary>
    [IsoId("_4ODWw8g3EeuGrNSsxk3B0A")]
    [DisplayName("Nature")]
    [IsoXmlTag("Ntr")]
    public CounterpartyTradeNature7Choice_? Nature { get; init; } 
    
    /// <summary>
    /// Identification of the branch of the counterparty, when the transaction concludes a transaction through a branch office.
    /// </summary>
    [IsoId("_4ODWxcg3EeuGrNSsxk3B0A")]
    [DisplayName("Branch")]
    [IsoXmlTag("Brnch")]
    public Branch5Choice_? Branch { get; init; } 
    
    /// <summary>
    /// Identifies whether the reporting counterparty is a collateral provider or a collateral taker.
    /// </summary>
    [IsoId("_4ODWx8g3EeuGrNSsxk3B0A")]
    [DisplayName("Side")]
    [IsoXmlTag("Sd")]
    public CollateralRole1Code? Side { get; init; } 
    
    
    #nullable disable
    
}
