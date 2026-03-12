// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification205Choice.LegalPerson))]
    [KnownType(typeof(PartyIdentification205Choice.NaturalPerson))]
    [JsonDerivedType(typeof(PartyIdentification205Choice.LegalPerson),nameof(PartyIdentification205Choice.LegalPerson))]
    [JsonDerivedType(typeof(PartyIdentification205Choice.NaturalPerson),nameof(PartyIdentification205Choice.NaturalPerson))]
    [IsoId("_hQcS8I6XEemzmeK8_tPygg")]
    [DisplayName("Party Identification 205 Choice")]
    public abstract partial record PartyIdentification205Choice_
    {
    }
}
