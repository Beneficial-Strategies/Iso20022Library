// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.IntraPositionProcessingStatus6Choice
{
    /// <summary>
    /// Instruction/Request has been rejected for further processing.
    /// </summary>
    [IsoId("_5SFARZNLEeWGlc8L7oPDIg")]
    [DisplayName("Rejected")]
    public partial record Rejected : IntraPositionProcessingStatus6Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
