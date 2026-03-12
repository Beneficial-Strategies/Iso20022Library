// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification96Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification96Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification96Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification96Choice.TaxIdentificationNumber))]
    [KnownType(typeof(PartyIdentification96Choice.NationalRegistrationNumber))]
    [JsonDerivedType(typeof(PartyIdentification96Choice.AnyBIC),nameof(PartyIdentification96Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification96Choice.ProprietaryIdentification),nameof(PartyIdentification96Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification96Choice.NameAndAddress),nameof(PartyIdentification96Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification96Choice.TaxIdentificationNumber),nameof(PartyIdentification96Choice.TaxIdentificationNumber))]
    [JsonDerivedType(typeof(PartyIdentification96Choice.NationalRegistrationNumber),nameof(PartyIdentification96Choice.NationalRegistrationNumber))]
    [IsoId("_vsuhsSGYEeWKAaDJcYGKLw")]
    [DisplayName("Party Identification 96 Choice")]
    public abstract partial record PartyIdentification96Choice_
    {
    }
}
