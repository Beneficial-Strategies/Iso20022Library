// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AmountType1Choice
{
    /// <summary>
    /// Amount of money to be transferred between the debtor and creditor, before deduction of charges, expressed in the currency of the debtor&apos;s account, and to be transferred into a different currency. ||Usage: Currency of the amount is expressed in the currency of the debtor&apos;s account, but the amount to be transferred is in another currency. The debtor agent will convert the amount and currency to the to be transferred amount and currency, eg, &apos;pay equivalent of 100000 EUR in JPY&apos;(and account is in EUR).
    /// </summary>
    [IsoId("_Prd4cNp-Ed-ak6NoX_4Aeg_1273347022")]
    [DisplayName("Equivalent Amount")]
    public record EquivalentAmount : AmountType1Choice_
    {
        /// <summary>
        /// Amount of money to be transferred between debtor and creditor, before deduction of charges, expressed in the currency of the debtor&apos;s account, and to be transferred in a different currency. ||Usage: Currency of the amount is expressed in the currency of the debtor&apos;s account, but the amount to be transferred is in another currency. The first agent will convert the amount and currency to the to be transferred amount and currency, eg, &apos;pay equivalent of 100000 EUR in JPY&apos;(and account is in EUR).
        /// </summary>
        [IsoId("_PrBzkdp-Ed-ak6NoX_4Aeg_-1963000912")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required CurrencyAndAmount Amount { get; init; }

        /// <summary>
        /// Specifies the currency of the to be transferred amount, which is different from the currency of the debtor&apos;s account.
        /// </summary>
        [IsoId("_PrBzktp-Ed-ak6NoX_4Aeg_1183764992")]
        [DisplayName("Currency Of Transfer")]
        [IsoXmlTag("CcyOfTrf")]
        public required CurrencyCode CurrencyOfTransfer { get; init; }
    }
}
