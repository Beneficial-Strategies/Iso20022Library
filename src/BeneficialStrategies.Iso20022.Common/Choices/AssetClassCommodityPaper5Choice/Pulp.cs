// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityPaper5Choice
{
    /// <summary>
    /// Pulp.
    /// </summary>
    [DisplayName("Pulp")]
    public partial record Pulp : AssetClassCommodityPaper5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Pulp")]
        public required PaperCommodityPulp2 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
