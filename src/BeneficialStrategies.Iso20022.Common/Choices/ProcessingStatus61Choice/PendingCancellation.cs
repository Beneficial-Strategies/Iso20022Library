// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus61Choice
{
    /// <summary>
    /// The cancellation is pending processing.
    /// </summary>
    [IsoId("_6QDry5NLEeWGlc8L7oPDIg")]
    [DisplayName("Pending Cancellation")]
    public partial record PendingCancellation : ProcessingStatus61Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
