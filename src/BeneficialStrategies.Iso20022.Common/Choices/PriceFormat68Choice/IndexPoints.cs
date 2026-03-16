// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat68Choice
{
    /// <summary>
    /// Price expressed in index points.
    /// </summary>
    [IsoId("_plY1lzi7Eeydid5dcNPKvg")]
    [DisplayName("Index Points")]
    public record IndexPoints : PriceFormat68Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Number of objects represented as a decimal number, for example, 0.75 or 45.6.
        /// </summary>
        [IsoXmlTag("IndxPts")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINDecimalNumber)]
        public required IsoRestrictedFINDecimalNumber Value { get; init; }
    }
}
