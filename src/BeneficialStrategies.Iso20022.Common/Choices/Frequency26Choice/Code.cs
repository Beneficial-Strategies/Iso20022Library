// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Frequency26Choice
{
    /// <summary>
    /// Frequency expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_cfq1tZKQEeWHWpTQn1FFVg")]
    [DisplayName("Code")]
    public record Code : Frequency26Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the regularity of an event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required EventFrequency4Code Value { get; init; }
    }
}
