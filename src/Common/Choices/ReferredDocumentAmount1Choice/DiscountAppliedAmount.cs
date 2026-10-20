// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReferredDocumentAmount1Choice
{
    /// <summary>
    /// Amount of money that results from the application of an agreed discount to the amount due and payable to the creditor.
    /// </summary>
    [IsoId("_QGJCRNp-Ed-ak6NoX_4Aeg_-888106465")]
    [DisplayName("Discount Applied Amount")]
    [IsoXmlTag("DscntApldAmt")]
    public partial record DiscountAppliedAmount : ReferredDocumentAmount1Choice_
    {
        /// <summary>
        /// The currency in which this amount is measured.
        /// </summary>
        [IsoId("_YXSZF9p-Ed-ak6NoX_4Aeg_-1352517078_Currency")]
        [DisplayName("Currency And Amount _ Currency")]
        [IsoXmlTag("Currency")]
        public required CurrencyCode Currency { get; init; }

        /// <summary>
        /// Amount of the transaction.
        /// </summary>
        [IsoId("_YXSZF9p-Ed-ak6NoX_4Aeg_-1352517078_Amount")]
        [DisplayName("Currency And Amount _ Amount")]
        [IsoXmlTag("Amount")]
        [IsoAmount(18, 5)]
        public required decimal Amount
        {
            get => _amount;
            init => _amount = IsoAmountFacets.Check(typeof(DiscountAppliedAmount), nameof(Amount), value);
        }

        private decimal _amount;
    }
}
