// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceType1Choice
{
    /// <summary>
    /// Estimated price, for valuation purposes.
    /// </summary>
    [IsoId("_RdnLh9p-Ed-ak6NoX_4Aeg_-352751449")]
    [DisplayName("Indicative")]
    public record Indicative : PriceType1Choice_
    {
        /// <summary>
        /// Specification of the price type.
        /// </summary>
        [IsoId("_QfxqSNp-Ed-ak6NoX_4Aeg_-109280990")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required YieldedOrValueType1Choice_ Type { get; init; }

        /// <summary>
        /// Value of the price, for example, as a currency and value.
        /// </summary>
        [IsoId("_QfxqSdp-Ed-ak6NoX_4Aeg_-371294350")]
        [DisplayName("Value")]
        [IsoXmlTag("Val")]
        public required PriceRateOrAmountChoice_ Value { get; init; }
    }
}
