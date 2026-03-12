// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification68Choice.BIC))]
    [KnownType(typeof(PartyIdentification68Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification68Choice.Country))]
    [JsonDerivedType(typeof(PartyIdentification68Choice.BIC),nameof(PartyIdentification68Choice.BIC))]
    [JsonDerivedType(typeof(PartyIdentification68Choice.NameAndAddress),nameof(PartyIdentification68Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification68Choice.Country),nameof(PartyIdentification68Choice.Country))]
    [IsoId("_AUMj09okEeC60axPepSq7g_-143821104")]
    [DisplayName("Party Identification 68 Choice")]
    public abstract partial record PartyIdentification68Choice_
    {
    }
}
