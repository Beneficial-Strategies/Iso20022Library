// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice13Choice
{
    /// <summary>
    /// Used to express differences in interest rates, for example, a difference of 0.10% is equivalent to a change of 10 basis points.
    /// </summary>
    [IsoId("_nbz0kQFMEeqUa4noT3P56A")]
    [DisplayName("Basis Point Spread")]
    public record BasisPointSpread : SecuritiesTransactionPrice13Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Number of objects represented as an integer.
        /// </summary>
        [IsoXmlTag("BsisPtSprd")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public required IsoNumber Value { get; init; }
    }
}
