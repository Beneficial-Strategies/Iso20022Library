// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification42Choice.BICFI))]
    [KnownType(typeof(PartyIdentification42Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification42Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification42Choice.BICFI),nameof(PartyIdentification42Choice.BICFI))]
    [JsonDerivedType(typeof(PartyIdentification42Choice.NameAndAddress),nameof(PartyIdentification42Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification42Choice.ProprietaryIdentification),nameof(PartyIdentification42Choice.ProprietaryIdentification))]
    [IsoId("_v1Alz_L-Ed-3lpUMQaXLjQ")]
    [DisplayName("Party Identification 42 Choice")]
    public abstract partial record PartyIdentification42Choice_
    {
    }
}
