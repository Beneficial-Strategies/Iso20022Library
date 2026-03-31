// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification19Choice
{
    /// <summary>
    /// Identification of the party expressed as name and address and an alternative identifier.
    /// </summary>
    [IsoId("_Sp1N6wEcEeCQm6a_G2yO_w_-1343447231")]
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public record NameAndAddress : PartyIdentification19Choice_
    {
        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_PZvPQdp-Ed-ak6NoX_4Aeg_-611452364")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public required IsoMax350Text Name { get; init; }

        /// <summary>
        /// Postal address of a party.
        /// </summary>
        [IsoId("_PZvPQtp-Ed-ak6NoX_4Aeg_-611452322")]
        [DisplayName("Address")]
        [IsoXmlTag("Adr")]
        public PostalAddress1? Address { get; init; }

        /// <summary>
        /// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
        /// </summary>
        [IsoId("_PZvPQ9p-Ed-ak6NoX_4Aeg_-106286787")]
        [DisplayName("Alternative Identifier")]
        [IsoXmlTag("AltrntvIdr")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [MinLength(0)]
        [MaxLength(10)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public SimpleValueList<System.String> AlternativeIdentifier { get; init; } = [];
    }
}
