// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification152Choice
{
    /// <summary>
    /// Name and address of the party.
    /// </summary>
    [IsoId("_3YMtZ_1REeixXcHVEYIW2g")]
    [DisplayName("Name And Address")]
    public record NameAndAddress : PartyIdentification152Choice_
    {
        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_WK6oINp-Ed-ak6NoX_4Aeg_1542098115")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINMax35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoRestrictedFINMax35Text Name { get; init; }

        /// <summary>
        /// Postal address of a party.
        /// </summary>
        [IsoId("_WK6oIdp-Ed-ak6NoX_4Aeg_1542098487")]
        [DisplayName("Address")]
        [IsoXmlTag("Adr")]
        public PostalAddress7? Address { get; init; }
    }
}
