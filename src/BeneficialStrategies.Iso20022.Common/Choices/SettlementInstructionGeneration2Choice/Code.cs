// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SettlementInstructionGeneration2Choice
{
    /// <summary>
    /// Settlement instruction generation expressed as a ISO20022 code.
    /// </summary>
    [IsoId("_gquKwZCBEeakHoV5BVecAQ")]
    [DisplayName("Code")]
    public partial record Code : SettlementInstructionGeneration2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Settlement Instruction Generation Code.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SettlementInstructionGeneration1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
