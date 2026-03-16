// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the revaluation.
    /// </summary>
    [KnownType(typeof(RevaluationIndicator3Choice.Indicator))]
    [KnownType(typeof(RevaluationIndicator3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(RevaluationIndicator3Choice.Indicator),
        nameof(RevaluationIndicator3Choice.Indicator)
    )]
    [JsonDerivedType(
        typeof(RevaluationIndicator3Choice.Proprietary),
        nameof(RevaluationIndicator3Choice.Proprietary)
    )]
    [IsoId("_BveJgTw0EeW3QqUkIQtIUA")]
    [DisplayName("Revaluation Indicator 3 Choice")]
    public abstract record RevaluationIndicator3Choice_ { }
}
