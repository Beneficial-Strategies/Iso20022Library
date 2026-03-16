// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a product structure.
    /// </summary>
    [KnownType(typeof(ProductStructure1Choice.Code))]
    [KnownType(typeof(ProductStructure1Choice.Proprietary))]
    [JsonDerivedType(typeof(ProductStructure1Choice.Code), nameof(ProductStructure1Choice.Code))]
    [JsonDerivedType(
        typeof(ProductStructure1Choice.Proprietary),
        nameof(ProductStructure1Choice.Proprietary)
    )]
    [IsoId("_G5LTIKDqEequlaOyi6MUhw")]
    [DisplayName("Product Structure 1 Choice")]
    public abstract record ProductStructure1Choice_ { }
}
