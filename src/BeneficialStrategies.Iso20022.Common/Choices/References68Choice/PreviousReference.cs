// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References68Choice
{
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_HVRNUZGrEem-9Y6mq5ZH3Q")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public record PreviousReference : References68Choice_
    {
        /// <summary>
        /// Reference issued by a party to identify an instruction, transaction or a message.
        /// </summary>
        [IsoId("_ZSms42pTEeipaMTLlhaKMQ")]
        [DisplayName("Reference")]
        [IsoXmlTag("Ref")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Reference { get; init; }

        /// <summary>
        /// Issuer of the reference.
        /// </summary>
        [IsoId("_ZSms5WpTEeipaMTLlhaKMQ")]
        [DisplayName("Reference Issuer")]
        [IsoXmlTag("RefIssr")]
        public PartyIdentification139? ReferenceIssuer { get; init; }

        /// <summary>
        /// Name of the message.
        /// </summary>
        [IsoId("_ZSms52pTEeipaMTLlhaKMQ")]
        [DisplayName("Message Name")]
        [IsoXmlTag("MsgNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MessageName { get; init; }
    }
}
