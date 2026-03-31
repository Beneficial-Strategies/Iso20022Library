// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the revaluation.
    /// </summary>
    [KnownType(typeof(RevaluationIndicator1Choice.Indicator))]
    [KnownType(typeof(RevaluationIndicator1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(RevaluationIndicator1Choice.Indicator),
        nameof(RevaluationIndicator1Choice.Indicator)
    )]
    [JsonDerivedType(
        typeof(RevaluationIndicator1Choice.Proprietary),
        nameof(RevaluationIndicator1Choice.Proprietary)
    )]
    [IsoId("_Quh38dp-Ed-ak6NoX_4Aeg_1541845195")]
    [DisplayName("Revaluation Indicator 1 Choice")]
    public abstract record RevaluationIndicator1Choice_ { }
}
