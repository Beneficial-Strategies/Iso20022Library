// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification45Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification45Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification45Choice.NameAndAddress))]
    [JsonDerivedType(
        typeof(PartyIdentification45Choice.AnyBIC),
        nameof(PartyIdentification45Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification45Choice.ProprietaryIdentification),
        nameof(PartyIdentification45Choice.ProprietaryIdentification)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification45Choice.NameAndAddress),
        nameof(PartyIdentification45Choice.NameAndAddress)
    )]
    [IsoId("_idS_seaOEd-q8fx_Zl_34A")]
    [DisplayName("Party Identification 45 Choice")]
    public abstract record PartyIdentification45Choice_ { }
}
