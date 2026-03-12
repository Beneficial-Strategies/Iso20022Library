// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityEnvironmental2Choice
{
    /// <summary>
    /// Carbon related environmental commodity derivative.
    /// </summary>
    [IsoId("_g7vTtbvwEeiLRYqS-r-R-A")]
    [DisplayName("Carbon Related")]
    public partial record CarbonRelated : AssetClassCommodityEnvironmental2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_SWQ-UFrNEeWN79Bl6BUd3g")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType3Code BaseProduct { get; init; } 
        
        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_YusgAFrNEeWN79Bl6BUd3g")]
        [DisplayName("Sub Product")]
        [IsoXmlTag("SubPdct")]
        public required AssetClassSubProductType29Code SubProduct { get; init; } 
        
        
        #nullable disable
        
    }
}
