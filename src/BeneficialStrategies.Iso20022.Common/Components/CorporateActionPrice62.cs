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
[IsoId("_chezrZKQEeWHWpTQn1FFVg")]
[DisplayName("Corporate Action Price")]
public record CorporateActionPrice62
{
    /// <summary>
    /// Indicates whether the price is an indicative price or a market price.
    /// </summary>
    [IsoId("_chezsZKQEeWHWpTQn1FFVg")]
    [DisplayName("Indicative Or Market Price")]
    [IsoXmlTag("IndctvOrMktPric")]
    public IndicativeOrMarketPrice9Choice_? IndicativeOrMarketPrice { get; init; }

    /// <summary>
    /// Initial issue price of a financial instrument.
    /// </summary>
    [IsoId("_chezuZKQEeWHWpTQn1FFVg")]
    [DisplayName("Issue Price")]
    [IsoXmlTag("IssePric")]
    public PriceFormat52Choice_? IssuePrice { get; init; }

    /// <summary>
    /// Generic cash price received per product by the underlying security holder either as a percentage or an amount, for example, redemption price.
    /// </summary>
    [IsoId("_chezwZKQEeWHWpTQn1FFVg")]
    [DisplayName("Generic Cash Price Received Per Product")]
    [IsoXmlTag("GncCshPricRcvdPerPdct")]
    public PriceFormat53Choice_? GenericCashPriceReceivedPerProduct { get; init; }

    /// <summary>
    /// Generic cash price paid per product by the underlying security holder either as a percentage or an amount, for example, reinvestment price.
    /// </summary>
    [IsoId("_chezyZKQEeWHWpTQn1FFVg")]
    [DisplayName("Generic Cash Price Paid Per Product")]
    [IsoXmlTag("GncCshPricPdPerPdct")]
    public PriceFormat52Choice_? GenericCashPricePaidPerProduct { get; init; }
}
