// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party34Choice
{
    /// <inheritdoc cref="IOrganisationIdentification"/>
    [IsoId("_j9Shg69UEeeJJK1oRb-jTw")]
    [DisplayName("Organisation Identification")]
    [IsoXmlTag("OrgId")]
    public partial record OrganisationIdentification : Party34Choice_
    {
        /// <inheritdoc cref="IOrganisationIdentification.AnyBIC"/>
        [IsoId("_QPiO1dp-Ed-ak6NoX_4Aeg_-589713829")]
        [DisplayName("Any BIC")]
        [IsoXmlTag("AnyBIC")]
        [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
        public IsoAnyBICIdentifier? AnyBIC { get; init; }

        /// <inheritdoc cref="IOrganisationIdentification.Other"/>
        [IsoId("_QPiO1tp-Ed-ak6NoX_4Aeg_-1021329556")]
        [DisplayName("Other")]
        [IsoXmlTag("Othr")]
        public GenericOrganisationIdentification1? Other { get; init; }
    }
}
