// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus62Choice
{
    /// <summary>
    /// Instruction has been acknowledged by the account servicer.
    /// </summary>
    [IsoId("_6d7viZNLEeWGlc8L7oPDIg")]
    [DisplayName("Acknowledged Accepted")]
    public partial record AcknowledgedAccepted : ProcessingStatus62Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
