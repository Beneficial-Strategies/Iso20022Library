// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification244Choice.BIC))]
    [KnownType(typeof(PartyIdentification244Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification244Choice.Country))]
    [JsonDerivedType(
        typeof(PartyIdentification244Choice.BIC),
        nameof(PartyIdentification244Choice.BIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification244Choice.NameAndAddress),
        nameof(PartyIdentification244Choice.NameAndAddress)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification244Choice.Country),
        nameof(PartyIdentification244Choice.Country)
    )]
    [IsoId("_IP93bQavEe2phaVG0lYKTw")]
    [DisplayName("Party Identification 244 Choice")]
    public abstract record PartyIdentification244Choice_ { }
}
