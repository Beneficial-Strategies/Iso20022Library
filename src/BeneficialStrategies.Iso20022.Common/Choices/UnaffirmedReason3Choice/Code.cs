// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UnaffirmedReason3Choice
{
    /// <summary>
    /// Specifies the reason why the instruction/request has an unaffirmed status.
    /// </summary>
    [IsoId("_XiELgQd3Ee2fOITqoTnSLQ")]
    [DisplayName("Code")]
    public partial record Code : UnaffirmedReason3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason the transaction, transfer or settlement instruction is unaffirmed.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required UnaffirmedReason1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
