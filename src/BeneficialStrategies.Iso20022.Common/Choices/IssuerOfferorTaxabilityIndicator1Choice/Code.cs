// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.IssuerOfferorTaxabilityIndicator1Choice
{
    /// <summary>
    /// Standard code to specify information regarding the issuer / offeror taxability status.
    /// </summary>
    [IsoId("_dw_XMIlzEeavwKddCbm3hg")]
    [DisplayName("Code")]
    public partial record Code : IssuerOfferorTaxabilityIndicator1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether the corporate action proceeds are taxable at issuer level.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required IssuerTaxability2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
