// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ChargePaymentMethod1Choice
{
    /// <summary>
    /// Charge payment method expressed as a code.
    /// </summary>
    [IsoId("_8BZF4BXxEeOBE-jZfcm4KQ")]
    [DisplayName("Code")]
    public partial record Code : ChargePaymentMethod1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies how expenses are paid.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ChargePaymentMethod1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
