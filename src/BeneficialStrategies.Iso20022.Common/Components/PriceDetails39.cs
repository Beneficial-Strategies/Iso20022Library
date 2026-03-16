// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Price Details39.
/// </summary>
[IsoId("_EJ4DMYV6Ee-oeNhl-Tk6YQ")]
[DisplayName("Price Details39")]
public partial record PriceDetails39
{
    #nullable enable

    /// <summary>
    /// Cash In Lieu Of Share Price.
    /// </summary>
    [DisplayName("Cash In Lieu Of Share Price")]
    [IsoXmlTag("CshInLieuOfShrPric")]
    public PriceFormat74Choice_? CashInLieuOfSharePrice { get; init; } 

    /// <summary>
    /// Generic Cash Price Paid Per Product.
    /// </summary>
    [DisplayName("Generic Cash Price Paid Per Product")]
    [IsoXmlTag("GncCshPricPdPerPdct")]
    public PriceFormat73Choice_? GenericCashPricePaidPerProduct { get; init; } 

    /// <summary>
    /// Generic Cash Price Received Per Product.
    /// </summary>
    [DisplayName("Generic Cash Price Received Per Product")]
    [IsoXmlTag("GncCshPricRcvdPerPdct")]
    public PriceFormat72Choice_? GenericCashPriceReceivedPerProduct { get; init; } 

    /// <summary>
    /// Redemption Price.
    /// </summary>
    [DisplayName("Redemption Price")]
    [IsoXmlTag("RedPric")]
    public PriceFormat74Choice_? RedemptionPrice { get; init; } 

    
    #nullable disable
    
}
