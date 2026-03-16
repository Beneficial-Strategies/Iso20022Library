// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AmountType1Choice
{
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.||Usage: Currency of the amount is expressed in the currency (or one of the currencies) of the debtor&apos;s account or another currency, eg, pay 1000000 EUR (and debtor&apos;s account is is EUR) or pay 1000000 JPY (and debtor&apos;s account is in EUR).
    /// </summary>
    [IsoId("_PrUuh9p-Ed-ak6NoX_4Aeg_-1289727793")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public record InstructedAmount : AmountType1Choice_
    {
        /// <summary>
        /// The currency in which this amount is measured.
        /// </summary>
        [IsoId("_YXSZF9p-Ed-ak6NoX_4Aeg_-1352517078_Currency")]
        [DisplayName("Currency And Amount _ Currency")]
        [IsoXmlTag("Currency")]
        public required System.String Currency { get; init; }

        /// <summary>
        /// Amount of the transaction.
        /// </summary>
        [IsoId("_YXSZF9p-Ed-ak6NoX_4Aeg_-1352517078_Amount")]
        [DisplayName("Currency And Amount _ Amount")]
        [IsoXmlTag("Amount")]
        public required System.Decimal Amount { get; init; }
    }
}
