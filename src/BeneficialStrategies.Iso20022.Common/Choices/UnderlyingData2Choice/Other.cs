// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnderlyingData2Choice
{
    /// <summary>
    /// Other.
    /// </summary>
    [DisplayName("Other")]
    public record Other : UnderlyingData2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Othr")]
        public required GenericIdentification1 Value { get; init; }
    }
}
