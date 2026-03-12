// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat40Choice
{
    /// <summary>
    /// Value is expressed as a rate type and a percentage rate.
    /// </summary>
    [IsoId("__Q79hUEIEeWVgfuHGaKtRQ")]
    [DisplayName("Rate Type And Rate")]
    public partial record RateTypeAndRate : RateAndAmountFormat40Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Value expressed as a rate type.
        /// </summary>
        [IsoId("__c_ccUEIEeWVgfuHGaKtRQ")]
        [DisplayName("Rate Type")]
        [IsoXmlTag("RateTp")]
        public required RateType42Choice_ RateType { get; init; } 
        
        /// <summary>
        /// Value expressed as a rate.
        /// </summary>
        [IsoId("__c_cc0EIEeWVgfuHGaKtRQ")]
        [DisplayName("Rate")]
        [IsoXmlTag("Rate")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        public required IsoPercentageRate Rate { get; init; } 
        
        
        #nullable disable
        
    }
}
