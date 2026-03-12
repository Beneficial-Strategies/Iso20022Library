// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification70Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification70Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification70Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification70Choice.AnyBIC),nameof(PartyIdentification70Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification70Choice.ProprietaryIdentification),nameof(PartyIdentification70Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification70Choice.NameAndAddress),nameof(PartyIdentification70Choice.NameAndAddress))]
    [IsoId("_g-pD8NooEeCWg-hsBVGrDA_1464919328")]
    [DisplayName("Party Identification 70 Choice")]
    public abstract partial record PartyIdentification70Choice_
    {
    }
}
