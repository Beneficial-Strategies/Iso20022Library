// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IndicativeOrMarketPrice1Choice
{
    /// <summary>
    /// Estimated price, for example, for valuation purposes.
    /// </summary>
    [IsoId("_UKwuQ9p-Ed-ak6NoX_4Aeg_-1205110584")]
    [DisplayName("Indicative Price")]
    public record IndicativePrice : IndicativeOrMarketPrice1Choice_ { }
}
