// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AmountType4Choice
{
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, expressed in the currency of the debtor&apos;s account, and the currency in which the amount is to be moved.
    /// </summary>
    [IsoId("__k-HBVkJEeSeLKjZh_lWZw")]
    [DisplayName("Equivalent Amount")]
    public record EquivalentAmount : AmountType4Choice_
    {
        /// <summary>
        /// Amount of money to be moved between debtor and creditor, before deduction of charges, expressed in the currency of the debtor&apos;s account, and to be moved in a different currency.|Usage: The first agent will convert the equivalent amount into the amount to be moved.
        /// </summary>
        [IsoId("_P57LNNp-Ed-ak6NoX_4Aeg_853564730")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

        /// <summary>
        /// Specifies the currency of the to be transferred amount, which is different from the currency of the debtor&apos;s account.
        /// </summary>
        [IsoId("_P57LNdp-Ed-ak6NoX_4Aeg_853564760")]
        [DisplayName("Currency Of Transfer")]
        [IsoXmlTag("CcyOfTrf")]
        public required ActiveOrHistoricCurrencyCode CurrencyOfTransfer { get; init; }
    }
}
