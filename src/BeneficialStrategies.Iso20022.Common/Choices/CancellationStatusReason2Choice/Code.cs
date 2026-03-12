// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CancellationStatusReason2Choice
{
    /// <summary>
    /// Reason for the cancellation status, in a coded form.
    /// </summary>
    [IsoId("_t4cl8FkyEeGeoaLUQk__nA_-347557160")]
    [DisplayName("Code")]
    public partial record Code : CancellationStatusReason2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Returned when a request for cancellation cannot be executed.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PaymentCancellationRejection2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
