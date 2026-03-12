// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ATMCommandParameters3Choice
{
    /// <summary>
    /// Required status of the ATM, parameters of the status update command.
    /// </summary>
    [IsoId("_htqcMV2aEeekzJIz1JxYSQ")]
    [DisplayName("ATM Required Global Status")]
    public partial record ATMRequiredGlobalStatus : ATMCommandParameters3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Status of the ATM.
        /// </summary>
        [IsoXmlTag("ATMReqrdGblSts")]
        public required ATMStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
