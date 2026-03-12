// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus63Choice
{
    /// <summary>
    /// Instruction/Request has been cancelled.
    /// </summary>
    [IsoId("_8NnkkZNLEeWGlc8L7oPDIg")]
    [DisplayName("Cancelled")]
    public partial record Cancelled : ProcessingStatus63Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
