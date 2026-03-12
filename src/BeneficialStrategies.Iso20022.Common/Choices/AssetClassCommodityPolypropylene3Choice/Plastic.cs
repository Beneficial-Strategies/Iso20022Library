// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityPolypropylene3Choice
{
    /// <summary>
    /// Plastic commodity derivative.
    /// </summary>
    [IsoId("_Ihrssbv9EeiLRYqS-r-R-A")]
    [DisplayName("Plastic")]
    public partial record Plastic : AssetClassCommodityPolypropylene3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_bNpscGs5EeW9oI9ZdgWHPQ")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType9Code BaseProduct { get; init; } 
        
        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_eOMFQGs5EeW9oI9ZdgWHPQ")]
        [DisplayName("Sub Product")]
        [IsoXmlTag("SubPdct")]
        public AssetClassSubProductType18Code? SubProduct { get; init; } 
        
        
        #nullable disable
        
    }
}
