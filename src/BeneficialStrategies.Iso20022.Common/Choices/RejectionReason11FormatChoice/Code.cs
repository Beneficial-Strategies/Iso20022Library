// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RejectionReason11FormatChoice
{
    /// <summary>
    /// Standard code to specify the reason of a rejection of the notification cancellation request.
    /// </summary>
    [IsoId("_RoC55dp-Ed-ak6NoX_4Aeg_313748819")]
    [DisplayName("Code")]
    public partial record Code : RejectionReason11FormatChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason of a rejection of the notification cancellation request.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason11Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
