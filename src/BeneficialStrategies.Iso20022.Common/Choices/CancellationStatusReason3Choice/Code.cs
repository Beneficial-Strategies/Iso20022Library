// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CancellationStatusReason3Choice
{
    /// <summary>
    /// Reason for the cancellation status, in a coded form.
    /// </summary>
    [IsoId("_sx1XQ4lrEeePr-EGJjGYzQ")]
    [DisplayName("Code")]
    public partial record Code : CancellationStatusReason3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for the rejection of a cancellation, as published in an external payment cancellation rejection code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalPaymentCancellationRejection1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
