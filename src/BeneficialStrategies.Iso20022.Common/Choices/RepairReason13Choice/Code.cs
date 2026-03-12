// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RepairReason13Choice
{
    /// <summary>
    /// Specifies the reason why the instruction/request has a repair or rejection status.
    /// </summary>
    [IsoId("_6BHQZZNLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public partial record Code : RepairReason13Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why the securities financing instruction has a repair status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RepairReason5Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
