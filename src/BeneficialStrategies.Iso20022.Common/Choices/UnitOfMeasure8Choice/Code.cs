// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnitOfMeasure8Choice
{
    /// <summary>
    /// Unit of measure, as defined in an external code set.
    /// </summary>
    [IsoId("_2_CFgDNlEe2UWZuK9pqFtg")]
    [DisplayName("Code")]
    public record Code : UnitOfMeasure8Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the external unit of measure by means of a code in the format of character string with a maximum length of 4 characters.
        /// The list of valid codes is an external code list published separately.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalUnitOfMeasure1Code Value { get; init; }
    }
}
