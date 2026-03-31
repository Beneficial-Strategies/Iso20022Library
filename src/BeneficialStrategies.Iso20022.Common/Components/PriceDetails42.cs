// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Price Details42.
/// </summary>
[IsoId("_l6aCsZt3Ee-wQIOX0djF2w")]
[DisplayName("Price Details42")]
public record PriceDetails42
{
    /// <summary>
    /// Cash In Lieu Of Share Price.
    /// </summary>
    [DisplayName("Cash In Lieu Of Share Price")]
    [IsoXmlTag("CshInLieuOfShrPric")]
    public PriceFormat88Choice_? CashInLieuOfSharePrice { get; init; }

    /// <summary>
    /// Generic Cash Price Paid Per Product.
    /// </summary>
    [DisplayName("Generic Cash Price Paid Per Product")]
    [IsoXmlTag("GncCshPricPdPerPdct")]
    public PriceFormat89Choice_? GenericCashPricePaidPerProduct { get; init; }

    /// <summary>
    /// Generic Cash Price Received Per Product.
    /// </summary>
    [DisplayName("Generic Cash Price Received Per Product")]
    [IsoXmlTag("GncCshPricRcvdPerPdct")]
    public PriceFormat90Choice_? GenericCashPriceReceivedPerProduct { get; init; }
}
