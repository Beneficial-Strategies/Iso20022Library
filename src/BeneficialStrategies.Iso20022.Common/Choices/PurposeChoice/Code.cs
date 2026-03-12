// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PurposeChoice
{
    /// <summary>
    /// Specifies the type of transaction that resulted in the payment initiation in coded form.
    /// </summary>
    [IsoId("_Rbhg19p-Ed-ak6NoX_4Aeg_-1761336447")]
    [DisplayName("Code")]
    public partial record Code : PurposeChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of transaction that resulted in a payment initiation.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PaymentPurpose1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
