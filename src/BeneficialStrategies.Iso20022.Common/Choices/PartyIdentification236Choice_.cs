// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the identification of the organisation.
    /// </summary>
    [KnownType(typeof(PartyIdentification236Choice.Legal))]
    [KnownType(typeof(PartyIdentification236Choice.Natural))]
    [JsonDerivedType(
        typeof(PartyIdentification236Choice.Legal),
        nameof(PartyIdentification236Choice.Legal)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification236Choice.Natural),
        nameof(PartyIdentification236Choice.Natural)
    )]
    [IsoId("_bOmisMgoEeuGrNSsxk3B0A")]
    [DisplayName("Party Identification 236 Choice")]
    public abstract record PartyIdentification236Choice_ { }
}
