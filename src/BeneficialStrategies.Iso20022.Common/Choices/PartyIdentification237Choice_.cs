// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification237Choice.LegalPerson))]
    [KnownType(typeof(PartyIdentification237Choice.NaturalPerson))]
    [JsonDerivedType(typeof(PartyIdentification237Choice.LegalPerson),nameof(PartyIdentification237Choice.LegalPerson))]
    [JsonDerivedType(typeof(PartyIdentification237Choice.NaturalPerson),nameof(PartyIdentification237Choice.NaturalPerson))]
    [IsoId("_fV47ERuUEeyhRdHRjakS2w")]
    [DisplayName("Party Identification 237 Choice")]
    public abstract partial record PartyIdentification237Choice_
    {
    }
}
