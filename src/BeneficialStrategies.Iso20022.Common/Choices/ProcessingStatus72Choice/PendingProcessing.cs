// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus72Choice
{
    /// <summary>
    /// Instruction is pendingprocessing by the executing party.
    /// </summary>
    [IsoId("_a2nK0-LtEeWOD7aAy2fAcA")]
    [DisplayName("Pending Processing")]
    public partial record PendingProcessing : ProcessingStatus72Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
