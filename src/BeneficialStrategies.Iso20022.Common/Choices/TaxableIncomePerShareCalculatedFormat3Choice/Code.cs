// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TaxableIncomePerShareCalculatedFormat3Choice
{
    /// <summary>
    /// Standard code to specify whether the fund calculates the taxable income per dividend/taxable income per share (TID/TIS).
    /// </summary>
    [IsoId("_RmsUIUEGEeWVgfuHGaKtRQ")]
    [DisplayName("Code")]
    public record Code : TaxableIncomePerShareCalculatedFormat3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether the fund calculates the taxable income per dividend/taxable income per share (TID/TIS).
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionTaxableIncomePerShareCalculated1Code Value { get; init; }
    }
}
