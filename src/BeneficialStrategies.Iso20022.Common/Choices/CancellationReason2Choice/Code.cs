// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CancellationReason2Choice
{
    /// <summary>
    /// Reason for the cancellation request, in a coded form.
    /// </summary>
    [IsoId("_TPmtltp-Ed-ak6NoX_4Aeg_-617774508")]
    [DisplayName("Code")]
    public partial record Code : CancellationReason2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for the request to cancel a payment instruction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CancellationReason4Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
