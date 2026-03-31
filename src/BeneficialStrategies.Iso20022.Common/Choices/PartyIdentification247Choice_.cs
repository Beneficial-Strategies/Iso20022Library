// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification247Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification247Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification247Choice.NameAndAddress))]
    [JsonDerivedType(
        typeof(PartyIdentification247Choice.AnyBIC),
        nameof(PartyIdentification247Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification247Choice.ProprietaryIdentification),
        nameof(PartyIdentification247Choice.ProprietaryIdentification)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification247Choice.NameAndAddress),
        nameof(PartyIdentification247Choice.NameAndAddress)
    )]
    [IsoId("_HPJwwTWlEe2OzdGcZrUAEQ")]
    [DisplayName("Party Identification 247 Choice")]
    public abstract record PartyIdentification247Choice_ { }
}
