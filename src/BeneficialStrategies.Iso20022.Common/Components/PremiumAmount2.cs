// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Commercial agreement in which the buyer agrees to pay the seller an amount of cash. Some aspects of the payment may be defined in the agreement, eg, the method of the payment.
/// </summary>
[IsoId("_TJMjkNp-Ed-ak6NoX_4Aeg_-1139165617")]
[DisplayName("Premium Amount")]
public partial record PremiumAmount2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the calculation method of the premium amount.
    /// </summary>
    [IsoId("_TJMjkdp-Ed-ak6NoX_4Aeg_822493926")]
    [DisplayName("Premium Quote")]
    [IsoXmlTag("PrmQt")]
    public PremiumQuote1Choice_? PremiumQuote { get; init; } 
    
    /// <summary>
    /// Result of the calculation of the premium amount on the basis of the premium quote and one of the amounts of the underlying foreign exchange trade.
    /// </summary>
    [IsoId("_TJMjktp-Ed-ak6NoX_4Aeg_-1139165615")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Date on which the premium must be settled.
    /// </summary>
    [IsoId("_TJMjk9p-Ed-ak6NoX_4Aeg_-1139165592")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate SettlementDate { get; init; } 
    
    /// <summary>
    /// Party that settles the premium amount on behalf of the paying party. It may contain the BIC of a central settlement system, eg. CLSBUS33.
    /// </summary>
    [IsoId("_TJMjlNp-Ed-ak6NoX_4Aeg_-1139165531")]
    [DisplayName("Settlement Party")]
    [IsoXmlTag("SttlmPty")]
    public PartyIdentification8Choice_? SettlementParty { get; init; } 
    
    
    #nullable disable
    
}
