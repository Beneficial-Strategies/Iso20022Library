// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the classification.
    /// </summary>
    [KnownType(typeof(ClassificationType1Choice.ClassificationFinancialInstrument))]
    [KnownType(typeof(ClassificationType1Choice.AlternateClassification))]
    [JsonDerivedType(typeof(ClassificationType1Choice.ClassificationFinancialInstrument),nameof(ClassificationType1Choice.ClassificationFinancialInstrument))]
    [JsonDerivedType(typeof(ClassificationType1Choice.AlternateClassification),nameof(ClassificationType1Choice.AlternateClassification))]
    [IsoId("_RdUQk9p-Ed-ak6NoX_4Aeg_-538549826")]
    [DisplayName("Classification Type 1 Choice")]
    public abstract partial record ClassificationType1Choice_
    {
    }
}
