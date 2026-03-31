// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.QuantityNominalValue2Choice
{
    /// <summary>
    /// Total nominal amount of bonds (number of bonds multiplied by the face value).
    /// </summary>
    [IsoId("_b3cSo8pbEem6kd3Y9uIDqg")]
    [DisplayName("Nominal Value")]
    [IsoXmlTag("NmnlVal")]
    public record NominalValue : QuantityNominalValue2Choice_
    {
        /// <summary>
        /// Amount of money that results in an increase (positively signed) or decrease (negatively signed), with specification of the currency.
        /// </summary>
        [IsoId("_sxKFsUDXEeWOL-OsSq2h6w")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

        /// <summary>
        /// Indicates that the amount value is positive or negative.
        /// Usage: When absent, the amount is positive.
        /// </summary>
        [IsoId("_sxKFs0DXEeWOL-OsSq2h6w")]
        [DisplayName("Sign")]
        [IsoXmlTag("Sgn")]
        [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
        public IsoPlusOrMinusIndicator? Sign { get; init; }
    }
}
