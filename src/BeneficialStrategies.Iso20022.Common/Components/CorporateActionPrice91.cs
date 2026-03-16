// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Price91.
/// </summary>
[IsoId("_kV6xK5t3Ee-wQIOX0djF2w")]
[DisplayName("Corporate Action Price91")]
public record CorporateActionPrice91
{
    /// <summary>
    /// Generic Cash Price Paid Per Product.
    /// </summary>
    [DisplayName("Generic Cash Price Paid Per Product")]
    [IsoXmlTag("GncCshPricPdPerPdct")]
    public PriceFormat83Choice_? GenericCashPricePaidPerProduct { get; init; }

    /// <summary>
    /// Generic Cash Price Received Per Product.
    /// </summary>
    [DisplayName("Generic Cash Price Received Per Product")]
    [IsoXmlTag("GncCshPricRcvdPerPdct")]
    public PriceFormat84Choice_? GenericCashPriceReceivedPerProduct { get; init; }

    /// <summary>
    /// Indicative Or Market Price.
    /// </summary>
    [DisplayName("Indicative Or Market Price")]
    [IsoXmlTag("IndctvOrMktPric")]
    public IndicativeOrMarketPrice15Choice_? IndicativeOrMarketPrice { get; init; }

    /// <summary>
    /// Issue Price.
    /// </summary>
    [DisplayName("Issue Price")]
    [IsoXmlTag("IssePric")]
    public PriceFormat83Choice_? IssuePrice { get; init; }
}
