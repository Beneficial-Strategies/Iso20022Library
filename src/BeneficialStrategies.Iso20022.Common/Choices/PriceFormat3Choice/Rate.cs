// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PriceFormat3Choice
{
    /// <summary>
    /// Price expressed as a rate, ie, percentage.
    /// </summary>
    [IsoId("_Qa2uBNp-Ed-ak6NoX_4Aeg_-696145792")]
    [DisplayName("Rate")]
    public partial record Rate : PriceFormat3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Type of rate, eg, yield.
        /// </summary>
        [IsoId("_Qa2uBtp-Ed-ak6NoX_4Aeg_112748166")]
        [DisplayName("Rate Type")]
        [IsoXmlTag("RateTp")]
        public required PriceRateType3FormatChoice_ RateType { get; init; } 
        
        /// <summary>
        /// Price expressed as a rate, ie, percentage.
        /// </summary>
        [IsoXmlTag("Rate")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        public required IsoPercentageRate Value { get; init; } 
        
        
        #nullable disable
        
    }
}
