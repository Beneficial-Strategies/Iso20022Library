// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a type of pension order.
    /// </summary>
    [KnownType(typeof(PensionOrderType1Choice.Code))]
    [KnownType(typeof(PensionOrderType1Choice.Proprietary))]
    [JsonDerivedType(typeof(PensionOrderType1Choice.Code),nameof(PensionOrderType1Choice.Code))]
    [JsonDerivedType(typeof(PensionOrderType1Choice.Proprietary),nameof(PensionOrderType1Choice.Proprietary))]
    [IsoId("_7zYaALTpEeiENt6AoDfPXg")]
    [DisplayName("Pension Order Type 1 Choice")]
    public abstract partial record PensionOrderType1Choice_
    {
    }
}
