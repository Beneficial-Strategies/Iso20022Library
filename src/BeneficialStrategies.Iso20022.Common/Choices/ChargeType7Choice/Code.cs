// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ChargeType7Choice
{
    /// <summary>
    /// Cost or charge expressed as a code.
    /// </summary>
    [IsoId("_zDuYMDcnEeidBoT_PugKiA")]
    [DisplayName("Code")]
    public partial record Code : ChargeType7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of cost or charge.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InvestmentFundMiFIDFee1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
