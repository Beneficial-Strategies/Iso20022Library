// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a CFI code or an other type of identification for the classification of the financial instrument.
    /// </summary>
    [KnownType(typeof(SecurityClassificationType1Choice.CFI))]
    [KnownType(typeof(SecurityClassificationType1Choice.AlternateClassification))]
    [JsonDerivedType(
        typeof(SecurityClassificationType1Choice.CFI),
        nameof(SecurityClassificationType1Choice.CFI)
    )]
    [JsonDerivedType(
        typeof(SecurityClassificationType1Choice.AlternateClassification),
        nameof(SecurityClassificationType1Choice.AlternateClassification)
    )]
    [IsoId("_Q7pG4dp-Ed-ak6NoX_4Aeg_-1579220601")]
    [DisplayName("Security Classification Type 1 Choice")]
    public abstract record SecurityClassificationType1Choice_ { }
}
