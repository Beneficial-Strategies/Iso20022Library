// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice17Choice
{
    /// <summary>
    /// Indicates that price is expressed as a monetary value.
    /// </summary>
    [IsoId("_gSTIgZjcEeqkLZLH6DK3UQ")]
    [DisplayName("Monetary Value")]
    public record MonetaryValue : SecuritiesTransactionPrice17Choice_
    {
        /// <summary>
        /// Amount of money in the cash entry.
        /// </summary>
        [IsoId("_qezOMZjbEeqkLZLH6DK3UQ")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveOrHistoricCurrencyAnd19DecimalAmount Amount { get; init; }

        /// <summary>
        /// Indicates that the amount value is positive or negative.
        /// </summary>
        [IsoId("_qezOM5jbEeqkLZLH6DK3UQ")]
        [DisplayName("Sign")]
        [IsoXmlTag("Sgn")]
        [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
        public IsoPlusOrMinusIndicator? Sign { get; init; }
    }
}
