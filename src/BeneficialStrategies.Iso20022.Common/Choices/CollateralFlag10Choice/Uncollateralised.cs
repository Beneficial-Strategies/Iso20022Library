// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralFlag10Choice
{
    /// <summary>
    /// Indication that security is not collateralised.
    /// </summary>
    [IsoId("_gI37UwAAEeqefbt-QjTNnA")]
    [DisplayName("Uncollateralised")]
    public record Uncollateralised : CollateralFlag10Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no reason available.
        /// </summary>
        [IsoXmlTag("Uncollsd")]
        public required NoReasonCode Value { get; init; }
    }
}
