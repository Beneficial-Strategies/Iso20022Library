// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ChargeType8Choice
{
    /// <summary>
    /// Cost or charge expressed as a code.
    /// </summary>
    [IsoId("_qk_5gZ9BEeqxTNfi5y7ywQ")]
    [DisplayName("Code")]
    public partial record Code : ChargeType8Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of cost or charge.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InvestmentFundMiFIDFee2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
