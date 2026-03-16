// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice3Choice
{
    /// <summary>
    /// Indicates that price is expressed as a monetary value.
    /// </summary>
    [IsoId("_rdXYAUDWEeWOL-OsSq2h6w")]
    [DisplayName("Monetary Value")]
    public record MonetaryValue : SecuritiesTransactionPrice3Choice_
    {
        /// <summary>
        /// Amount of money that results in an increase (positively signed) or decrease (negatively signed), with specification of the currency.
        /// </summary>
        [IsoId("_eRQj4eaqEeW1iL_FRZt8bg")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ImpliedCurrencyAnd20Amount Amount { get; init; }

        /// <summary>
        /// Indicates that the amount value is positive or negative.
        /// Usage: When absent, the amount is positive.
        /// </summary>
        [IsoId("_eRQj4-aqEeW1iL_FRZt8bg")]
        [DisplayName("Sign")]
        [IsoXmlTag("Sgn")]
        [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
        public IsoPlusOrMinusIndicator? Sign { get; init; }
    }
}
