// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification240Choice.BIC))]
    [KnownType(typeof(PartyIdentification240Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification240Choice.NameAndAddress))]
    [JsonDerivedType(
        typeof(PartyIdentification240Choice.BIC),
        nameof(PartyIdentification240Choice.BIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification240Choice.ProprietaryIdentification),
        nameof(PartyIdentification240Choice.ProprietaryIdentification)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification240Choice.NameAndAddress),
        nameof(PartyIdentification240Choice.NameAndAddress)
    )]
    [IsoId("_mF6ywStKEeyOa655cLd-DQ")]
    [DisplayName("Party Identification 240 Choice")]
    public abstract record PartyIdentification240Choice_ { }
}
