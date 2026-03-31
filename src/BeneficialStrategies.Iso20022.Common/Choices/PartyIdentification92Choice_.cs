// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification92Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification92Choice.ProprietaryIdentification))]
    [JsonDerivedType(
        typeof(PartyIdentification92Choice.AnyBIC),
        nameof(PartyIdentification92Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification92Choice.ProprietaryIdentification),
        nameof(PartyIdentification92Choice.ProprietaryIdentification)
    )]
    [IsoId("_EsujuA9kEeW4bIslN9_VQg")]
    [DisplayName("Party Identification 92 Choice")]
    public abstract record PartyIdentification92Choice_ { }
}
