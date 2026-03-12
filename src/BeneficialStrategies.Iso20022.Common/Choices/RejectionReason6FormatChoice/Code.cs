// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RejectionReason6FormatChoice
{
    /// <summary>
    /// Standard code to specify the reason of a rejection of the notification advice.
    /// </summary>
    [IsoId("_Rofl1tp-Ed-ak6NoX_4Aeg_234326718")]
    [DisplayName("Code")]
    public partial record Code : RejectionReason6FormatChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason of a rejection of the notification advice.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason6Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
