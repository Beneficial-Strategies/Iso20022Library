// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.QuantityOrCode1Choice
{
    /// <summary>
    /// Quantity expressed as a number.
    /// </summary>
    [IsoId("_M2xt0K-WEemJ1NnLPsTFaw")]
    [DisplayName("Quantity")]
    public record Quantity : QuantityOrCode1Choice_ { }
}
