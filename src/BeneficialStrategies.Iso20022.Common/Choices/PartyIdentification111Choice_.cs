// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Unique and unambiguous way to identify an organisation.
    /// </summary>
    [KnownType(typeof(PartyIdentification111Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification111Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification111Choice.Country))]
    [JsonDerivedType(
        typeof(PartyIdentification111Choice.AnyBIC),
        nameof(PartyIdentification111Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification111Choice.NameAndAddress),
        nameof(PartyIdentification111Choice.NameAndAddress)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification111Choice.Country),
        nameof(PartyIdentification111Choice.Country)
    )]
    [IsoId("_ckEN6ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Party Identification 111 Choice")]
    public abstract record PartyIdentification111Choice_ { }
}
