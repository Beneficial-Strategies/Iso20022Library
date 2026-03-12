// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AllegementReason2Choice
{
    /// <summary>
    /// Specifies the reason why the instruction has been alleged.
    /// </summary>
    [IsoId("_3m3kwQd3Ee2fOITqoTnSLQ")]
    [DisplayName("Code")]
    public partial record Code : AllegementReason2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why the instruction has an allegement status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AllegementReason1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
