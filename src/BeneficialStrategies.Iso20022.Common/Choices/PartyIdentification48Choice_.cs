// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification48Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification48Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification48Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification48Choice.AnyBIC),nameof(PartyIdentification48Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification48Choice.ProprietaryIdentification),nameof(PartyIdentification48Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification48Choice.NameAndAddress),nameof(PartyIdentification48Choice.NameAndAddress))]
    [IsoId("_gOYtceaNEd-q8fx_Zl_34A")]
    [DisplayName("Party Identification 48 Choice")]
    public abstract partial record PartyIdentification48Choice_
    {
    }
}
