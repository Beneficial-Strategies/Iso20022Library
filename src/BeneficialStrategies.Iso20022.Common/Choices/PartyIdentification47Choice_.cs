// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification47Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification47Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification47Choice.NameAndAddress))]
    [JsonDerivedType(
        typeof(PartyIdentification47Choice.AnyBIC),
        nameof(PartyIdentification47Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification47Choice.ProprietaryIdentification),
        nameof(PartyIdentification47Choice.ProprietaryIdentification)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification47Choice.NameAndAddress),
        nameof(PartyIdentification47Choice.NameAndAddress)
    )]
    [IsoId("_rFE_oeaMEd-q8fx_Zl_34A")]
    [DisplayName("Party Identification 47 Choice")]
    public abstract record PartyIdentification47Choice_ { }
}
