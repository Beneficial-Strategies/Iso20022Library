// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party52Choice
{
    /// <inheritdoc cref="IOrganisationIdentification"/>
    [DisplayName("Organisation Identification")]
    public partial record OrganisationIdentification : Party52Choice_
    {
        /// <inheritdoc cref="IOrganisationIdentification.Value"/>
        [IsoXmlTag("OrgId")]
        public required OrganisationIdentification39 Value { get; init; }
    }
}
