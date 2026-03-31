// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification232Choice.LegalPerson))]
    [KnownType(typeof(PartyIdentification232Choice.NaturalPerson))]
    [JsonDerivedType(
        typeof(PartyIdentification232Choice.LegalPerson),
        nameof(PartyIdentification232Choice.LegalPerson)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification232Choice.NaturalPerson),
        nameof(PartyIdentification232Choice.NaturalPerson)
    )]
    [IsoId("_pEgmUfQ0EeqAradXpAelDQ")]
    [DisplayName("Party Identification 232 Choice")]
    public abstract record PartyIdentification232Choice_ { }
}
