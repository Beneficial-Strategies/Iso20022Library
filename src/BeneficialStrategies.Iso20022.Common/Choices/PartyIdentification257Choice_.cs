// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Party Identification257Choice.
    /// </summary>
    [KnownType(typeof(PartyIdentification257Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification257Choice.Country))]
    [KnownType(typeof(PartyIdentification257Choice.DigitalLedgerIdentification))]
    [KnownType(typeof(PartyIdentification257Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification257Choice.AnyBIC),nameof(PartyIdentification257Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification257Choice.Country),nameof(PartyIdentification257Choice.Country))]
    [JsonDerivedType(typeof(PartyIdentification257Choice.DigitalLedgerIdentification),nameof(PartyIdentification257Choice.DigitalLedgerIdentification))]
    [JsonDerivedType(typeof(PartyIdentification257Choice.NameAndAddress),nameof(PartyIdentification257Choice.NameAndAddress))]
    [IsoId("_PXUt4ZajEe-Rg9SagunFVg")]
    [DisplayName("Party Identification257Choice")]
    public abstract partial record PartyIdentification257Choice_
    {
    }
}
