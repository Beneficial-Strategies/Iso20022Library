// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RatioFormat24Choice
{
    /// <summary>
    /// Ratio expressed as a quantity to amount ratio.
    /// </summary>
    [IsoId("_ctjgv5KQEeWHWpTQn1FFVg")]
    [DisplayName("Quantity To Amount")]
    public partial record QuantityToAmount : RatioFormat24Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Cash amount.
        /// </summary>
        [IsoId("_ckCYlJKQEeWHWpTQn1FFVg")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required RestrictedFINActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
        
        /// <summary>
        /// Quantity expressed as number.
        /// </summary>
        [IsoId("_ckCYnJKQEeWHWpTQn1FFVg")]
        [DisplayName("Quantity")]
        [IsoXmlTag("Qty")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINDecimalNumber)]
        public required IsoRestrictedFINDecimalNumber Quantity { get; init; } 
        
        
        #nullable disable
        
    }
}
