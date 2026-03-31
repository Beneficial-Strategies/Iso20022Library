// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status1Choice
{
    /// <summary>
    /// Provides the status of allocation of collateral to cover the instruction.
    /// </summary>
    [IsoId("_UU5htdp-Ed-ak6NoX_4Aeg_-2085416312")]
    [DisplayName("Allocation Status")]
    public record AllocationStatus : Status1Choice_ { }
}
