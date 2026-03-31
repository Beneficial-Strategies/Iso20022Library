// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat41Choice
{
    /// <summary>
    /// Value is expressed as a rate type and a percentage rate.
    /// </summary>
    [IsoId("_ACL0TUEJEeWVgfuHGaKtRQ")]
    [DisplayName("Rate Type And Rate")]
    [IsoXmlTag("RateTpAndRate")]
    public record RateTypeAndRate : RateAndAmountFormat41Choice_
    {
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
    }
}
