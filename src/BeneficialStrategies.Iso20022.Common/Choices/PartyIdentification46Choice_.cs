// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification46Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification46Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification46Choice.NameAndAddress))]
    [JsonDerivedType(
        typeof(PartyIdentification46Choice.AnyBIC),
        nameof(PartyIdentification46Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification46Choice.ProprietaryIdentification),
        nameof(PartyIdentification46Choice.ProprietaryIdentification)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification46Choice.NameAndAddress),
        nameof(PartyIdentification46Choice.NameAndAddress)
    )]
    [IsoId("_0amvIeaNEd-q8fx_Zl_34A")]
    [DisplayName("Party Identification 46 Choice")]
    public abstract record PartyIdentification46Choice_ { }
}
