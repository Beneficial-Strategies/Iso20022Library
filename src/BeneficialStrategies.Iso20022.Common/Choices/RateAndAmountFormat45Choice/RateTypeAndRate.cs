// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat45Choice
{
    /// <summary>
    /// Value is expressed as a rate type and a percentage rate.
    /// </summary>
    [IsoId("_cj-HbZKQEeWHWpTQn1FFVg")]
    [DisplayName("Rate Type And Rate")]
    public partial record RateTypeAndRate : RateAndAmountFormat45Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Value expressed as a rate type.
        /// </summary>
        [IsoId("_cj-t95KQEeWHWpTQn1FFVg")]
        [DisplayName("Rate Type")]
        [IsoXmlTag("RateTp")]
        public required RateType46Choice_ RateType { get; init; } 
        
        /// <summary>
        /// Value expressed as a rate.
        /// </summary>
        [IsoId("_cj-t-ZKQEeWHWpTQn1FFVg")]
        [DisplayName("Rate")]
        [IsoXmlTag("Rate")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        public required IsoPercentageRate Rate { get; init; } 
        
        
        #nullable disable
        
    }
}
