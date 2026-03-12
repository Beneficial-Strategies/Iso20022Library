// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification196Choice.LegalPerson))]
    [KnownType(typeof(PartyIdentification196Choice.NaturalPerson))]
    [JsonDerivedType(typeof(PartyIdentification196Choice.LegalPerson),nameof(PartyIdentification196Choice.LegalPerson))]
    [JsonDerivedType(typeof(PartyIdentification196Choice.NaturalPerson),nameof(PartyIdentification196Choice.NaturalPerson))]
    [IsoId("_3xRQ4zqrEemL_ewJY9QP1g")]
    [DisplayName("Party Identification 196 Choice")]
    public abstract partial record PartyIdentification196Choice_
    {
    }
}
