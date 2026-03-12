// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CommissionBasis1Choice
{
    /// <summary>
    /// Commission basis expressed as a code.
    /// </summary>
    [IsoId("_Xab8kBuCEeOqSdXzJ0oydA")]
    [DisplayName("Code")]
    public partial record Code : CommissionBasis1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the tax basis.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TaxationBasis4Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
