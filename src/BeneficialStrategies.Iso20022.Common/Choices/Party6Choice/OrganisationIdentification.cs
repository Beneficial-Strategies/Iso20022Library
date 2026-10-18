// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party6Choice
{
    /// <inheritdoc cref="IOrganisationIdentification"/>
    [IsoId("_Pa7iFdp-Ed-ak6NoX_4Aeg_926343088")]
    [DisplayName("Organisation Identification")]
    [IsoXmlTag("OrgId")]
    public partial record OrganisationIdentification : Party6Choice_
    {
        /// <inheritdoc cref="IOrganisationIdentification.BICOrBEI"/>
        [IsoId("_QRBcldp-Ed-ak6NoX_4Aeg_-1009093512")]
        [DisplayName("BIC Or BEI")]
        [IsoXmlTag("BICOrBEI")]
        [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
        public IsoAnyBICIdentifier? BICOrBEI { get; init; }

        /// <inheritdoc cref="IOrganisationIdentification.Other"/>
        [IsoId("_QRBcltp-Ed-ak6NoX_4Aeg_-1009092905")]
        [DisplayName("Other")]
        [IsoXmlTag("Othr")]
        public GenericOrganisationIdentification1? Other { get; init; }
    }
}
