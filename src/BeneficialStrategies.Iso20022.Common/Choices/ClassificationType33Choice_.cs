// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the classification.
    /// </summary>
    [KnownType(typeof(ClassificationType33Choice.ClassificationFinancialInstrument))]
    [KnownType(typeof(ClassificationType33Choice.AlternateClassification))]
    [JsonDerivedType(
        typeof(ClassificationType33Choice.ClassificationFinancialInstrument),
        nameof(ClassificationType33Choice.ClassificationFinancialInstrument)
    )]
    [JsonDerivedType(
        typeof(ClassificationType33Choice.AlternateClassification),
        nameof(ClassificationType33Choice.AlternateClassification)
    )]
    [IsoId("_chVpw5KQEeWHWpTQn1FFVg")]
    [DisplayName("Classification Type 33 Choice")]
    public abstract record ClassificationType33Choice_ { }
}
