// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the identification of the organisation.
    /// </summary>
    [KnownType(typeof(PartyIdentification235Choice.Legal))]
    [KnownType(typeof(PartyIdentification235Choice.Natural))]
    [JsonDerivedType(typeof(PartyIdentification235Choice.Legal),nameof(PartyIdentification235Choice.Legal))]
    [JsonDerivedType(typeof(PartyIdentification235Choice.Natural),nameof(PartyIdentification235Choice.Natural))]
    [IsoId("_vS27Ie9KEemVGdgB8P8uQQ")]
    [DisplayName("Party Identification 235 Choice")]
    public abstract partial record PartyIdentification235Choice_
    {
    }
}
