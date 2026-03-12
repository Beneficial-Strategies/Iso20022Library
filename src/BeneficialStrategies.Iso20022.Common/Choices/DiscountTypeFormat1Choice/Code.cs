// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DiscountTypeFormat1Choice
{
    /// <summary>
    /// Standard code to specify the type of discount.
    /// </summary>
    [IsoId("_SumZFgEcEeCQm6a_G2yO_w_1522388026")]
    [DisplayName("Code")]
    public partial record Code : DiscountTypeFormat1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of discount, that is, the reason why a discount is granted.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required DiscountType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
