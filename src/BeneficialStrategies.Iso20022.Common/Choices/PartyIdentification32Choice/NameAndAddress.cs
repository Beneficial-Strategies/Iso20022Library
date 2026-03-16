// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification32Choice
{
    /// <summary>
    /// Identification of a party with its name and address in free text.
    /// </summary>
    [IsoId("_AUVtxNokEeC60axPepSq7g_-145699457")]
    [DisplayName("Name And Address")]
    public record NameAndAddress : PartyIdentification32Choice_
    {
        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_APRnkNokEeC60axPepSq7g_2005512130")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public required IsoMax350Text Name { get; init; }

        /// <summary>
        /// Postal address of a party.
        /// </summary>
        [IsoId("_APRnkdokEeC60axPepSq7g_1122278843")]
        [DisplayName("Address")]
        [IsoXmlTag("Adr")]
        public PostalAddress8? Address { get; init; }
    }
}
