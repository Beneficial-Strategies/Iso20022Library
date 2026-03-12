// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RatioFormat20Choice
{
    /// <summary>
    /// Ratio expressed as a quotient of quantities.
    /// </summary>
    [IsoId("_DWMWpUGNEeWqy4niLuXETA")]
    [DisplayName("Quantity To Quantity")]
    public partial record QuantityToQuantity : RatioFormat20Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Numerator of the quotient of quantities.
        /// </summary>
        [IsoId("_UMtPANp-Ed-ak6NoX_4Aeg_110025386")]
        [DisplayName("Quantity")]
        [IsoXmlTag("Qty1")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        public required IsoDecimalNumber Quantity1 { get; init; } 
        
        /// <summary>
        /// Denominator of the quotient of quantities.
        /// </summary>
        [IsoId("_UMtPAdp-Ed-ak6NoX_4Aeg_154352706")]
        [DisplayName("Quantity")]
        [IsoXmlTag("Qty2")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        public required IsoDecimalNumber Quantity2 { get; init; } 
        
        
        #nullable disable
        
    }
}
