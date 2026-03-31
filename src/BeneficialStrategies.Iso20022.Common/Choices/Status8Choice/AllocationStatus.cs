// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status8Choice
{
    /// <summary>
    /// Provides the status of allocation of collateral to cover the instruction.
    /// </summary>
    [IsoId("_w2B7f0ABEeCaq78Ig8ATcA")]
    [DisplayName("Allocation Status")]
    public record AllocationStatus : Status8Choice_ { }
}
