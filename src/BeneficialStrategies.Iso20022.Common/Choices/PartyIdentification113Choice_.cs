// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification113Choice.BICFI))]
    [KnownType(typeof(PartyIdentification113Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification113Choice.ProprietaryIdentification))]
    [JsonDerivedType(
        typeof(PartyIdentification113Choice.BICFI),
        nameof(PartyIdentification113Choice.BICFI)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification113Choice.NameAndAddress),
        nameof(PartyIdentification113Choice.NameAndAddress)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification113Choice.ProprietaryIdentification),
        nameof(PartyIdentification113Choice.ProprietaryIdentification)
    )]
    [IsoId("_ckJthZKQEeWHWpTQn1FFVg")]
    [DisplayName("Party Identification 113 Choice")]
    public abstract record PartyIdentification113Choice_ { }
}
