// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TaxableIncomePerShareCalculated2Choice
{
    /// <summary>
    /// Taxable income per share (TIS) calculated expressed as a code.
    /// </summary>
    [IsoId("_wmTxcThgEeamLZQeccJa7w")]
    [DisplayName("Code")]
    public record Code : TaxableIncomePerShareCalculated2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether the fund calculates a taxable interest per share (TIS).
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TaxableIncomePerShareCalculated2Code Value { get; init; }
    }
}
