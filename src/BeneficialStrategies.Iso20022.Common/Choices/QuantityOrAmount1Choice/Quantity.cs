// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.QuantityOrAmount1Choice
{
    /// <summary>
    /// Quantity is expressed in units, face amount or amortised amount.
    /// </summary>
    [IsoId("_Q-K2cdp-Ed-ak6NoX_4Aeg_1486122904")]
    [DisplayName("Quantity")]
    public record Quantity : QuantityOrAmount1Choice_ { }
}
