// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus47Choice
{
    /// <summary>
    /// Cancellation instruction is pending.
    /// </summary>
    [IsoId("_KVKx9Rn1EeyroI8qKgB7Mg")]
    [DisplayName("Pending Cancellation")]
    public partial record PendingCancellation : InstructionProcessingStatus47Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
