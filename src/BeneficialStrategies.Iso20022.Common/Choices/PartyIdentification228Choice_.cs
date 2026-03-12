// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification228Choice.LegalPerson))]
    [KnownType(typeof(PartyIdentification228Choice.NaturalPerson))]
    [JsonDerivedType(typeof(PartyIdentification228Choice.LegalPerson),nameof(PartyIdentification228Choice.LegalPerson))]
    [JsonDerivedType(typeof(PartyIdentification228Choice.NaturalPerson),nameof(PartyIdentification228Choice.NaturalPerson))]
    [IsoId("_3Ep6w7IFEemux5trsZcCpw")]
    [DisplayName("Party Identification 228 Choice")]
    public abstract partial record PartyIdentification228Choice_
    {
    }
}
