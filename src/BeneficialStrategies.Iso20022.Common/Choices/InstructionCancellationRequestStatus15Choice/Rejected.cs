// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionCancellationRequestStatus15Choice
{
    /// <summary>
    /// Provides status information related to a cancellation request rejected for further processing due to system (data) reasons.
    /// </summary>
    [IsoId("_oj4IszQXEe2o-K1dwNg8Gg")]
    [DisplayName("Rejected")]
    public partial record Rejected : InstructionCancellationRequestStatus15Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
