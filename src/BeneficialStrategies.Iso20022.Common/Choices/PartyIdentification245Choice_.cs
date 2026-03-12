// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification245Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification245Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification245Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification245Choice.AnyBIC),nameof(PartyIdentification245Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification245Choice.ProprietaryIdentification),nameof(PartyIdentification245Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification245Choice.NameAndAddress),nameof(PartyIdentification245Choice.NameAndAddress))]
    [IsoId("_ZfQDSQauEe2phaVG0lYKTw")]
    [DisplayName("Party Identification 245 Choice")]
    public abstract partial record PartyIdentification245Choice_
    {
    }
}
