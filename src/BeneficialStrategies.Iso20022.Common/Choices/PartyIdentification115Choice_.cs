// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification115Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification115Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification115Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification115Choice.Country))]
    [JsonDerivedType(typeof(PartyIdentification115Choice.AnyBIC),nameof(PartyIdentification115Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification115Choice.ProprietaryIdentification),nameof(PartyIdentification115Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification115Choice.NameAndAddress),nameof(PartyIdentification115Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification115Choice.Country),nameof(PartyIdentification115Choice.Country))]
    [IsoId("_SXTaEZjcEeWn2ur3BXxtdg")]
    [DisplayName("Party Identification 115 Choice")]
    public abstract partial record PartyIdentification115Choice_
    {
    }
}
