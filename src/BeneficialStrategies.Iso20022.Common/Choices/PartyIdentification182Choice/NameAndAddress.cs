// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification182Choice
{
    /// <summary>
    /// Name and address of the party.
    /// </summary>
    [IsoId("_NkXrRZTJEemqYPWMBuVawg")]
    [DisplayName("Name And Address")]
    public record NameAndAddress : PartyIdentification182Choice_
    {
        /// <summary>
        /// Name by which the party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_3mFSU35YEeWoKrExNAiC2A")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public required IsoMax350Text Name { get; init; }

        /// <summary>
        /// Postal address of the party.
        /// </summary>
        [IsoId("_3mFSVX5YEeWoKrExNAiC2A")]
        [DisplayName("Postal Address")]
        [IsoXmlTag("PstlAdr")]
        public PostalAddress21? PostalAddress { get; init; }
    }
}
