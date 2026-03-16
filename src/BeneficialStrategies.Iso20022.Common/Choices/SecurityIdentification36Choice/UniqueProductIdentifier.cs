// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification36Choice
{
    /// <summary>
    /// Identification through a unique product identifier.
    /// </summary>
    [IsoId("_POTEpYrpEeq91phomTRDDA")]
    [DisplayName("Unique Product Identifier")]
    public record UniqueProductIdentifier : SecurityIdentification36Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 52 characters.
        /// </summary>
        [IsoXmlTag("UnqPdctIdr")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52, MinimumLength = 1)]
        public required IsoMax52Text Value { get; init; }
    }
}
