// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification125Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification125Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification125Choice.NameAndAddress))]
    [JsonDerivedType(
        typeof(PartyIdentification125Choice.AnyBIC),
        nameof(PartyIdentification125Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification125Choice.ProprietaryIdentification),
        nameof(PartyIdentification125Choice.ProprietaryIdentification)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification125Choice.NameAndAddress),
        nameof(PartyIdentification125Choice.NameAndAddress)
    )]
    [IsoId("_esNO0WpTEeipaMTLlhaKMQ")]
    [DisplayName("Party Identification 125 Choice")]
    public abstract record PartyIdentification125Choice_ { }
}
