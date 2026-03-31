// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification226Choice.LegalPerson))]
    [KnownType(typeof(PartyIdentification226Choice.NaturalPerson))]
    [JsonDerivedType(
        typeof(PartyIdentification226Choice.LegalPerson),
        nameof(PartyIdentification226Choice.LegalPerson)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification226Choice.NaturalPerson),
        nameof(PartyIdentification226Choice.NaturalPerson)
    )]
    [IsoId("_nbVCM6-kEemJ1NnLPsTFaw")]
    [DisplayName("Party Identification 226 Choice")]
    public abstract record PartyIdentification226Choice_ { }
}
