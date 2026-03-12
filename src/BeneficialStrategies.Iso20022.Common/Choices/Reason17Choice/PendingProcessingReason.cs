// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Reason17Choice
{
    /// <summary>
    /// Specifies the reason why the instruction has a pending processing status.
    /// </summary>
    [IsoId("_8Qc145NLEeWGlc8L7oPDIg")]
    [DisplayName("Pending Processing Reason")]
    public partial record PendingProcessingReason : Reason17Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
