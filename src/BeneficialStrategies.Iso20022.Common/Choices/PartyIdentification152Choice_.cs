// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification152Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification152Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification152Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification152Choice.AnyBIC),nameof(PartyIdentification152Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification152Choice.ProprietaryIdentification),nameof(PartyIdentification152Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification152Choice.NameAndAddress),nameof(PartyIdentification152Choice.NameAndAddress))]
    [IsoId("_2vSTQf1REeixXcHVEYIW2g")]
    [DisplayName("Party Identification 152 Choice")]
    public abstract partial record PartyIdentification152Choice_
    {
    }
}
