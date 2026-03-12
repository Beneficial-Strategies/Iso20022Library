// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Reason17Choice
{
    /// <summary>
    /// Specifies the reason why the related instruction is cancelled, or the related cancellation request is executed.
    /// </summary>
    [IsoId("_8Qc11ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Cancellation Reason")]
    public partial record CancellationReason : Reason17Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
