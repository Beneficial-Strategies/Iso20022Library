// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Party Identification258Choice.
    /// </summary>
    [KnownType(typeof(PartyIdentification258Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification258Choice.Country))]
    [KnownType(typeof(PartyIdentification258Choice.DigitalLedgerIdentification))]
    [KnownType(typeof(PartyIdentification258Choice.NameAndAddress))]
    [JsonDerivedType(
        typeof(PartyIdentification258Choice.AnyBIC),
        nameof(PartyIdentification258Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification258Choice.Country),
        nameof(PartyIdentification258Choice.Country)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification258Choice.DigitalLedgerIdentification),
        nameof(PartyIdentification258Choice.DigitalLedgerIdentification)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification258Choice.NameAndAddress),
        nameof(PartyIdentification258Choice.NameAndAddress)
    )]
    [IsoId("_kv8aU5t3Ee-wQIOX0djF2w")]
    [DisplayName("Party Identification258Choice")]
    public abstract record PartyIdentification258Choice_ { }
}
