// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the classification.
    /// </summary>
    [KnownType(typeof(ClassificationType4Choice.ClassificationFinancialInstrument))]
    [KnownType(typeof(ClassificationType4Choice.AlternateClassification))]
    [JsonDerivedType(
        typeof(ClassificationType4Choice.ClassificationFinancialInstrument),
        nameof(ClassificationType4Choice.ClassificationFinancialInstrument)
    )]
    [JsonDerivedType(
        typeof(ClassificationType4Choice.AlternateClassification),
        nameof(ClassificationType4Choice.AlternateClassification)
    )]
    [IsoId("_XQgXMtp-Ed-ak6NoX_4Aeg_322519448")]
    [DisplayName("Classification Type 4 Choice")]
    public abstract record ClassificationType4Choice_ { }
}
