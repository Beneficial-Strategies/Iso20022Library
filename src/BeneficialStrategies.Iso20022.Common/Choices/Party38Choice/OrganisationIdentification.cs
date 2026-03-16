// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party38Choice
{
    /// <summary>
    /// Unique and unambiguous way to identify an organisation.
    /// </summary>
    [IsoId("_6VWvQ248EeiU9cctagi5ow")]
    [DisplayName("Organisation Identification")]
    [IsoXmlTag("OrgId")]
    public record OrganisationIdentification : Party38Choice_
    {
        /// <summary>
        /// Business identification code of the organisation.
        /// </summary>
        [IsoId("_6emK0248EeiU9cctagi5ow")]
        [DisplayName("Any BIC")]
        [IsoXmlTag("AnyBIC")]
        [IsoSimpleType(IsoSimpleType.AnyBICDec2014Identifier)]
        public IsoAnyBICDec2014Identifier? AnyBIC { get; init; }

        /// <summary>
        /// Legal entity identification as an alternate identification for a party.
        /// </summary>
        [IsoId("_XzdQ4XRwEeiH1ZOt2UD8vQ")]
        [DisplayName("LEI")]
        [IsoXmlTag("LEI")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public IsoLEIIdentifier? LEI { get; init; }

        /// <summary>
        /// Unique identification of an organisation, as assigned by an institution, using an identification scheme.
        /// </summary>
        [IsoId("_6emK1W48EeiU9cctagi5ow")]
        [DisplayName("Other")]
        [IsoXmlTag("Othr")]
        public GenericOrganisationIdentification1? Other { get; init; }
    }
}
