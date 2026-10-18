// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AmountType3Choice
{
    /// <inheritdoc cref="IEquivalentAmount"/>
    [IsoId("_P57LMtp-Ed-ak6NoX_4Aeg_326235198")]
    [DisplayName("Equivalent Amount")]
    [IsoXmlTag("EqvtAmt")]
    public partial record EquivalentAmount : AmountType3Choice_
    {
        /// <inheritdoc cref="IEquivalentAmount.Amount"/>
        [IsoId("_P57LNNp-Ed-ak6NoX_4Aeg_853564730")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

        /// <inheritdoc cref="IEquivalentAmount.CurrencyOfTransfer"/>
        [IsoId("_P57LNdp-Ed-ak6NoX_4Aeg_853564760")]
        [DisplayName("Currency Of Transfer")]
        [IsoXmlTag("CcyOfTrf")]
        public required ActiveOrHistoricCurrencyCode CurrencyOfTransfer { get; init; }
    }
}
