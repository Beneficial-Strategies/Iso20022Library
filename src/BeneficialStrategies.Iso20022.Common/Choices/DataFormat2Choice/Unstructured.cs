// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DataFormat2Choice
{
    /// <summary>
    /// Specification of data for which there isn&apos;t a structured form.
    /// </summary>
    [IsoId("_Q6vvB9p-Ed-ak6NoX_4Aeg_-2132356031")]
    [DisplayName("Unstructured")]
    public record Unstructured : DataFormat2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 140 characters.
        /// </summary>
        [IsoXmlTag("Ustrd")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140, MinimumLength = 1)]
        public required IsoMax140Text Value { get; init; }
    }
}
