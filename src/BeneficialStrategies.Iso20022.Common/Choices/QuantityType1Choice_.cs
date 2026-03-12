// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the quantity.
    /// </summary>
    [KnownType(typeof(QuantityType1Choice.Code))]
    [KnownType(typeof(QuantityType1Choice.Proprietary))]
    [JsonDerivedType(typeof(QuantityType1Choice.Code),nameof(QuantityType1Choice.Code))]
    [JsonDerivedType(typeof(QuantityType1Choice.Proprietary),nameof(QuantityType1Choice.Proprietary))]
    [IsoId("_zQ8vYQaxEeS3lpTattq7hg")]
    [DisplayName("Quantity Type 1 Choice")]
    public abstract partial record QuantityType1Choice_
    {
    }
}
