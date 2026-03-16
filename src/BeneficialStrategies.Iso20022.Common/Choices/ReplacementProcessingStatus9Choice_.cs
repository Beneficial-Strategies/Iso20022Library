// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the replacement processing status.
    /// </summary>
    [KnownType(typeof(ReplacementProcessingStatus9Choice.Code))]
    [KnownType(typeof(ReplacementProcessingStatus9Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ReplacementProcessingStatus9Choice.Code),
        nameof(ReplacementProcessingStatus9Choice.Code)
    )]
    [JsonDerivedType(
        typeof(ReplacementProcessingStatus9Choice.Proprietary),
        nameof(ReplacementProcessingStatus9Choice.Proprietary)
    )]
    [IsoId("_8QcPaZNLEeWGlc8L7oPDIg")]
    [DisplayName("Replacement Processing Status 9 Choice")]
    public abstract record ReplacementProcessingStatus9Choice_ { }
}
