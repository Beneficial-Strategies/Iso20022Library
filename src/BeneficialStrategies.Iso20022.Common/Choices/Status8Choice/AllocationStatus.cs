// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Status8Choice
{
    /// <summary>
    /// Provides the status of allocation of collateral to cover the instruction.
    /// </summary>
    [IsoId("_w2B7f0ABEeCaq78Ig8ATcA")]
    [DisplayName("Allocation Status")]
    public partial record AllocationStatus : Status8Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
