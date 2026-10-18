// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AmountType4Choice
{
    /// <inheritdoc cref="IInstructedAmount"/>
    [IsoId("__k-HA1kJEeSeLKjZh_lWZw")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public partial record InstructedAmount : AmountType4Choice_
    {
        /// <inheritdoc cref="IInstructedAmount.Currency"/>
        [IsoId("_YYB_9tp-Ed-ak6NoX_4Aeg_-1587763373_Currency")]
        [DisplayName("Active Or Historic Currency And Amount _ Currency")]
        [IsoXmlTag("Currency")]
        public required ActiveOrHistoricCurrencyCode Currency { get; init; }

        /// <inheritdoc cref="IInstructedAmount.Amount"/>
        [IsoId("_YYB_9tp-Ed-ak6NoX_4Aeg_-1587763373_Amount")]
        [DisplayName("Active Or Historic Currency And Amount _ Amount")]
        [IsoXmlTag("Amount")]
        public required decimal Amount { get; init; }
    }
}
