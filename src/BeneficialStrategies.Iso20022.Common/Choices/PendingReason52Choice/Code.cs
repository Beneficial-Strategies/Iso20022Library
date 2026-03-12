// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PendingReason52Choice
{
    /// <summary>
    /// Specifies the reason code why the instruction or request is pending expressed as a code.
    /// </summary>
    [IsoId("_4IuRIOBiEeiVRbNQx5-Vhg")]
    [DisplayName("Code")]
    public partial record Code : PendingReason52Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why the transaction or the instruction has a pending status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PendingReason17Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
