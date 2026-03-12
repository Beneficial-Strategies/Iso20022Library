// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification182Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification182Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification182Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification182Choice.TaxIdentificationNumber))]
    [KnownType(typeof(PartyIdentification182Choice.NationalRegistrationNumber))]
    [JsonDerivedType(typeof(PartyIdentification182Choice.AnyBIC),nameof(PartyIdentification182Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification182Choice.ProprietaryIdentification),nameof(PartyIdentification182Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification182Choice.NameAndAddress),nameof(PartyIdentification182Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification182Choice.TaxIdentificationNumber),nameof(PartyIdentification182Choice.TaxIdentificationNumber))]
    [JsonDerivedType(typeof(PartyIdentification182Choice.NationalRegistrationNumber),nameof(PartyIdentification182Choice.NationalRegistrationNumber))]
    [IsoId("_NPY5wZTJEemqYPWMBuVawg")]
    [DisplayName("Party Identification 182 Choice")]
    public abstract partial record PartyIdentification182Choice_
    {
    }
}
