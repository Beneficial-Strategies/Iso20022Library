// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the revaluation.
    /// </summary>
    [KnownType(typeof(RevaluationIndicator4Choice.Indicator))]
    [KnownType(typeof(RevaluationIndicator4Choice.Proprietary))]
    [JsonDerivedType(typeof(RevaluationIndicator4Choice.Indicator),nameof(RevaluationIndicator4Choice.Indicator))]
    [JsonDerivedType(typeof(RevaluationIndicator4Choice.Proprietary),nameof(RevaluationIndicator4Choice.Proprietary))]
    [IsoId("_5mw3_ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Revaluation Indicator 4 Choice")]
    public abstract partial record RevaluationIndicator4Choice_
    {
    }
}
