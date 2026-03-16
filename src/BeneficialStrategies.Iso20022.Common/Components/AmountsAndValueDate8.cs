// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amounts And Value Date8.
/// </summary>
[IsoId("_j4qSSUj3Ee-KhcStGV4xTg")]
[DisplayName("Amounts And Value Date8")]
public partial record AmountsAndValueDate8
{
    #nullable enable

    /// <summary>
    /// Settlement Date.
    /// </summary>
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required IsoISODate SettlementDate { get; init; } 

    /// <summary>
    /// Trading Side Buy Amount.
    /// </summary>
    [DisplayName("Trading Side Buy Amount")]
    [IsoXmlTag("TradgSdBuyAmt")]
    public required CurrencyOrDigitalTokenAmount2Choice_ TradingSideBuyAmount { get; init; } 

    /// <summary>
    /// Trading Side Sell Amount.
    /// </summary>
    [DisplayName("Trading Side Sell Amount")]
    [IsoXmlTag("TradgSdSellAmt")]
    public required CurrencyOrDigitalTokenAmount2Choice_ TradingSideSellAmount { get; init; } 

    
    #nullable disable
    
}
