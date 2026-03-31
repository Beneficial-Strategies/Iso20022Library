// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityPaper5Choice
{
    /// <summary>
    /// Container Board.
    /// </summary>
    [DisplayName("Container Board")]
    public record ContainerBoard : AssetClassCommodityPaper5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("CntnrBrd")]
        public required PaperCommodityContainerBoard2 Value { get; init; }
    }
}
