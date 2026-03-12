// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Reason17Choice
{
    /// <summary>
    /// Specifies the reason why the instruction has a pending status.
    /// </summary>
    [IsoId("_8Qc135NLEeWGlc8L7oPDIg")]
    [DisplayName("Pending Reason")]
    public partial record PendingReason : Reason17Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
