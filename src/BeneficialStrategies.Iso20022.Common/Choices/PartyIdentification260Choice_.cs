// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Party Identification260Choice.
    /// </summary>
    [KnownType(typeof(PartyIdentification260Choice.LegalPerson))]
    [KnownType(typeof(PartyIdentification260Choice.NaturalPerson))]
    [JsonDerivedType(typeof(PartyIdentification260Choice.LegalPerson),nameof(PartyIdentification260Choice.LegalPerson))]
    [JsonDerivedType(typeof(PartyIdentification260Choice.NaturalPerson),nameof(PartyIdentification260Choice.NaturalPerson))]
    [IsoId("_XXG-0eIZEe-eFYnrXcX-mQ")]
    [DisplayName("Party Identification260Choice")]
    public abstract partial record PartyIdentification260Choice_
    {
    }
}
