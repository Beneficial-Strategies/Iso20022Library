// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification100Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification100Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification100Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification100Choice.AnyBIC),nameof(PartyIdentification100Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification100Choice.ProprietaryIdentification),nameof(PartyIdentification100Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification100Choice.NameAndAddress),nameof(PartyIdentification100Choice.NameAndAddress))]
    [IsoId("_vWZPoYFvEeWtPe6Crjmeug")]
    [DisplayName("Party Identification 100 Choice")]
    public abstract partial record PartyIdentification100Choice_
    {
    }
}
