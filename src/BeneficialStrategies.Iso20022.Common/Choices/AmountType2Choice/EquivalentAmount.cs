// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AmountType2Choice
{
    /// <inheritdoc cref="IEquivalentAmount"/>
    [IsoId("_Pxu4jtp-Ed-ak6NoX_4Aeg_-1148058938")]
    [DisplayName("Equivalent Amount")]
    [IsoXmlTag("EqvtAmt")]
    public partial record EquivalentAmount : AmountType2Choice_
    {
        /// <inheritdoc cref="IEquivalentAmount.Amount"/>
        [IsoId("_PrBzkdp-Ed-ak6NoX_4Aeg_-1963000912")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required CurrencyAndAmount Amount { get; init; }

        /// <inheritdoc cref="IEquivalentAmount.CurrencyOfTransfer"/>
        [IsoId("_PrBzktp-Ed-ak6NoX_4Aeg_1183764992")]
        [DisplayName("Currency Of Transfer")]
        [IsoXmlTag("CcyOfTrf")]
        public required CurrencyCode CurrencyOfTransfer { get; init; }
    }
}
