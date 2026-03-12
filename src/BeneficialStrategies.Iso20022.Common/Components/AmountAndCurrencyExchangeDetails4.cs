// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the original amount and currency exchange.
/// </summary>
[IsoId("_SWFrptp-Ed-ak6NoX_4Aeg_-2139849046")]
[DisplayName("Amount And Currency Exchange Details")]
public partial record AmountAndCurrencyExchangeDetails4
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of amount.
    /// </summary>
    [IsoId("_SWFrp9p-Ed-ak6NoX_4Aeg_-2139848798")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Type { get; init; } 
    
    /// <summary>
    /// Amount of money to be exchanged against another amount of money in the counter currency.
    /// </summary>
    [IsoId("_SWFrqNp-Ed-ak6NoX_4Aeg_-2139848789")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Set of elements used to provide details on the currency exchange.
    /// </summary>
    [IsoId("_SWPcoNp-Ed-ak6NoX_4Aeg_-2139848722")]
    [DisplayName("Currency Exchange")]
    [IsoXmlTag("CcyXchg")]
    public CurrencyExchange5? CurrencyExchange { get; init; } 
    
    
    #nullable disable
    
}
