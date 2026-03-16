// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification93Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification93Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification93Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification93Choice.Country))]
    [JsonDerivedType(
        typeof(PartyIdentification93Choice.AnyBIC),
        nameof(PartyIdentification93Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification93Choice.ProprietaryIdentification),
        nameof(PartyIdentification93Choice.ProprietaryIdentification)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification93Choice.NameAndAddress),
        nameof(PartyIdentification93Choice.NameAndAddress)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification93Choice.Country),
        nameof(PartyIdentification93Choice.Country)
    )]
    [IsoId("_bF4nATqmEeWyoP0PbocV1Q")]
    [DisplayName("Party Identification 93 Choice")]
    public abstract record PartyIdentification93Choice_ { }
}
