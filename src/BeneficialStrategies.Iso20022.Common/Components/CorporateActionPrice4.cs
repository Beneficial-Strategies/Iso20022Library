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
[IsoId("_UKwuSNp-Ed-ak6NoX_4Aeg_-198423815")]
[DisplayName("Corporate Action Price")]
public record CorporateActionPrice4
{
    /// <summary>
    /// Estimated price, eg, for valuation purposes.
    /// </summary>
    [IsoId("_UKwuSdp-Ed-ak6NoX_4Aeg_-187341801")]
    [DisplayName("Indicative Price")]
    [IsoXmlTag("IndctvPric")]
    public PriceFormat2Choice_? IndicativePrice { get; init; }

    /// <summary>
    /// Last reported/known price of a financial instrument in a market.
    /// </summary>
    [IsoId("_UK6fQNp-Ed-ak6NoX_4Aeg_2014235941")]
    [DisplayName("Market Price")]
    [IsoXmlTag("MktPric")]
    public PriceFormat2Choice_? MarketPrice { get; init; }
}
