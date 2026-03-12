// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification37Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification37Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification37Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification37Choice.Country))]
    [JsonDerivedType(typeof(PartyIdentification37Choice.AnyBIC),nameof(PartyIdentification37Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification37Choice.ProprietaryIdentification),nameof(PartyIdentification37Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification37Choice.NameAndAddress),nameof(PartyIdentification37Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification37Choice.Country),nameof(PartyIdentification37Choice.Country))]
    [IsoId("_7H6pweaPEd-q8fx_Zl_34A")]
    [DisplayName("Party Identification 37 Choice")]
    public abstract partial record PartyIdentification37Choice_
    {
    }
}
