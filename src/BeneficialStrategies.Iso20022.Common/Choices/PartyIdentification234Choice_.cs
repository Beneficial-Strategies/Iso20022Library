// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different formats for the identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification234Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification234Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification234Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification234Choice.IndividualOwnerIdentification))]
    [JsonDerivedType(
        typeof(PartyIdentification234Choice.AnyBIC),
        nameof(PartyIdentification234Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification234Choice.ProprietaryIdentification),
        nameof(PartyIdentification234Choice.ProprietaryIdentification)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification234Choice.NameAndAddress),
        nameof(PartyIdentification234Choice.NameAndAddress)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification234Choice.IndividualOwnerIdentification),
        nameof(PartyIdentification234Choice.IndividualOwnerIdentification)
    )]
    [IsoId("_F-iyMR9REeuFz_FaCzCLgQ")]
    [DisplayName("Party Identification 234 Choice")]
    public abstract record PartyIdentification234Choice_ { }
}
