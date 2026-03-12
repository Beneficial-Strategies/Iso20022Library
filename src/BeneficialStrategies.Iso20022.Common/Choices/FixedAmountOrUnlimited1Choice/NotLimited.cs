// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FixedAmountOrUnlimited1Choice
{
    /// <summary>
    /// Unlimited amount.
    /// </summary>
    [IsoId("_MA1JsEqBEeKw5sECfP82rg")]
    [DisplayName("Not Limited")]
    public partial record NotLimited : FixedAmountOrUnlimited1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// String of characters equal to UNLIMITED.
        /// </summary>
        [IsoXmlTag("NotLtd")]
        [IsoSimpleType(IsoSimpleType.Unlimited9Text)]
        public required IsoUnlimited9Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
