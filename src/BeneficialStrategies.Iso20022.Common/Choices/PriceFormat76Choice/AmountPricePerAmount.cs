// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PriceFormat76Choice
{
    /// <summary>
    /// Amount Price Per Amount.
    /// </summary>
    [DisplayName("Amount Price Per Amount")]
    public partial record AmountPricePerAmount : PriceFormat76Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("AmtPricPerAmt")]
        public required AmountPricePerAmount2 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
