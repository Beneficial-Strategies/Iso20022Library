// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Price82.
/// </summary>
[IsoId("_CXnbYYV6Ee-oeNhl-Tk6YQ")]
[DisplayName("Corporate Action Price82")]
public record CorporateActionPrice82
{
    /// <summary>
    /// Cash In Lieu Of Share Price.
    /// </summary>
    [DisplayName("Cash In Lieu Of Share Price")]
    [IsoXmlTag("CshInLieuOfShrPric")]
    public PriceFormat74Choice_? CashInLieuOfSharePrice { get; init; }

    /// <summary>
    /// Cash Value For Tax.
    /// </summary>
    [DisplayName("Cash Value For Tax")]
    [IsoXmlTag("CshValForTax")]
    public PriceFormat46Choice_? CashValueForTax { get; init; }

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
    /// Indicative Or Market Price.
    /// </summary>
    [DisplayName("Indicative Or Market Price")]
    [IsoXmlTag("IndctvOrMktPric")]
    public IndicativeOrMarketPrice12Choice_? IndicativeOrMarketPrice { get; init; }
}
