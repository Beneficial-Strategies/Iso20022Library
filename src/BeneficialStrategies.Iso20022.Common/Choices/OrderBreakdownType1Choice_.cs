// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for order breakdown type.
    /// </summary>
    [KnownType(typeof(OrderBreakdownType1Choice.Code))]
    [KnownType(typeof(OrderBreakdownType1Choice.Proprietary))]
    [JsonDerivedType(typeof(OrderBreakdownType1Choice.Code),nameof(OrderBreakdownType1Choice.Code))]
    [JsonDerivedType(typeof(OrderBreakdownType1Choice.Proprietary),nameof(OrderBreakdownType1Choice.Proprietary))]
    [IsoId("_uwnTwDhjEeamLZQeccJa7w")]
    [DisplayName("Order Breakdown Type 1 Choice")]
    public abstract partial record OrderBreakdownType1Choice_
    {
    }
}
