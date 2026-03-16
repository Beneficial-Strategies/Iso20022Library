// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party43Choice
{
    /// <summary>
    /// Unique and unambiguous identification of a financial institution.
    /// </summary>
    [IsoId("_Bp2Qk249EeiU9cctagi5ow")]
    [DisplayName("Financial Institution Identification")]
    public record FinancialInstitutionIdentification : Party43Choice_
    {
        /// <summary>
        /// Business identification code of the financial institution.
        /// </summary>
        [IsoId("_ODyZAW5OEeiU9cctagi5ow")]
        [DisplayName("BICFI")]
        [IsoXmlTag("BICFI")]
        [IsoSimpleType(IsoSimpleType.BICFIDec2014Identifier)]
        public IsoBICFIDec2014Identifier? BICFI { get; init; }

        /// <summary>
        /// Information used to identify a member within a clearing system.
        /// </summary>
        [IsoId("_ODyZA25OEeiU9cctagi5ow")]
        [DisplayName("Clearing System Member Identification")]
        [IsoXmlTag("ClrSysMmbId")]
        public ClearingSystemMemberIdentification2? ClearingSystemMemberIdentification { get; init; }

        /// <summary>
        /// Legal entity identification as an alternate identification for a party.
        /// </summary>
        [IsoId("_jnptgK9REeiTd4HhN4n9hw")]
        [DisplayName("LEI")]
        [IsoXmlTag("LEI")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public IsoLEIIdentifier? LEI { get; init; }

        /// <summary>
        /// Unique identification of an agent, as assigned by an institution, using an identification scheme.
        /// </summary>
        [IsoId("_ODyZBW5OEeiU9cctagi5ow")]
        [DisplayName("Other")]
        [IsoXmlTag("Othr")]
        public GenericFinancialIdentification1? Other { get; init; }
    }
}
