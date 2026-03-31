// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateType74Choice
{
    /// <summary>
    /// Standard code to specify the type of gross dividend rate.
    /// </summary>
    [IsoId("_sk1g2c3wEee5nJBZsW8MFQ")]
    [DisplayName("Code")]
    public record Code : RateType74Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of gross dividend rate.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required GrossDividendRateType5Code Value { get; init; }
    }
}
