// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat4Choice
{
    /// <summary>
    /// Price expressed as index points.
    /// </summary>
    [IsoId("_QbJo9tp-Ed-ak6NoX_4Aeg_-883480030")]
    [DisplayName("Index Points")]
    public record IndexPoints : PriceFormat4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Number of objects represented as a decimal number, for example 0.75 or 45.6.
        /// </summary>
        [IsoXmlTag("IndxPts")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        public required IsoDecimalNumber Value { get; init; }
    }
}
