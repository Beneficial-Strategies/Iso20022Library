// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ImpliedCurrencyAmountRangeChoice
{
    /// <summary>
    /// Range of valid amount values.
    /// </summary>
    [IsoId("_PVH1ANp-Ed-ak6NoX_4Aeg_-1220232112")]
    [DisplayName("From To Amount")]
    [IsoXmlTag("FrToAmt")]
    public record FromToAmount : ImpliedCurrencyAmountRangeChoice_
    {
        /// <summary>
        /// Lower boundary of a range of amount values.
        /// </summary>
        [IsoId("_PVH1BNp-Ed-ak6NoX_4Aeg_-1340961900")]
        [DisplayName("From Amount")]
        [IsoXmlTag("FrAmt")]
        public required AmountRangeBoundary1 FromAmount { get; init; }

        /// <summary>
        /// Upper boundary of a range of amount values.
        /// </summary>
        [IsoId("_PVH1Bdp-Ed-ak6NoX_4Aeg_-1328032668")]
        [DisplayName("To Amount")]
        [IsoXmlTag("ToAmt")]
        public required AmountRangeBoundary1 ToAmount { get; init; }
    }
}
