// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the classification.
    /// </summary>
    [KnownType(typeof(ClassificationType30Choice.ClassificationFinancialInstrument))]
    [KnownType(typeof(ClassificationType30Choice.AlternateClassification))]
    [JsonDerivedType(
        typeof(ClassificationType30Choice.ClassificationFinancialInstrument),
        nameof(ClassificationType30Choice.ClassificationFinancialInstrument)
    )]
    [JsonDerivedType(
        typeof(ClassificationType30Choice.AlternateClassification),
        nameof(ClassificationType30Choice.AlternateClassification)
    )]
    [IsoId("_AbpPotokEeC60axPepSq7g_371267189")]
    [DisplayName("Classification Type 30 Choice")]
    public abstract record ClassificationType30Choice_ { }
}
