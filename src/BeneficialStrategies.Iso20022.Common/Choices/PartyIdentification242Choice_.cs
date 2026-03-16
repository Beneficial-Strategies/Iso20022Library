// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a BIC, name and address or a LEI to identify a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification242Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification242Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification242Choice.PartyIdentification))]
    [JsonDerivedType(
        typeof(PartyIdentification242Choice.NameAndAddress),
        nameof(PartyIdentification242Choice.NameAndAddress)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification242Choice.AnyBIC),
        nameof(PartyIdentification242Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification242Choice.PartyIdentification),
        nameof(PartyIdentification242Choice.PartyIdentification)
    )]
    [IsoId("_BSSs4QN1Ee2-vqzwMUAewg")]
    [DisplayName("Party Identification 242 Choice")]
    public abstract record PartyIdentification242Choice_ { }
}
