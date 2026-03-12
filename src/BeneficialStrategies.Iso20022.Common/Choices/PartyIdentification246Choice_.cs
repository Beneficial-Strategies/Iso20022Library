// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification246Choice.LegalPerson))]
    [KnownType(typeof(PartyIdentification246Choice.NaturalPerson))]
    [JsonDerivedType(typeof(PartyIdentification246Choice.LegalPerson),nameof(PartyIdentification246Choice.LegalPerson))]
    [JsonDerivedType(typeof(PartyIdentification246Choice.NaturalPerson),nameof(PartyIdentification246Choice.NaturalPerson))]
    [IsoId("__6rlSzUCEe2tRf29bleifQ")]
    [DisplayName("Party Identification 246 Choice")]
    public abstract partial record PartyIdentification246Choice_
    {
    }
}
