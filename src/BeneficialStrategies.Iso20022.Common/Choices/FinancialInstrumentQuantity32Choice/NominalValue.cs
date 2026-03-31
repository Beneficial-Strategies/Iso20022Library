// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity32Choice
{
    /// <summary>
    /// Indicates that quantity is expressed as a nominal value.
    /// </summary>
    [IsoId("_Y7YBdZjgEeqkLZLH6DK3UQ")]
    [DisplayName("Nominal Value")]
    [IsoXmlTag("NmnlVal")]
    public record NominalValue : FinancialInstrumentQuantity32Choice_
    {
        /// <summary>
        /// The currency in which this amount is measured.
        /// </summary>
        [IsoId("_A6FBE5jfEeqkLZLH6DK3UQ_Currency")]
        [DisplayName("Active Or Historic Currency And 19 Decimal Amount _ Currency")]
        [IsoXmlTag("Currency")]
        public required System.String Currency { get; init; }

        /// <summary>
        /// Amount of the transaction.
        /// </summary>
        [IsoId("_A6FBE5jfEeqkLZLH6DK3UQ_Amount")]
        [DisplayName("Active Or Historic Currency And 19 Decimal Amount _ Amount")]
        [IsoXmlTag("Amount")]
        public required System.Decimal Amount { get; init; }
    }
}
