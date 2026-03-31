// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassDetailedSubProductType1Choice
{
    /// <summary>
    /// Specifies the type of commodity.
    /// </summary>
    [IsoId("_ZDUjII16Eeet3cKIYK84nw")]
    [DisplayName("Code")]
    public record Code : AssetClassDetailedSubProductType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Sub product code list for commodity derivatives.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AssetClassDetailedSubProductType16Code Value { get; init; }
    }
}
