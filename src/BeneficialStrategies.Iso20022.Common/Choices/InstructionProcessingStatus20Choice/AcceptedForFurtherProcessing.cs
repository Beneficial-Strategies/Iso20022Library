// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus20Choice
{
    /// <summary>
    /// Provides status information related to an instruction request that is accepted. This means that the instruction has been received, is processable and has been validated for further processing.
    /// </summary>
    [IsoId("_inrWu1hYEeSewsfsZR0hxA")]
    [DisplayName("Accepted For Further Processing")]
    public partial record AcceptedForFurtherProcessing : InstructionProcessingStatus20Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
