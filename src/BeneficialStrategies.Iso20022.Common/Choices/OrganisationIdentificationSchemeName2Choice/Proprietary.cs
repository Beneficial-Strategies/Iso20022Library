// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OrganisationIdentificationSchemeName2Choice
{
    /// <summary>
    /// Name of the identification scheme, in a free text form.
    /// </summary>
    [IsoId("_WgN0SRBBEeGyZLI6olyk-Q")]
    [DisplayName("Proprietary")]
    public record Proprietary : OrganisationIdentificationSchemeName2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 35 characters limited to character set X, that is, a-z A-Z / - ? : ( ) . , ‘ + .
        /// </summary>
        [IsoXmlTag("Prtry")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoRestrictedFINXMax35Text Value { get; init; }
    }
}
