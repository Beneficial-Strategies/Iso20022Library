// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus67Choice
{
    /// <summary>
    /// Instruction or request has been rejected for further processing.
    /// </summary>
    [IsoId("_XD6lIeFUEeWIA4E9cYSxxQ")]
    [DisplayName("Rejected")]
    public partial record Rejected : ProcessingStatus67Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
