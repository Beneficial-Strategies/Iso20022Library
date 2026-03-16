// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Unique and unambiguous way to identify an organisation.
    /// </summary>
    [KnownType(typeof(PartyIdentification58Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification58Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification58Choice.Country))]
    [JsonDerivedType(
        typeof(PartyIdentification58Choice.AnyBIC),
        nameof(PartyIdentification58Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification58Choice.NameAndAddress),
        nameof(PartyIdentification58Choice.NameAndAddress)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification58Choice.Country),
        nameof(PartyIdentification58Choice.Country)
    )]
    [IsoId("_v27eAQgeEeCVlvYcV4HKqQ")]
    [DisplayName("Party Identification 58 Choice")]
    public abstract record PartyIdentification58Choice_ { }
}
