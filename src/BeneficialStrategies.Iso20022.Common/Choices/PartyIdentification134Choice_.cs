// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for an identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification134Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification134Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification134Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification134Choice.Country))]
    [JsonDerivedType(
        typeof(PartyIdentification134Choice.AnyBIC),
        nameof(PartyIdentification134Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification134Choice.ProprietaryIdentification),
        nameof(PartyIdentification134Choice.ProprietaryIdentification)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification134Choice.NameAndAddress),
        nameof(PartyIdentification134Choice.NameAndAddress)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification134Choice.Country),
        nameof(PartyIdentification134Choice.Country)
    )]
    [IsoId("_JGMJ1dXZEeiN28wlpBQScw")]
    [DisplayName("Party Identification 134 Choice")]
    public abstract record PartyIdentification134Choice_ { }
}
