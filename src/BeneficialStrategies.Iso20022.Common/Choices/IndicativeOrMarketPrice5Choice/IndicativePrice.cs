// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IndicativeOrMarketPrice5Choice
{
    /// <summary>
    /// Estimated price, for example, for valuation purposes.
    /// </summary>
    [IsoId("_oc_1c-EJEd-udr336SN7mQ")]
    [DisplayName("Indicative Price")]
    public record IndicativePrice : IndicativeOrMarketPrice5Choice_ { }
}
