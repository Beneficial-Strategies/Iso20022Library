// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OtherIdentification1Choice
{
    /// <summary>
    /// Other identification expressed as a code.
    /// </summary>
    [IsoId("_5X-cYBc0EeK5g-3oYI0_9Q")]
    [DisplayName("Code")]
    public record Code : OtherIdentification1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies an alternative identification of an individual person, for example, national registration identification number, passport number.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PersonIdentificationType5Code Value { get; init; }
    }
}
