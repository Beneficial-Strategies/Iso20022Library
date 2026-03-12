// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements providing information on the original amount and currency information.
/// </summary>
[IsoId("_SVWEytp-Ed-ak6NoX_4Aeg_-345262172")]
[DisplayName("Amount And Currency Exchange Details")]
public partial record AmountAndCurrencyExchangeDetails2
{
    #nullable enable
    
    /// <summary>
    /// Identifies the type of amount.
    /// </summary>
    [IsoId("_SVWEy9p-Ed-ak6NoX_4Aeg_-345262095")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Type { get; init; } 
    
    /// <summary>
    /// Identifies the proprietary amount.
    /// </summary>
    [IsoId("_SVWEzNp-Ed-ak6NoX_4Aeg_-345262137")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required CurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Reports on currency exchange information.
    /// </summary>
    [IsoId("_SVf1wNp-Ed-ak6NoX_4Aeg_1532258001")]
    [DisplayName("Currency Exchange")]
    [IsoXmlTag("CcyXchg")]
    public CurrencyExchange3? CurrencyExchange { get; init; } 
    
    
    #nullable disable
    
}
