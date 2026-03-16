// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification75Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification75Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification75Choice.Country))]
    [JsonDerivedType(
        typeof(PartyIdentification75Choice.AnyBIC),
        nameof(PartyIdentification75Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification75Choice.NameAndAddress),
        nameof(PartyIdentification75Choice.NameAndAddress)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification75Choice.Country),
        nameof(PartyIdentification75Choice.Country)
    )]
    [IsoId("_HUH4SUiQEeOdL6nMHefDgg")]
    [DisplayName("Party Identification 75 Choice")]
    public abstract record PartyIdentification75Choice_ { }
}
