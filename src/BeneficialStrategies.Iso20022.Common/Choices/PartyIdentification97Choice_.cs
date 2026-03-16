// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification97Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification97Choice.LegalEntityIdentifier))]
    [KnownType(typeof(PartyIdentification97Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification97Choice.ProprietaryIdentification))]
    [JsonDerivedType(
        typeof(PartyIdentification97Choice.AnyBIC),
        nameof(PartyIdentification97Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification97Choice.LegalEntityIdentifier),
        nameof(PartyIdentification97Choice.LegalEntityIdentifier)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification97Choice.NameAndAddress),
        nameof(PartyIdentification97Choice.NameAndAddress)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification97Choice.ProprietaryIdentification),
        nameof(PartyIdentification97Choice.ProprietaryIdentification)
    )]
    [IsoId("_P50eUSVJEeWI0orciOKunQ")]
    [DisplayName("Party Identification 97 Choice")]
    public abstract record PartyIdentification97Choice_ { }
}
