// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification49Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification49Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification49Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification49Choice.AnyBIC),nameof(PartyIdentification49Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification49Choice.ProprietaryIdentification),nameof(PartyIdentification49Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification49Choice.NameAndAddress),nameof(PartyIdentification49Choice.NameAndAddress))]
    [IsoId("_K1u4YeaOEd-q8fx_Zl_34A")]
    [DisplayName("Party Identification 49 Choice")]
    public abstract partial record PartyIdentification49Choice_
    {
    }
}
