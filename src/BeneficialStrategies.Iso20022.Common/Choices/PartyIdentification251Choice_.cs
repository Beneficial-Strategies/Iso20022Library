// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Party Identification251Choice.
    /// </summary>
    [KnownType(typeof(PartyIdentification251Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification251Choice.NameAndAddress))]
    [JsonDerivedType(
        typeof(PartyIdentification251Choice.AnyBIC),
        nameof(PartyIdentification251Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification251Choice.NameAndAddress),
        nameof(PartyIdentification251Choice.NameAndAddress)
    )]
    [IsoId("_uy0IoXfaEe2I4Iip2NEM0A")]
    [DisplayName("Party Identification251Choice")]
    public abstract record PartyIdentification251Choice_ { }
}
