// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice19Choice
{
    /// <summary>
    /// Price expressed as a monetary value.
    /// </summary>
    [IsoId("_fx9HMMgqEeuGrNSsxk3B0A")]
    [DisplayName("Monetary Value")]
    public record MonetaryValue : SecuritiesTransactionPrice19Choice_
    {
        /// <summary>
        /// Amount of money in the cash entry.
        /// </summary>
        [IsoId("_XYj_4Mz3EeufhKfUxzsnrQ")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveOrHistoricCurrencyAnd20DecimalAmount Amount { get; init; }

        /// <summary>
        /// Indicates that the amount value is positive or negative.
        /// </summary>
        [IsoId("_ZY5f8Mz3EeufhKfUxzsnrQ")]
        [DisplayName("Sign")]
        [IsoXmlTag("Sgn")]
        [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
        public IsoPlusOrMinusIndicator? Sign { get; init; }
    }
}
