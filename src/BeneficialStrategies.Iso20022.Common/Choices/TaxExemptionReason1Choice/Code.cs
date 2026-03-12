// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TaxExemptionReason1Choice
{
    /// <summary>
    /// Tax exemption reason expressed as a code.
    /// </summary>
    [IsoId("_0qVdABc-EeK5g-3oYI0_9Q")]
    [DisplayName("Code")]
    public partial record Code : TaxExemptionReason1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason a specific tax has not been levied/deducted on a given transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TaxExemptReason1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
