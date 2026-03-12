// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RejectionReason10FormatChoice
{
    /// <summary>
    /// Standard code to specify the reason of a rejection of a standing instruction cancellation request.
    /// </summary>
    [IsoId("_RoC54tp-Ed-ak6NoX_4Aeg_299898878")]
    [DisplayName("Code")]
    public partial record Code : RejectionReason10FormatChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason of a rejection of a standing instruction cancellation request.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason10Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
