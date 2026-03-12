// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification231Choice.LegalPerson))]
    [KnownType(typeof(PartyIdentification231Choice.NaturalPerson))]
    [JsonDerivedType(typeof(PartyIdentification231Choice.LegalPerson),nameof(PartyIdentification231Choice.LegalPerson))]
    [JsonDerivedType(typeof(PartyIdentification231Choice.NaturalPerson),nameof(PartyIdentification231Choice.NaturalPerson))]
    [IsoId("_oa2lUfQ0EeqAradXpAelDQ")]
    [DisplayName("Party Identification 231 Choice")]
    public abstract partial record PartyIdentification231Choice_
    {
    }
}
