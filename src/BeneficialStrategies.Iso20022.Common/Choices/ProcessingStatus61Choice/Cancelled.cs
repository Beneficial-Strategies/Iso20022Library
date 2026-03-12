// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus61Choice
{
    /// <summary>
    /// Cancellation requested executed.
    /// </summary>
    [IsoId("_6QDr-5NLEeWGlc8L7oPDIg")]
    [DisplayName("Cancelled")]
    public partial record Cancelled : ProcessingStatus61Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
