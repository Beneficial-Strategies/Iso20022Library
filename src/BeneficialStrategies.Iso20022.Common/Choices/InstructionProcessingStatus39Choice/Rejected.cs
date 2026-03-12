// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus39Choice
{
    /// <summary>
    /// Provides status information related to an instruction request rejected for further processing due to system reasons.
    /// </summary>
    [IsoId("_Pl7SVAVSEeqjd8n6wD9JVw")]
    [DisplayName("Rejected")]
    public partial record Rejected : InstructionProcessingStatus39Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
