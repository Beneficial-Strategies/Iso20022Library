// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification122Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification122Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification122Choice.Country))]
    [JsonDerivedType(
        typeof(PartyIdentification122Choice.AnyBIC),
        nameof(PartyIdentification122Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification122Choice.NameAndAddress),
        nameof(PartyIdentification122Choice.NameAndAddress)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification122Choice.Country),
        nameof(PartyIdentification122Choice.Country)
    )]
    [IsoId("_bbDfwWpWEeipaMTLlhaKMQ")]
    [DisplayName("Party Identification 122 Choice")]
    public abstract record PartyIdentification122Choice_ { }
}
