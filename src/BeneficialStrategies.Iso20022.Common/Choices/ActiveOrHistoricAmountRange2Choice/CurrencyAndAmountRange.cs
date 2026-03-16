// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ActiveOrHistoricAmountRange2Choice
{
    /// <summary>
    /// Expresses an amount or an amount range with the currency and where the credit/debit indicator is explicit.
    /// </summary>
    [IsoId("_PPV2VZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Currency And Amount Range")]
    public record CurrencyAndAmountRange : ActiveOrHistoricAmountRange2Choice_
    {
        /// <summary>
        /// Specified amount or amount range.
        /// </summary>
        [IsoId("_PXu9U5lcEeeE1Ya-LgRsuQ")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ImpliedCurrencyAmountRange1Choice_ Amount { get; init; }

        /// <summary>
        /// Indicates whether the amount is a credited or debited amount.
        /// </summary>
        [IsoId("_PXu9VZlcEeeE1Ya-LgRsuQ")]
        [DisplayName("Credit Debit Indicator")]
        [IsoXmlTag("CdtDbtInd")]
        public CreditDebitCode? CreditDebitIndicator { get; init; }

        /// <summary>
        /// Medium of exchange of value, used to qualify an amount.
        /// </summary>
        [IsoId("_PXu9V5lcEeeE1Ya-LgRsuQ")]
        [DisplayName("Currency")]
        [IsoXmlTag("Ccy")]
        public required ActiveOrHistoricCurrencyCode Currency { get; init; }
    }
}
