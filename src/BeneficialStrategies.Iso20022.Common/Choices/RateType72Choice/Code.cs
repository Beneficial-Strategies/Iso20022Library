// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateType72Choice
{
    /// <summary>
    /// Standard code to specify the type of gross dividend rate.
    /// </summary>
    [IsoId("_skrJec3wEee5nJBZsW8MFQ")]
    [DisplayName("Code")]
    public record Code : RateType72Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of dividend rate.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required GrossDividendRateType4Code Value { get; init; }
    }
}
