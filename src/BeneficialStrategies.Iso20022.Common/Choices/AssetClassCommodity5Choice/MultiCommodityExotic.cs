// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity5Choice
{
    /// <summary>
    /// Multi Commodity Exotic
    /// </summary>
    [IsoId("_owQIR7tIEeiLRYqS-r-R-A")]
    [DisplayName("Multi Commodity Exotic")]
    public partial record MultiCommodityExotic : AssetClassCommodity5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_6Eul4Fr0EeWN79Bl6BUd3g")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType13Code BaseProduct { get; init; } 
        
        
        #nullable disable
        
    }
}
