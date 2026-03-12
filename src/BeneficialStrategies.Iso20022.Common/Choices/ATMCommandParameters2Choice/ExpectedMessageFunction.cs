// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ATMCommandParameters2Choice
{
    /// <summary>
    /// Message to send for the send message command.
    /// </summary>
    [IsoId("_qAYfs4tHEeSxlKlAGYErFg")]
    [DisplayName("Expected Message Function")]
    public partial record ExpectedMessageFunction : ATMCommandParameters2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Identifies the type of process requested by the host to an ATM.
        /// </summary>
        [IsoXmlTag("XpctdMsgFctn")]
        public required MessageFunction8Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
