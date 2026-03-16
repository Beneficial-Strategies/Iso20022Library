// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Party Identification256Choice.
    /// </summary>
    [KnownType(typeof(PartyIdentification256Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification256Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification256Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification256Choice.AnyBIC),nameof(PartyIdentification256Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification256Choice.NameAndAddress),nameof(PartyIdentification256Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification256Choice.ProprietaryIdentification),nameof(PartyIdentification256Choice.ProprietaryIdentification))]
    [IsoId("_5IydaZIPEe-HRNGM304Vlw")]
    [DisplayName("Party Identification256Choice")]
    public abstract partial record PartyIdentification256Choice_
    {
    }
}
