// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification198Choice.NationalRegistrationNumber))]
    [KnownType(typeof(PartyIdentification198Choice.LEI))]
    [KnownType(typeof(PartyIdentification198Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification198Choice.ClientIdentification))]
    [KnownType(typeof(PartyIdentification198Choice.ProprietaryIdentification))]
    [JsonDerivedType(
        typeof(PartyIdentification198Choice.NationalRegistrationNumber),
        nameof(PartyIdentification198Choice.NationalRegistrationNumber)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification198Choice.LEI),
        nameof(PartyIdentification198Choice.LEI)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification198Choice.AnyBIC),
        nameof(PartyIdentification198Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification198Choice.ClientIdentification),
        nameof(PartyIdentification198Choice.ClientIdentification)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification198Choice.ProprietaryIdentification),
        nameof(PartyIdentification198Choice.ProprietaryIdentification)
    )]
    [IsoId("_vHuP0DtpEemIf7eyjCwinw")]
    [DisplayName("Party Identification 198 Choice")]
    public abstract record PartyIdentification198Choice_ { }
}
