// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification101Choice.BIC))]
    [KnownType(typeof(PartyIdentification101Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification101Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification101Choice.BIC),nameof(PartyIdentification101Choice.BIC))]
    [JsonDerivedType(typeof(PartyIdentification101Choice.ProprietaryIdentification),nameof(PartyIdentification101Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification101Choice.NameAndAddress),nameof(PartyIdentification101Choice.NameAndAddress))]
    [IsoId("_LGBh0YMEEeWhGPRU7TIQwQ")]
    [DisplayName("Party Identification 101 Choice")]
    public abstract partial record PartyIdentification101Choice_
    {
    }
}
