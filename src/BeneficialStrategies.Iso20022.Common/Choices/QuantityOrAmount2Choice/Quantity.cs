// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.QuantityOrAmount2Choice
{
    /// <summary>
    /// Quantity is expressed in units, face amount or amortised amount.
    /// </summary>
    [IsoId("_wXH_kQeCEe2fOITqoTnSLQ")]
    [DisplayName("Quantity")]
    public record Quantity : QuantityOrAmount2Choice_ { }
}
