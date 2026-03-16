// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Party Identification259Choice.
    /// </summary>
    [KnownType(typeof(PartyIdentification259Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification259Choice.IndividualOwnerIdentification))]
    [KnownType(typeof(PartyIdentification259Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification259Choice.ProprietaryIdentification))]
    [JsonDerivedType(
        typeof(PartyIdentification259Choice.AnyBIC),
        nameof(PartyIdentification259Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification259Choice.IndividualOwnerIdentification),
        nameof(PartyIdentification259Choice.IndividualOwnerIdentification)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification259Choice.NameAndAddress),
        nameof(PartyIdentification259Choice.NameAndAddress)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification259Choice.ProprietaryIdentification),
        nameof(PartyIdentification259Choice.ProprietaryIdentification)
    )]
    [IsoId("_grU-IaDcEe-CRv8HNM1RKw")]
    [DisplayName("Party Identification259Choice")]
    public abstract record PartyIdentification259Choice_ { }
}
