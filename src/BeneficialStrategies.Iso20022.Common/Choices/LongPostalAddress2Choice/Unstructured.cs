// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LongPostalAddress2Choice
{
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services, that is presented in free format text.
    /// </summary>
    [IsoId("_RVRH2Np-Ed-ak6NoX_4Aeg_-1296060100")]
    [DisplayName("Unstructured")]
    public record Unstructured : LongPostalAddress2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 350 characters.
        /// </summary>
        [IsoXmlTag("Ustrd")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public required IsoMax350Text Value { get; init; }
    }
}
