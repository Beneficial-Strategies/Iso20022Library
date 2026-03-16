// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Frequency38Choice
{
    /// <summary>
    /// Frequency expressed in coded form.
    /// </summary>
    [IsoId("_zRGl6zrwEeuD7rm9md9zvg")]
    [DisplayName("Code")]
    public record Code : Frequency38Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the regularity of an event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required EventFrequency12Code Value { get; init; }
    }
}
