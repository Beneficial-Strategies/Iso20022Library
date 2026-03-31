// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party53Choice
{
    /// <summary>
    /// Organisation Identification.
    /// </summary>
    [DisplayName("Organisation Identification")]
    public record OrganisationIdentification : Party53Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("OrgId")]
        public required OrganisationIdentification40 Value { get; init; }
    }
}
