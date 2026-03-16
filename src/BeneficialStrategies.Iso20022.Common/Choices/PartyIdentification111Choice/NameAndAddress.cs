// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification111Choice
{
    /// <summary>
    /// Unique and unambiguous way to identify an organisation.
    /// </summary>
    [IsoId("_ckEN75KQEeWHWpTQn1FFVg")]
    [DisplayName("Name And Address")]
    public record NameAndAddress : PartyIdentification111Choice_
    {
        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_Wg9wptp-Ed-ak6NoX_4Aeg_-248384610")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
        [StringLength(maximumLength: 140, MinimumLength = 1)]
        public required IsoRestrictedFINXMax140Text Name { get; init; }
    }
}
