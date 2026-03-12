// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a type of discount or a type of charge.
    /// </summary>
    [KnownType(typeof(DiscountOrChargeType1Choice.ChargeType))]
    [KnownType(typeof(DiscountOrChargeType1Choice.DiscountType))]
    [JsonDerivedType(typeof(DiscountOrChargeType1Choice.ChargeType),nameof(DiscountOrChargeType1Choice.ChargeType))]
    [JsonDerivedType(typeof(DiscountOrChargeType1Choice.DiscountType),nameof(DiscountOrChargeType1Choice.DiscountType))]
    [IsoId("_St2yMAEcEeCQm6a_G2yO_w_-1902647807")]
    [DisplayName("Discount Or Charge Type 1 Choice")]
    public abstract partial record DiscountOrChargeType1Choice_
    {
    }
}
