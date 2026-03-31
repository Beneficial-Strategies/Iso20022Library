// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantityChoice
{
    /// <summary>
    /// Quantity expressed as a number, eg, a number of shares.
    /// </summary>
    [IsoId("_Sn-F2dp-Ed-ak6NoX_4Aeg_1327975958")]
    [DisplayName("Unit")]
    public record Unit : FinancialInstrumentQuantityChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Number of objects represented as a decimal number, for example 0.75 or 45.6.
        /// </summary>
        [IsoXmlTag("Unit")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        public required IsoDecimalNumber Value { get; init; }
    }
}
