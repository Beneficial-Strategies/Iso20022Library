// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RejectionReason14FormatChoice
{
    /// <summary>
    /// Standard code to specify the reason of a rejection of a movement cancellation request.
    /// </summary>
    [IsoId("_RoMq5tp-Ed-ak6NoX_4Aeg_345150396")]
    [DisplayName("Code")]
    public partial record Code : RejectionReason14FormatChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason of a rejection of a movement cancellation request.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason14Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
