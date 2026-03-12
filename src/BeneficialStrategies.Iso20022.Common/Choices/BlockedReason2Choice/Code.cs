// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BlockedReason2Choice
{
    /// <summary>
    /// Reason expressed as a code.
    /// </summary>
    [IsoId("_P2OO0Vr3Eea4y99eritluQ")]
    [DisplayName("Code")]
    public partial record Code : BlockedReason2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason an account is blocked.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required BlockedReason2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
