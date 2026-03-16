// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice10Choice
{
    /// <summary>
    /// Indicates that price is expressed in units.
    /// </summary>
    [IsoId("_QtVs4f9iEea3W_f2lS_aiw")]
    [DisplayName("Unit")]
    public record Unit : SecuritiesTransactionPrice10Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Number of objects represented as a decimal number, for example 0.75 or 45.6.
        /// </summary>
        [IsoXmlTag("Unit")]
        [IsoSimpleType(IsoSimpleType.LongFraction21DecimalNumber)]
        public required IsoLongFraction21DecimalNumber Value { get; init; }
    }
}
