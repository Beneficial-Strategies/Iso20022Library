// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReferredDocumentAmount1Choice
{
    /// <inheritdoc cref="IDiscountAppliedAmount"/>
    [IsoId("_QGJCRNp-Ed-ak6NoX_4Aeg_-888106465")]
    [DisplayName("Discount Applied Amount")]
    [IsoXmlTag("DscntApldAmt")]
    public partial record DiscountAppliedAmount : ReferredDocumentAmount1Choice_
    {
        /// <inheritdoc cref="IDiscountAppliedAmount.Currency"/>
        [IsoId("_YXSZF9p-Ed-ak6NoX_4Aeg_-1352517078_Currency")]
        [DisplayName("Currency And Amount _ Currency")]
        [IsoXmlTag("Currency")]
        public required CurrencyCode Currency { get; init; }

        /// <inheritdoc cref="IDiscountAppliedAmount.Amount"/>
        [IsoId("_YXSZF9p-Ed-ak6NoX_4Aeg_-1352517078_Amount")]
        [DisplayName("Currency And Amount _ Amount")]
        [IsoXmlTag("Amount")]
        public required decimal Amount { get; init; }
    }
}
