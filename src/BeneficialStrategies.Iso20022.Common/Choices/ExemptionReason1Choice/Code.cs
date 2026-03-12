// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ExemptionReason1Choice
{
    /// <summary>
    /// Exemption reason expressed as a code.
    /// </summary>
    [IsoId("_loHfEBuJEeOqSdXzJ0oydA")]
    [DisplayName("Code")]
    public partial record Code : ExemptionReason1Choice_
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
