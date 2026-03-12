// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification38Choice.BICFI))]
    [KnownType(typeof(PartyIdentification38Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification38Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification38Choice.BICFI),nameof(PartyIdentification38Choice.BICFI))]
    [JsonDerivedType(typeof(PartyIdentification38Choice.NameAndAddress),nameof(PartyIdentification38Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification38Choice.ProprietaryIdentification),nameof(PartyIdentification38Choice.ProprietaryIdentification))]
    [IsoId("_6VaZX-aQEd-q8fx_Zl_34A")]
    [DisplayName("Party Identification 38 Choice")]
    public abstract partial record PartyIdentification38Choice_
    {
    }
}
