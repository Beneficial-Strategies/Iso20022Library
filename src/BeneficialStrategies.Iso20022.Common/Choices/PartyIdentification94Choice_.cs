// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification94Choice.BICFI))]
    [KnownType(typeof(PartyIdentification94Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification94Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification94Choice.BICFI),nameof(PartyIdentification94Choice.BICFI))]
    [JsonDerivedType(typeof(PartyIdentification94Choice.NameAndAddress),nameof(PartyIdentification94Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification94Choice.ProprietaryIdentification),nameof(PartyIdentification94Choice.ProprietaryIdentification))]
    [IsoId("_wnZu7UHREeW-Sp6UI3iOQA")]
    [DisplayName("Party Identification 94 Choice")]
    public abstract partial record PartyIdentification94Choice_
    {
    }
}
