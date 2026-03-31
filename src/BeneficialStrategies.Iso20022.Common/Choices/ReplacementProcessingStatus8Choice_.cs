// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the replacement processing status.
    /// </summary>
    [KnownType(typeof(ReplacementProcessingStatus8Choice.Code))]
    [KnownType(typeof(ReplacementProcessingStatus8Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ReplacementProcessingStatus8Choice.Code),
        nameof(ReplacementProcessingStatus8Choice.Code)
    )]
    [JsonDerivedType(
        typeof(ReplacementProcessingStatus8Choice.Proprietary),
        nameof(ReplacementProcessingStatus8Choice.Proprietary)
    )]
    [IsoId("_m8gS4TqqEeWyoP0PbocV1Q")]
    [DisplayName("Replacement Processing Status 8 Choice")]
    public abstract record ReplacementProcessingStatus8Choice_ { }
}
