// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice2Choice
{
    /// <summary>
    /// Price expressed as a monetary value.
    /// </summary>
    [IsoId("_xZe0tyZJEeWbypuCUIOnzw")]
    [DisplayName("Monetary Value")]
    public record MonetaryValue : SecuritiesTransactionPrice2Choice_
    {
        /// <summary>
        /// Amount of money that results in an increase (positively signed) or decrease (negatively signed), with specification of the currency.
        /// </summary>
        [IsoId("_uJWuUWdQEeW24ZX8kd8oLA")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }

        /// <summary>
        /// Indicates that the amount value is positive or negative.
        /// </summary>
        [IsoId("_uJWuU2dQEeW24ZX8kd8oLA")]
        [DisplayName("Sign")]
        [IsoXmlTag("Sgn")]
        [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
        public IsoPlusOrMinusIndicator? Sign { get; init; }
    }
}
