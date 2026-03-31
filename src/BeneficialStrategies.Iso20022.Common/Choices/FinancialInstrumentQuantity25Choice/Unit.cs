// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity25Choice
{
    /// <summary>
    /// Quantity expressed as a number, such as a number of shares.
    /// </summary>
    [IsoId("_AqIGYYIiEeW_KPkCyw2GUA")]
    [DisplayName("Unit")]
    public record Unit : FinancialInstrumentQuantity25Choice_
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
