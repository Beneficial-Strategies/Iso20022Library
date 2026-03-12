// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification233Choice.LegalPerson))]
    [KnownType(typeof(PartyIdentification233Choice.NaturalPerson))]
    [JsonDerivedType(typeof(PartyIdentification233Choice.LegalPerson),nameof(PartyIdentification233Choice.LegalPerson))]
    [JsonDerivedType(typeof(PartyIdentification233Choice.NaturalPerson),nameof(PartyIdentification233Choice.NaturalPerson))]
    [IsoId("_6264AfQ0EeqAradXpAelDQ")]
    [DisplayName("Party Identification 233 Choice")]
    public abstract partial record PartyIdentification233Choice_
    {
    }
}
