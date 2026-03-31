// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Entitlement1Choice
{
    /// <summary>
    /// Specifies the calculation method of the number of votes assigned to one security. This element should be used when the entitlement calculation rule is complex.
    /// </summary>
    [IsoId("_RDromNp-Ed-ak6NoX_4Aeg_362471815")]
    [DisplayName("Entitlement Description")]
    public record EntitlementDescription : Entitlement1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 35 characters.
        /// </summary>
        [IsoXmlTag("EntitlmntDesc")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; }
    }
}
