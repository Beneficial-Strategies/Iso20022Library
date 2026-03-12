// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RatioFormat21Choice
{
    /// <summary>
    /// Ratio expressed as a quotient of quantities.
    /// </summary>
    [IsoId("_ckBxuZKQEeWHWpTQn1FFVg")]
    [DisplayName("Quantity To Quantity")]
    public partial record QuantityToQuantity : RatioFormat21Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Numerator of the quotient of quantities.
        /// </summary>
        [IsoId("_WjNMUdp-Ed-ak6NoX_4Aeg_2126904066")]
        [DisplayName("Quantity")]
        [IsoXmlTag("Qty1")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINDecimalNumber)]
        public required IsoRestrictedFINDecimalNumber Quantity1 { get; init; } 
        
        /// <summary>
        /// Denominator of the quotient of quantities.
        /// </summary>
        [IsoId("_WjNMUtp-Ed-ak6NoX_4Aeg_-1402106980")]
        [DisplayName("Quantity")]
        [IsoXmlTag("Qty2")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINDecimalNumber)]
        public required IsoRestrictedFINDecimalNumber Quantity2 { get; init; } 
        
        
        #nullable disable
        
    }
}
