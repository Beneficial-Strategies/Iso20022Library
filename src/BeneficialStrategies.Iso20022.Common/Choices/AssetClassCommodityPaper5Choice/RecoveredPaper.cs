// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityPaper5Choice
{
    /// <summary>
    /// Recovered Paper.
    /// </summary>
    [DisplayName("Recovered Paper")]
    public partial record RecoveredPaper : AssetClassCommodityPaper5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("RcvrdPpr")]
        public required PaperCommodityRecoveredPaper3 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
