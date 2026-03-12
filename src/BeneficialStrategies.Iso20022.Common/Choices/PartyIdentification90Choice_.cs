// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification90Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification90Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification90Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification90Choice.AnyBIC),nameof(PartyIdentification90Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification90Choice.ProprietaryIdentification),nameof(PartyIdentification90Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification90Choice.NameAndAddress),nameof(PartyIdentification90Choice.NameAndAddress))]
    [IsoId("_Fo7rqdedEeSA_uUacqhl1Q")]
    [DisplayName("Party Identification 90 Choice")]
    public abstract partial record PartyIdentification90Choice_
    {
    }
}
