// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the identification of the organisation.
    /// </summary>
    [KnownType(typeof(PartyIdentification248Choice.Legal))]
    [KnownType(typeof(PartyIdentification248Choice.Natural))]
    [JsonDerivedType(
        typeof(PartyIdentification248Choice.Legal),
        nameof(PartyIdentification248Choice.Legal)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification248Choice.Natural),
        nameof(PartyIdentification248Choice.Natural)
    )]
    [IsoId("_V_oRsT3YEe2uHKhHp3bXyA")]
    [DisplayName("Party Identification 248 Choice")]
    public abstract record PartyIdentification248Choice_ { }
}
