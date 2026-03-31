// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IndicativeOrMarketPrice11Choice
{
    /// <summary>
    /// Estimated price, for example, for valuation purposes.
    /// </summary>
    [IsoId("_ctkH_5KQEeWHWpTQn1FFVg")]
    [DisplayName("Indicative Price")]
    public record IndicativePrice : IndicativeOrMarketPrice11Choice_ { }
}
