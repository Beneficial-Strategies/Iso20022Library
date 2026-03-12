// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification178Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification178Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification178Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification178Choice.AnyBIC),nameof(PartyIdentification178Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification178Choice.ProprietaryIdentification),nameof(PartyIdentification178Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification178Choice.NameAndAddress),nameof(PartyIdentification178Choice.NameAndAddress))]
    [IsoId("_UExgodgxEeipBO1pkKK6zg")]
    [DisplayName("Party Identification 178 Choice")]
    public abstract partial record PartyIdentification178Choice_
    {
    }
}
