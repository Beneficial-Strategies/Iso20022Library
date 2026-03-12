// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification227Choice.LegalPerson))]
    [KnownType(typeof(PartyIdentification227Choice.NaturalPerson))]
    [JsonDerivedType(typeof(PartyIdentification227Choice.LegalPerson),nameof(PartyIdentification227Choice.LegalPerson))]
    [JsonDerivedType(typeof(PartyIdentification227Choice.NaturalPerson),nameof(PartyIdentification227Choice.NaturalPerson))]
    [IsoId("_B1TxM6-mEemJ1NnLPsTFaw")]
    [DisplayName("Party Identification 227 Choice")]
    public abstract partial record PartyIdentification227Choice_
    {
    }
}
