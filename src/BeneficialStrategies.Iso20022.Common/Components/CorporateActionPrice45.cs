// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies prices.
/// </summary>
[IsoId("_nDqd5SXxEeO4bIO_HtGo9Q")]
[DisplayName("Corporate Action Price")]
public record CorporateActionPrice45
{
    /// <summary>
    /// Cash disbursement in lieu of equities; usually in lieu of fractional quantity.
    /// </summary>
    [IsoId("_nbBNkyXxEeO4bIO_HtGo9Q")]
    [DisplayName("Cash In Lieu Of Share Price")]
    [IsoXmlTag("CshInLieuOfShrPric")]
    public PriceFormat5Choice_? CashInLieuOfSharePrice { get; init; }

    /// <summary>
    /// Indicates whether the price is an indicative price or a market price.
    /// </summary>
    [IsoId("_nbBNmyXxEeO4bIO_HtGo9Q")]
    [DisplayName("Indicative Or Market Price")]
    [IsoXmlTag("IndctvOrMktPric")]
    public IndicativeOrMarketPrice2Choice_? IndicativeOrMarketPrice { get; init; }

    /// <summary>
    /// Cash value of resulting securities proceeds for tax calculation and/or reporting.
    /// </summary>
    [IsoId("_nbBNoyXxEeO4bIO_HtGo9Q")]
    [DisplayName("Cash Value For Tax")]
    [IsoXmlTag("CshValForTax")]
    public AmountPrice2? CashValueForTax { get; init; }

    /// <summary>
    /// Generic cash price paid per product by the underlying security holder either as a percentage or an amount or a number of points above an index, for example, reinvestment price, strike price and exercise price.
    /// </summary>
    [IsoId("_nbBNpSXxEeO4bIO_HtGo9Q")]
    [DisplayName("Generic Cash Price Paid Per Product")]
    [IsoXmlTag("GncCshPricPdPerPdct")]
    public PriceFormat6Choice_? GenericCashPricePaidPerProduct { get; init; }

    /// <summary>
    /// Generic cash price received per product by the underlying security holder either as a percentage or an amount, for example, redemption price.
    /// </summary>
    [IsoId("_nbBNpyXxEeO4bIO_HtGo9Q")]
    [DisplayName("Generic Cash Price Received Per Product")]
    [IsoXmlTag("GncCshPricRcvdPerPdct")]
    public PriceFormat34Choice_? GenericCashPriceReceivedPerProduct { get; init; }
}
