// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different formats for the identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification123Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification123Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification123Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification123Choice.AnyBIC),nameof(PartyIdentification123Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification123Choice.ProprietaryIdentification),nameof(PartyIdentification123Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification123Choice.NameAndAddress),nameof(PartyIdentification123Choice.NameAndAddress))]
    [IsoId("_N_onAWpXEeipaMTLlhaKMQ")]
    [DisplayName("Party Identification 123 Choice")]
    public abstract partial record PartyIdentification123Choice_
    {
    }
}
