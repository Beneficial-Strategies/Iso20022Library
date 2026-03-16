// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice10Choice
{
    /// <summary>
    /// Indicates that price is expressed as a monetary value.
    /// </summary>
    [IsoId("_QtL74f9iEea3W_f2lS_aiw")]
    [DisplayName("Monetary Value")]
    [IsoXmlTag("MntryVal")]
    public record MonetaryValue : SecuritiesTransactionPrice10Choice_
    {
        /// <summary>
        /// Amount of money that results in an increase (positively signed) or decrease (negatively signed), with specification of the currency.
        /// </summary>
        [IsoId("_qosZ0UDWEeWOL-OsSq2h6w")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveOrHistoricCurrencyAnd20Amount Amount { get; init; }

        /// <summary>
        /// Indicates that the amount value is positive or negative.
        /// Usage: When absent, the amount is positive.
        /// </summary>
        [IsoId("_qosZ00DWEeWOL-OsSq2h6w")]
        [DisplayName("Sign")]
        [IsoXmlTag("Sgn")]
        [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
        public IsoPlusOrMinusIndicator? Sign { get; init; }
    }
}
