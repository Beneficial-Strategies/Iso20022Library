// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CancellationStatusReason1Choice
{
    /// <summary>
    /// Reason for the cancellation status, in a coded form.
    /// </summary>
    [IsoId("_TPwemNp-Ed-ak6NoX_4Aeg_1784056925")]
    [DisplayName("Code")]
    public partial record Code : CancellationStatusReason1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Returned when a request for cancellation cannot be executed.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PaymentCancellationRejection1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
