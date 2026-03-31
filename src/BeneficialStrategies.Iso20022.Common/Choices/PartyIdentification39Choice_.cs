// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Unique and unambiguous way to identify an organisation.
    /// </summary>
    [KnownType(typeof(PartyIdentification39Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification39Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification39Choice.Country))]
    [JsonDerivedType(
        typeof(PartyIdentification39Choice.AnyBIC),
        nameof(PartyIdentification39Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification39Choice.NameAndAddress),
        nameof(PartyIdentification39Choice.NameAndAddress)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification39Choice.Country),
        nameof(PartyIdentification39Choice.Country)
    )]
    [IsoId("_1Y13MfL9Ed-3lpUMQaXLjQ")]
    [DisplayName("Party Identification 39 Choice")]
    public abstract record PartyIdentification39Choice_ { }
}
