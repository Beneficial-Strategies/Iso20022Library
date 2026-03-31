// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party56Choice
{
    /// <summary>
    /// Organisation Identification.
    /// </summary>
    [DisplayName("Organisation Identification")]
    public record OrganisationIdentification : Party56Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("OrgId")]
        public required OrganisationIdentification39 Value { get; init; }
    }
}
