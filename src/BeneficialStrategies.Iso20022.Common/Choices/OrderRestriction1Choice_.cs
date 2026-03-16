// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Order Restriction1Choice.
    /// </summary>
    [KnownType(typeof(OrderRestriction1Choice.OrderRestrictionCode))]
    [KnownType(typeof(OrderRestriction1Choice.Proprietary))]
    [JsonDerivedType(typeof(OrderRestriction1Choice.OrderRestrictionCode),nameof(OrderRestriction1Choice.OrderRestrictionCode))]
    [JsonDerivedType(typeof(OrderRestriction1Choice.Proprietary),nameof(OrderRestriction1Choice.Proprietary))]
    [IsoId("_UVj6EGseEe25qph5Y8_eYQ")]
    [DisplayName("Order Restriction1Choice")]
    public abstract partial record OrderRestriction1Choice_
    {
    }
}
