// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SystemPartyModification2Choice
{
    /// <summary>
    /// Unique identification to unambiguously identify the party within the system.
    /// </summary>
    [IsoId("_yJhSo4v-Eei289CGNqs21g")]
    [DisplayName("Party Identification")]
    public record PartyIdentification : SystemPartyModification2Choice_
    {
        /// <summary>
        /// Starting date from which the identification is valid.
        /// </summary>
        [IsoId("_-AKB0b10Eeiut6mmSKzDFQ")]
        [DisplayName("Valid From")]
        [IsoXmlTag("VldFr")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? ValidFrom { get; init; }

        /// <summary>
        /// Unique and unambiguous way to identify a system party.
        /// </summary>
        [IsoId("_-AKB0710Eeiut6mmSKzDFQ")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public PartyIdentification136? Identification { get; init; }
    }
}
