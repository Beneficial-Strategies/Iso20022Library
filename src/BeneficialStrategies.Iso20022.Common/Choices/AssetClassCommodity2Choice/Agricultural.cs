// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity2Choice
{
    /// <summary>
    /// Code list for agricultural type of commodities.
    /// </summary>
    [IsoId("_BzEmPyYyEeWHeosc_5RQEw")]
    [DisplayName("Agricultural")]
    public record Agricultural : AssetClassCommodity2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Code list for agricultural related derivative contracts.
        /// </summary>
        [IsoXmlTag("Agrcltrl")]
        public required AssetClassSubProductAgriculturalType1Code Value { get; init; }
    }
}
