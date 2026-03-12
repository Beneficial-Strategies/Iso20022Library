// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Planned number of shares to be purchased
    ///  買付予定株式数.
    /// </summary>
    [KnownType(typeof(PlannedQuantity1Choice.Quantity))]
    [KnownType(typeof(PlannedQuantity1Choice.Code))]
    [JsonDerivedType(typeof(PlannedQuantity1Choice.Quantity),nameof(PlannedQuantity1Choice.Quantity))]
    [JsonDerivedType(typeof(PlannedQuantity1Choice.Code),nameof(PlannedQuantity1Choice.Code))]
    [IsoId("_X3C-0zFzEeGKkIZzgd38VA")]
    [DisplayName("Planned Quantity 1 Choice")]
    public abstract partial record PlannedQuantity1Choice_
    {
    }
}
