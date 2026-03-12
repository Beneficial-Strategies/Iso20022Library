// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus53Choice
{
    /// <summary>
    /// Cancellation requested executed.
    /// </summary>
    [IsoId("_2993OTp4EeWVrPy0StzzSg")]
    [DisplayName("Cancelled")]
    public partial record Cancelled : ProcessingStatus53Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
