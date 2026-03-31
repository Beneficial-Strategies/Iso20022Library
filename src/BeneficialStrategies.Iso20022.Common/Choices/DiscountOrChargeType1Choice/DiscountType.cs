// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DiscountOrChargeType1Choice
{
    /// <summary>
    /// Type of discount.
    /// </summary>
    [IsoId("_St2yMgEcEeCQm6a_G2yO_w_1552852069")]
    [DisplayName("Discount Type")]
    public record DiscountType : DiscountOrChargeType1Choice_ { }
}
