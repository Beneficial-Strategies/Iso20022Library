// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus72Choice
{
    /// <summary>
    /// Instruction has been completed by the executing party.
    /// </summary>
    [IsoId("_a2nK1-LtEeWOD7aAy2fAcA")]
    [DisplayName("Completed")]
    public partial record Completed : ProcessingStatus72Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the reason of the Status.
        /// </summary>
        [IsoId("_qTYa0eLtEeWOD7aAy2fAcA")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public ProprietaryReason4? Reason { get; init; } 
        
        
        #nullable disable
        
    }
}
