// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification116Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification116Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification116Choice.Country))]
    [JsonDerivedType(
        typeof(PartyIdentification116Choice.AnyBIC),
        nameof(PartyIdentification116Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification116Choice.NameAndAddress),
        nameof(PartyIdentification116Choice.NameAndAddress)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification116Choice.Country),
        nameof(PartyIdentification116Choice.Country)
    )]
    [IsoId("_GXyTIZEpEeakHoV5BVecAQ")]
    [DisplayName("Party Identification 116 Choice")]
    public abstract record PartyIdentification116Choice_ { }
}
