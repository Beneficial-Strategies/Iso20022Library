// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different formats for the identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification129Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification129Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification129Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification129Choice.LEI))]
    [JsonDerivedType(
        typeof(PartyIdentification129Choice.AnyBIC),
        nameof(PartyIdentification129Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification129Choice.ProprietaryIdentification),
        nameof(PartyIdentification129Choice.ProprietaryIdentification)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification129Choice.NameAndAddress),
        nameof(PartyIdentification129Choice.NameAndAddress)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification129Choice.LEI),
        nameof(PartyIdentification129Choice.LEI)
    )]
    [IsoId("_CIhQ4bXLEeiTob_PrFFUxA")]
    [DisplayName("Party Identification 129 Choice")]
    public abstract record PartyIdentification129Choice_ { }
}
