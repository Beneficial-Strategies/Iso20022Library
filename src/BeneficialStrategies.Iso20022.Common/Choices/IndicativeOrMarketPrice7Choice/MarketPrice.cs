// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IndicativeOrMarketPrice7Choice
{
    /// <summary>
    /// Last reported/known price of a financial instrument in a market.
    /// </summary>
    [IsoId("_dWrpC0EJEeWVgfuHGaKtRQ")]
    [DisplayName("Market Price")]
    public record MarketPrice : IndicativeOrMarketPrice7Choice_ { }
}
