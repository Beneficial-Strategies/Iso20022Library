// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code for specifying the type of discount.
    /// </summary>
    [KnownType(typeof(DiscountTypeFormat1Choice.Code))]
    [KnownType(typeof(DiscountTypeFormat1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(DiscountTypeFormat1Choice.Code),
        nameof(DiscountTypeFormat1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(DiscountTypeFormat1Choice.Proprietary),
        nameof(DiscountTypeFormat1Choice.Proprietary)
    )]
    [IsoId("_SumZFQEcEeCQm6a_G2yO_w_1636227092")]
    [DisplayName("Discount Type Format 1 Choice")]
    public abstract record DiscountTypeFormat1Choice_ { }
}
