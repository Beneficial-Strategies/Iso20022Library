// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the classification.
    /// </summary>
    [KnownType(typeof(ClassificationType32Choice.ClassificationFinancialInstrument))]
    [KnownType(typeof(ClassificationType32Choice.AlternateClassification))]
    [JsonDerivedType(
        typeof(ClassificationType32Choice.ClassificationFinancialInstrument),
        nameof(ClassificationType32Choice.ClassificationFinancialInstrument)
    )]
    [JsonDerivedType(
        typeof(ClassificationType32Choice.AlternateClassification),
        nameof(ClassificationType32Choice.AlternateClassification)
    )]
    [IsoId("_IbgeMYlYEeWPSZi0kAOXhg")]
    [DisplayName("Classification Type 32 Choice")]
    public abstract record ClassificationType32Choice_ { }
}
