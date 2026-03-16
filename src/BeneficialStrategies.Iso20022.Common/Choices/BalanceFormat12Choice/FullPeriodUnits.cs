// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BalanceFormat12Choice
{
    /// <summary>
    /// Number of units of a fund that were purchased in a previous distribution period and/or held at the beginning of a distribution period, for example Group I Units in the UK.
    /// </summary>
    [IsoId("_KUd0GRuyEeyhRdHRjakS2w")]
    [DisplayName("Full Period Units")]
    [IsoXmlTag("FullPrdUnits")]
    public record FullPeriodUnits : BalanceFormat12Choice_
    {
        /// <summary>
        /// Sign of the quantity of security.
        /// </summary>
        [IsoId("_Gu-7ERuyEeyhRdHRjakS2w")]
        [DisplayName("Short Long Position")]
        [IsoXmlTag("ShrtLngPos")]
        public required ShortLong1Code ShortLongPosition { get; init; }

        /// <summary>
        /// Quantity of security.
        /// </summary>
        [IsoId("_Gu-7ExuyEeyhRdHRjakS2w")]
        [DisplayName("Quantity")]
        [IsoXmlTag("Qty")]
        public required FinancialInstrumentQuantity33Choice_ Quantity { get; init; }
    }
}
