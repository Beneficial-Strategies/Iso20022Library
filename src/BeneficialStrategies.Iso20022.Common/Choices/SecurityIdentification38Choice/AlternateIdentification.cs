// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification38Choice
{
    /// <summary>
    /// Alternate Identification.
    /// </summary>
    [DisplayName("Alternate Identification")]
    public record AlternateIdentification : SecurityIdentification38Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("AltrnId")]
        public required AlternateIdentification1 Value { get; init; }
    }
}
