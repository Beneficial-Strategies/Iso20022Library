// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AmountOrRate1Choice
{
    /// <inheritdoc cref="IAmount"/>
    [IsoId("_Q-Uncdp-Ed-ak6NoX_4Aeg_512767945")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public partial record Amount : AmountOrRate1Choice_
    {
        /// <inheritdoc cref="IAmount.Currency"/>
        [IsoId("_YX4O9tp-Ed-ak6NoX_4Aeg_-836081793_Currency")]
        [DisplayName("Active Currency And Amount _ Currency")]
        [IsoXmlTag("Currency")]
        public required ActiveCurrencyCode Currency { get; init; }

        /// <inheritdoc cref="IAmount.Value"/>
        [IsoXmlTag("Amount")]
        public required decimal Value { get; init; }
    }
}
