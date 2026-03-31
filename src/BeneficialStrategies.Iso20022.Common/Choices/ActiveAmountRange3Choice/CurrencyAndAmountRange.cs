// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ActiveAmountRange3Choice
{
    /// <summary>
    /// Expresses an amount or an amount range with the currency and where the credit/debit indicator is explicit.
    /// </summary>
    [IsoId("_OvM9tZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Currency And Amount Range")]
    [IsoXmlTag("CcyAndAmtRg")]
    public record CurrencyAndAmountRange : ActiveAmountRange3Choice_
    {
        /// <summary>
        /// Specified amount or amount range.
        /// </summary>
        [IsoId("_PHbQc5lcEeeE1Ya-LgRsuQ")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ImpliedCurrencyAmountRange1Choice_ Amount { get; init; }

        /// <summary>
        /// Indicates whether the amount is a credited or debited amount.
        /// </summary>
        [IsoId("_PHbQdZlcEeeE1Ya-LgRsuQ")]
        [DisplayName("Credit Debit Indicator")]
        [IsoXmlTag("CdtDbtInd")]
        public CreditDebitCode? CreditDebitIndicator { get; init; }

        /// <summary>
        /// Medium of exchange of value, used to qualify an amount.
        /// </summary>
        [IsoId("_PHbQd5lcEeeE1Ya-LgRsuQ")]
        [DisplayName("Currency")]
        [IsoXmlTag("Ccy")]
        public required ActiveCurrencyCode Currency { get; init; }
    }
}
