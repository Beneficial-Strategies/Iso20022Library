// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IndicativeOrMarketPrice9Choice
{
    /// <summary>
    /// Last reported/known price of a financial instrument in a market.
    /// </summary>
    [IsoId("_chez3ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Market Price")]
    public partial record MarketPrice : IndicativeOrMarketPrice9Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("MktPric")]
        public required PriceFormat52Choice_ Value { get; init; }
    }
}
