// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CompensationReason1Choice
{
    /// <summary>
    /// Reason for the payment compensation, in a coded form.
    /// </summary>
    [IsoId("_a-QKsIjYEeeDW7_wB-eK_g")]
    [DisplayName("Code")]
    public partial record Code : CompensationReason1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for compensation for the processing of a payment, as published in an external code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalPaymentCompensationReason1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
