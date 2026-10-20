// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat89Choice
{
    /// <summary>
    /// Index Points.
    /// </summary>
    [DisplayName("Index Points")]
    public partial record IndexPoints : PriceFormat89Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("IndxPts")]
        public required RestrictedFINDecimalNumber Value { get; init; }
    }
}
