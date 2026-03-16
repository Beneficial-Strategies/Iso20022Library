// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party6Choice
{
    /// <summary>
    /// Unique and unambiguous way to identify an organisation.
    /// </summary>
    [IsoId("_Pa7iFdp-Ed-ak6NoX_4Aeg_926343088")]
    [DisplayName("Organisation Identification")]
    [IsoXmlTag("OrgId")]
    public record OrganisationIdentification : Party6Choice_
    {
        /// <summary>
        /// Code allocated to a financial institution or non financial institution by the ISO 9362 Registration Authority as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
        /// </summary>
        [IsoId("_QRBcldp-Ed-ak6NoX_4Aeg_-1009093512")]
        [DisplayName("BIC Or BEI")]
        [IsoXmlTag("BICOrBEI")]
        [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
        public IsoAnyBICIdentifier? BICOrBEI { get; init; }

        /// <summary>
        /// Unique identification of an organisation, as assigned by an institution, using an identification scheme.
        /// </summary>
        [IsoId("_QRBcltp-Ed-ak6NoX_4Aeg_-1009092905")]
        [DisplayName("Other")]
        [IsoXmlTag("Othr")]
        public GenericOrganisationIdentification1? Other { get; init; }
    }
}
