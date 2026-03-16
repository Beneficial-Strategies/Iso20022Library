// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References62Choice
{
    /// <summary>
    /// Reference to a linked proprietary message or reference of a system that was previously received.
    /// </summary>
    [IsoId("_VILsE0g9Eea8pJjypp-yMQ")]
    [DisplayName("Other Reference")]
    public record OtherReference : References62Choice_
    {
        /// <summary>
        /// Reference issued by a party to identify an instruction, transaction or a message.
        /// </summary>
        [IsoId("_u5IuAzbsEead9bDRE_1DAQ")]
        [DisplayName("Reference")]
        [IsoXmlTag("Ref")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Reference { get; init; }

        /// <summary>
        /// Issuer of the reference.
        /// </summary>
        [IsoId("_u5IuBTbsEead9bDRE_1DAQ")]
        [DisplayName("Reference Issuer")]
        [IsoXmlTag("RefIssr")]
        public PartyIdentification113? ReferenceIssuer { get; init; }

        /// <summary>
        /// Name of the message.
        /// </summary>
        [IsoId("_u5IuBzbsEead9bDRE_1DAQ")]
        [DisplayName("Message Name")]
        [IsoXmlTag("MsgNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MessageName { get; init; }
    }
}
