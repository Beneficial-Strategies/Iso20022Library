// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity28Choice
{
    /// <summary>
    /// Amount of money to be redeemed from the fund.
    /// Gross Amount = Quantity * Price.
    /// </summary>
    [IsoId("_ZipfAzhUEeaRwdGFv45qTQ")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public partial record GrossAmount : FinancialInstrumentQuantity28Choice_
    {
        /// <summary>
        /// The currency in which this amount is measured.
        /// </summary>
        [IsoId("_YYB_9tp-Ed-ak6NoX_4Aeg_-1587763373_Currency")]
        [DisplayName("Active Or Historic Currency And Amount _ Currency")]
        [IsoXmlTag("Currency")]
        public required ActiveOrHistoricCurrencyCode Currency { get; init; }

        /// <summary>
        /// Amount of the transaction.
        /// </summary>
        [IsoId("_YYB_9tp-Ed-ak6NoX_4Aeg_-1587763373_Amount")]
        [DisplayName("Active Or Historic Currency And Amount _ Amount")]
        [IsoXmlTag("Amount")]
        [IsoAmount(18, 5)]
        public required decimal Amount
        {
            get => _amount;
            init => _amount = IsoAmountFacets.Check(typeof(GrossAmount), nameof(Amount), value);
        }

        private decimal _amount;
    }
}
