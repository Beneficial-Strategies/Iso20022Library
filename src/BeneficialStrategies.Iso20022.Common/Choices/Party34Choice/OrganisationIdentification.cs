// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party34Choice
{
    /// <summary>
    /// Unique and unambiguous way to identify an organisation.
    /// </summary>
    [IsoId("_j9Shg69UEeeJJK1oRb-jTw")]
    [DisplayName("Organisation Identification")]
    [IsoXmlTag("OrgId")]
    public record OrganisationIdentification : Party34Choice_
    {
        /// <summary>
        /// Code allocated to a financial institution or non financial institution by the ISO 9362 Registration Authority as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
        /// </summary>
        [IsoId("_QPiO1dp-Ed-ak6NoX_4Aeg_-589713829")]
        [DisplayName("Any BIC")]
        [IsoXmlTag("AnyBIC")]
        [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
        public IsoAnyBICIdentifier? AnyBIC { get; init; }

        /// <summary>
        /// Unique identification of an organisation, as assigned by an institution, using an identification scheme.
        /// </summary>
        [IsoId("_QPiO1tp-Ed-ak6NoX_4Aeg_-1021329556")]
        [DisplayName("Other")]
        [IsoXmlTag("Othr")]
        public GenericOrganisationIdentification1? Other { get; init; }
    }
}
