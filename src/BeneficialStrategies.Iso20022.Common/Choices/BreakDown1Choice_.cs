// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies if breakdown is by purchase order or commercial invoice.
    /// </summary>
    [KnownType(typeof(BreakDown1Choice.ByPurchaseOrder))]
    [KnownType(typeof(BreakDown1Choice.ByCommercialInvoice))]
    [JsonDerivedType(typeof(BreakDown1Choice.ByPurchaseOrder),nameof(BreakDown1Choice.ByPurchaseOrder))]
    [JsonDerivedType(typeof(BreakDown1Choice.ByCommercialInvoice),nameof(BreakDown1Choice.ByCommercialInvoice))]
    [IsoId("_tbfaMBrYEeOVR9VN6fAMUg")]
    [DisplayName("Break Down 1 Choice")]
    public abstract partial record BreakDown1Choice_
    {
    }
}
