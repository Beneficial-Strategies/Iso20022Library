// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus4Choice
{
    /// <summary>
    /// Status of the switch order is conditionally accepted.
    /// </summary>
    [IsoId("_9wxHxUH8EeaV3ab_pHzFIQ")]
    [DisplayName("Conditionally Accepted")]
    public record ConditionallyAccepted : OrderStatus4Choice_ { }
}
