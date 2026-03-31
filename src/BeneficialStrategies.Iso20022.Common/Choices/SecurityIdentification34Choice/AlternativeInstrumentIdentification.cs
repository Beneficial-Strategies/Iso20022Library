// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification34Choice
{
    /// <summary>
    /// Proprietary identification of a security assigned by an institution or organisation.
    /// </summary>
    [IsoId("_Zlr-ow1HEeqV4s5SpzR1dQ")]
    [DisplayName("Alternative Instrument Identification")]
    public record AlternativeInstrumentIdentification : SecurityIdentification34Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 52 characters.
        /// </summary>
        [IsoXmlTag("AltrntvInstrmId")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52, MinimumLength = 1)]
        public required IsoMax52Text Value { get; init; }
    }
}
