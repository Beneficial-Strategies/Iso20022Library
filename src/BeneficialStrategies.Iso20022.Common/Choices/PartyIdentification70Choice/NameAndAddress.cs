// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification70Choice
{
    /// <summary>
    /// Name and address of a party.
    /// </summary>
    [IsoId("_g-pD89ooEeCWg-hsBVGrDA_354007909")]
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public record NameAndAddress : PartyIdentification70Choice_
    {
        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_PZcUWtp-Ed-ak6NoX_4Aeg_-1177692231")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public required IsoMax350Text Name { get; init; }

        /// <summary>
        /// Postal address of the party.
        /// </summary>
        [IsoId("_PZleQNp-Ed-ak6NoX_4Aeg_670261447")]
        [DisplayName("Address")]
        [IsoXmlTag("Adr")]
        public PostalAddress1? Address { get; init; }
    }
}
