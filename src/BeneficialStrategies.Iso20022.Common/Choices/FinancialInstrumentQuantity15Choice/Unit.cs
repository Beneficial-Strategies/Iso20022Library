// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity15Choice
{
    /// <summary>
    /// Quantity expressed as a number, for example, a number of shares.
    /// </summary>
    [IsoId("_Wr_79tp-Ed-ak6NoX_4Aeg_269932102")]
    [DisplayName("Unit")]
    public record Unit : FinancialInstrumentQuantity15Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Number of objects represented as a decimal number, for example, 0.75 or 45.6.
        /// </summary>
        [IsoXmlTag("Unit")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINDecimalNumber)]
        public required IsoRestrictedFINDecimalNumber Value { get; init; }
    }
}
