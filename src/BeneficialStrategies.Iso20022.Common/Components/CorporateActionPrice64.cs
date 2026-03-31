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
[IsoId("_ckC_d5KQEeWHWpTQn1FFVg")]
[DisplayName("Corporate Action Price")]
public record CorporateActionPrice64
{
    /// <summary>
    /// Cash disbursement in lieu of equities; usually in lieu of fractional quantity.
    /// </summary>
    [IsoId("_ckC_e5KQEeWHWpTQn1FFVg")]
    [DisplayName("Cash In Lieu Of Share Price")]
    [IsoXmlTag("CshInLieuOfShrPric")]
    public PriceFormat52Choice_? CashInLieuOfSharePrice { get; init; }

    /// <summary>
    /// Indicates whether the price is an indicative price or a market price.
    /// </summary>
    [IsoId("_ckC_g5KQEeWHWpTQn1FFVg")]
    [DisplayName("Indicative Or Market Price")]
    [IsoXmlTag("IndctvOrMktPric")]
    public IndicativeOrMarketPrice9Choice_? IndicativeOrMarketPrice { get; init; }

    /// <summary>
    /// Cash value of resulting securities proceeds for tax calculation and/or reporting.
    /// </summary>
    [IsoId("_ckC_i5KQEeWHWpTQn1FFVg")]
    [DisplayName("Cash Value For Tax")]
    [IsoXmlTag("CshValForTax")]
    public AmountPrice4? CashValueForTax { get; init; }

    /// <summary>
    /// Generic cash price paid per product by the underlying security holder either as a percentage or an amount or a number of points above an index, for example, reinvestment price, strike price and exercise price.
    /// </summary>
    [IsoId("_ckC_jZKQEeWHWpTQn1FFVg")]
    [DisplayName("Generic Cash Price Paid Per Product")]
    [IsoXmlTag("GncCshPricPdPerPdct")]
    public PriceFormat55Choice_? GenericCashPricePaidPerProduct { get; init; }

    /// <summary>
    /// Generic cash price received per product by the underlying security holder either as a percentage or an amount, for example, redemption price.
    /// </summary>
    [IsoId("_ckC_j5KQEeWHWpTQn1FFVg")]
    [DisplayName("Generic Cash Price Received Per Product")]
    [IsoXmlTag("GncCshPricRcvdPerPdct")]
    public PriceFormat56Choice_? GenericCashPriceReceivedPerProduct { get; init; }
}
