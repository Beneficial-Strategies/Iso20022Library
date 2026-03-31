// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProfitAndLoss1Choice
{
    /// <summary>
    /// Value of the negative amount.
    /// </summary>
    [IsoId("_Q65gCtp-Ed-ak6NoX_4Aeg_-802663966")]
    [DisplayName("Loss")]
    [IsoXmlTag("Loss")]
    public record Loss : ProfitAndLoss1Choice_
    {
        /// <summary>
        /// The currency in which this amount is measured.
        /// </summary>
        [IsoId("_YX4O9Np-Ed-ak6NoX_4Aeg_-184934550_Currency")]
        [DisplayName("Active Currency And 13 Decimal Amount _ Currency")]
        [IsoXmlTag("Currency")]
        public required System.String Currency { get; init; }

        /// <summary>
        /// Amount of the transaction.
        /// </summary>
        [IsoId("_YX4O9Np-Ed-ak6NoX_4Aeg_-184934550_Amount")]
        [DisplayName("Active Currency And 13 Decimal Amount _ Amount")]
        [IsoXmlTag("Amount")]
        public required System.Decimal Amount { get; init; }
    }
}
