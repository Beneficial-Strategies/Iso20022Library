// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification223Choice.LegalPerson))]
    [KnownType(typeof(PartyIdentification223Choice.NaturalPerson))]
    [JsonDerivedType(typeof(PartyIdentification223Choice.LegalPerson),nameof(PartyIdentification223Choice.LegalPerson))]
    [JsonDerivedType(typeof(PartyIdentification223Choice.NaturalPerson),nameof(PartyIdentification223Choice.NaturalPerson))]
    [IsoId("_1G7dE6-EEemJ1NnLPsTFaw")]
    [DisplayName("Party Identification 223 Choice")]
    public abstract partial record PartyIdentification223Choice_
    {
    }
}
