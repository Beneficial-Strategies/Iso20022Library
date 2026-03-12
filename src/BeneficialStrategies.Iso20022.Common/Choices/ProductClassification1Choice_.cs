// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Type of relevant product classification.
    /// </summary>
    [KnownType(typeof(ProductClassification1Choice.ClassificationFinancialInstrument))]
    [KnownType(typeof(ProductClassification1Choice.UniqueProductIdentifier))]
    [JsonDerivedType(typeof(ProductClassification1Choice.ClassificationFinancialInstrument),nameof(ProductClassification1Choice.ClassificationFinancialInstrument))]
    [JsonDerivedType(typeof(ProductClassification1Choice.UniqueProductIdentifier),nameof(ProductClassification1Choice.UniqueProductIdentifier))]
    [IsoId("_POpXwAOGEeWs3sTa9Sj6Lg")]
    [DisplayName("Product Classification 1 Choice")]
    public abstract partial record ProductClassification1Choice_
    {
    }
}
