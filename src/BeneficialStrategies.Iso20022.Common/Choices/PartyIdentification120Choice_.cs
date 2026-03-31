// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different formats for the identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification120Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification120Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification120Choice.NameAndAddress))]
    [JsonDerivedType(
        typeof(PartyIdentification120Choice.AnyBIC),
        nameof(PartyIdentification120Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification120Choice.ProprietaryIdentification),
        nameof(PartyIdentification120Choice.ProprietaryIdentification)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification120Choice.NameAndAddress),
        nameof(PartyIdentification120Choice.NameAndAddress)
    )]
    [IsoId("_Vul5MbpYEeifFaUMRKyMMw")]
    [DisplayName("Party Identification 120 Choice")]
    public abstract record PartyIdentification120Choice_ { }
}
