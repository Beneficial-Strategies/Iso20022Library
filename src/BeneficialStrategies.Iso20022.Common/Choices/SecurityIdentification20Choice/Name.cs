// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification20Choice
{
    /// <summary>
    /// Proprietary identification of the index on which the financial instrument is based.
    /// </summary>
    [IsoId("_SBIPWT9DEeWqd8_TqzDNuw")]
    [DisplayName("Name")]
    public record Name : SecurityIdentification20Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 25 characters.
        /// </summary>
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max25Text)]
        [StringLength(maximumLength: 25, MinimumLength = 1)]
        public required IsoMax25Text Value { get; init; }
    }
}
