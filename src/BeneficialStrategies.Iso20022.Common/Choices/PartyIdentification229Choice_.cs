// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different formats for the identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification229Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification229Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification229Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification229Choice.IndividualOwnerIdentification))]
    [JsonDerivedType(
        typeof(PartyIdentification229Choice.AnyBIC),
        nameof(PartyIdentification229Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification229Choice.ProprietaryIdentification),
        nameof(PartyIdentification229Choice.ProprietaryIdentification)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification229Choice.NameAndAddress),
        nameof(PartyIdentification229Choice.NameAndAddress)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification229Choice.IndividualOwnerIdentification),
        nameof(PartyIdentification229Choice.IndividualOwnerIdentification)
    )]
    [IsoId("_pblve-4CEeqc-LCjwLsUVg")]
    [DisplayName("Party Identification 229 Choice")]
    public abstract record PartyIdentification229Choice_ { }
}
