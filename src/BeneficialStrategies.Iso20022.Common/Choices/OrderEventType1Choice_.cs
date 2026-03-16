// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Order Event Type1Choice.
    /// </summary>
    [KnownType(typeof(OrderEventType1Choice.Code))]
    [KnownType(typeof(OrderEventType1Choice.Proprietary))]
    [JsonDerivedType(typeof(OrderEventType1Choice.Code),nameof(OrderEventType1Choice.Code))]
    [JsonDerivedType(typeof(OrderEventType1Choice.Proprietary),nameof(OrderEventType1Choice.Proprietary))]
    [IsoId("_7ag5EGveEe2Re-GccwOX8g")]
    [DisplayName("Order Event Type1Choice")]
    public abstract partial record OrderEventType1Choice_
    {
    }
}
