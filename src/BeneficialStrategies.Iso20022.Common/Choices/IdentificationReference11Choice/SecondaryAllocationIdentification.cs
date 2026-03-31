// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IdentificationReference11Choice
{
    /// <summary>
    /// Reference that can be shared across a number of allocation instruction or allocation report messages, thereby making it possible to pass an identifier for an original allocation message on multiple messages (for example from one party to a second to a third, across cancel and replace messages etc).
    /// </summary>
    [IsoId("_Adu6VNokEeC60axPepSq7g_-1518522296")]
    [DisplayName("Secondary Allocation Identification")]
    public record SecondaryAllocationIdentification : IdentificationReference11Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 35 characters.
        /// </summary>
        [IsoXmlTag("ScndryAllcnId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; }
    }
}
