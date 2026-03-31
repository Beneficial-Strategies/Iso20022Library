// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification242Choice
{
    /// <summary>
    /// Party Identification specified as a list of values per element.
    /// </summary>
    [IsoId("_BXmqtwN1Ee2-vqzwMUAewg")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public record PartyIdentification : PartyIdentification242Choice_
    {
        /// <summary>
        /// Identification of the party expressed as the party&apos;s name.
        /// </summary>
        [IsoId("_BjNdwwN1Ee2-vqzwMUAewg")]
        [DisplayName("Party Name")]
        [IsoXmlTag("PtyNm")]
        [IsoSimpleType(IsoSimpleType.Max34Text)]
        [StringLength(maximumLength: 34, MinimumLength = 1)]
        public IsoMax34Text? PartyName { get; init; }

        /// <summary>
        /// Identification of the party expressed as a BIC and an optional alternative identifier.
        /// </summary>
        [IsoId("_BjNdxQN1Ee2-vqzwMUAewg")]
        [DisplayName("Any BIC")]
        [IsoXmlTag("AnyBIC")]
        public PartyIdentification265? AnyBIC { get; init; }

        /// <summary>
        /// Provides the party&apos;s account number.
        /// </summary>
        [IsoId("_BjNdxwN1Ee2-vqzwMUAewg")]
        [DisplayName("Account Number")]
        [IsoXmlTag("AcctNb")]
        [IsoSimpleType(IsoSimpleType.Max34Text)]
        [StringLength(maximumLength: 34, MinimumLength = 1)]
        public IsoMax34Text? AccountNumber { get; init; }

        /// <summary>
        /// Provides the party&apos;s address.
        /// </summary>
        [IsoId("_BjNdyQN1Ee2-vqzwMUAewg")]
        [DisplayName("Address")]
        [IsoXmlTag("Adr")]
        [IsoSimpleType(IsoSimpleType.Max105Text)]
        [StringLength(maximumLength: 105, MinimumLength = 1)]
        public IsoMax105Text? Address { get; init; }

        /// <summary>
        /// Choice of a clearing system identifier.
        /// </summary>
        [IsoId("_BjNdywN1Ee2-vqzwMUAewg")]
        [DisplayName("Clearing System Identification")]
        [IsoXmlTag("ClrSysId")]
        public ClearingSystemIdentification2Choice_? ClearingSystemIdentification { get; init; }

        /// <summary>
        /// Provides the Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 &quot;Financial Services - Legal Entity Identifier (LEI)&quot;.
        /// </summary>
        [IsoId("_BjNdzQN1Ee2-vqzwMUAewg")]
        [DisplayName("Legal Entity Identifier")]
        [IsoXmlTag("LglNttyIdr")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public IsoLEIIdentifier? LegalEntityIdentifier { get; init; }
    }
}
