// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the amount type.
    /// </summary>
    [KnownType(typeof(DiscountAmountType1Choice.Code))]
    [KnownType(typeof(DiscountAmountType1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(DiscountAmountType1Choice.Code),
        nameof(DiscountAmountType1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(DiscountAmountType1Choice.Proprietary),
        nameof(DiscountAmountType1Choice.Proprietary)
    )]
    [IsoId("_tlhp9FkyEeGeoaLUQk__nA_1969856985")]
    [DisplayName("Discount Amount Type 1 Choice")]
    public abstract record DiscountAmountType1Choice_ { }
}
