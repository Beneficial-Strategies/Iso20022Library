// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DiscountOrChargeType1Choice
{
    /// <summary>
    /// Type of charge.
    /// </summary>
    [IsoId("_St2yMQEcEeCQm6a_G2yO_w_-1448163837")]
    [DisplayName("Charge Type")]
    public record ChargeType : DiscountOrChargeType1Choice_ { }
}
