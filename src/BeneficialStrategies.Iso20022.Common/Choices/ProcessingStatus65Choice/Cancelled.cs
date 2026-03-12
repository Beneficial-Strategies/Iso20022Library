// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus65Choice
{
    /// <summary>
    /// Cancellation requested executed.
    /// </summary>
    [IsoId("_8SdBLZNLEeWGlc8L7oPDIg")]
    [DisplayName("Cancelled")]
    public partial record Cancelled : ProcessingStatus65Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
