// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification117Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification117Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification117Choice.NameAndAddress))]
    [JsonDerivedType(
        typeof(PartyIdentification117Choice.AnyBIC),
        nameof(PartyIdentification117Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification117Choice.ProprietaryIdentification),
        nameof(PartyIdentification117Choice.ProprietaryIdentification)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification117Choice.NameAndAddress),
        nameof(PartyIdentification117Choice.NameAndAddress)
    )]
    [IsoId("_bJCCkZErEeakHoV5BVecAQ")]
    [DisplayName("Party Identification 117 Choice")]
    public abstract record PartyIdentification117Choice_ { }
}
