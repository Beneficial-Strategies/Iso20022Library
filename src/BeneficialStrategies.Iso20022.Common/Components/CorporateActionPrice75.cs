// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies prices related to a corporate action option.
/// </summary>
[IsoId("_Lql5dRuyEeyhRdHRjakS2w")]
[DisplayName("Corporate Action Price")]
public record CorporateActionPrice75
{
    /// <summary>
    /// Indicates whether the price is an indicative price or a market price.
    /// </summary>
    [IsoId("_L_wRJRuyEeyhRdHRjakS2w")]
    [DisplayName("Indicative Or Market Price")]
    [IsoXmlTag("IndctvOrMktPric")]
    public IndicativeOrMarketPrice7Choice_? IndicativeOrMarketPrice { get; init; }

    /// <summary>
    /// Cash disbursement in lieu of equities; usually in lieu of fractional quantity.
    /// </summary>
    [IsoId("_L_wRLRuyEeyhRdHRjakS2w")]
    [DisplayName("Cash In Lieu Of Share Price")]
    [IsoXmlTag("CshInLieuOfShrPric")]
    public PriceFormat45Choice_? CashInLieuOfSharePrice { get; init; }

    /// <summary>
    /// Cash value of resulting securities proceeds for tax calculation and/or reporting.
    /// </summary>
    [IsoId("_L_wRNRuyEeyhRdHRjakS2w")]
    [DisplayName("Cash Value For Tax")]
    [IsoXmlTag("CshValForTax")]
    public PriceFormat46Choice_? CashValueForTax { get; init; }

    /// <summary>
    /// Generic cash price paid per product by the underlying security holder either as a percentage or an amount or a number of points above an index, for example, reinvestment price, strike price and exercise price.
    /// </summary>
    [IsoId("_L_wRNxuyEeyhRdHRjakS2w")]
    [DisplayName("Generic Cash Price Paid Per Product")]
    [IsoXmlTag("GncCshPricPdPerPdct")]
    public PriceFormat44Choice_? GenericCashPricePaidPerProduct { get; init; }

    /// <summary>
    /// Generic cash price received per product by the underlying security holder either as a percentage or an amount, for example, redemption price.
    /// </summary>
    [IsoId("_L_wRORuyEeyhRdHRjakS2w")]
    [DisplayName("Generic Cash Price Received Per Product")]
    [IsoXmlTag("GncCshPricRcvdPerPdct")]
    public PriceFormat65Choice_? GenericCashPriceReceivedPerProduct { get; init; }
}
