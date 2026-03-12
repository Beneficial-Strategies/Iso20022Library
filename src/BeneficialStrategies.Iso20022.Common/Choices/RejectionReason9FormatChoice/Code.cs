// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RejectionReason9FormatChoice
{
    /// <summary>
    /// Standard code to specify the reason of a rejection of an election cancellation request.
    /// </summary>
    [IsoId("_Roovxtp-Ed-ak6NoX_4Aeg_287891087")]
    [DisplayName("Code")]
    public partial record Code : RejectionReason9FormatChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason of a rejection of an election cancellation request.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason9Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
