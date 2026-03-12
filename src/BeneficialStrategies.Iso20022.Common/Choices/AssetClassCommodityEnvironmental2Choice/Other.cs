// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityEnvironmental2Choice
{
    /// <summary>
    /// Other environmental commodity derivative.
    /// </summary>
    [IsoId("_qPKm4LvwEeiLRYqS-r-R-A")]
    [DisplayName("Other")]
    public partial record Other : AssetClassCommodityEnvironmental2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_0pEZ8bvwEeiLRYqS-r-R-A")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType3Code BaseProduct { get; init; } 
        
        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_0pEZ87vwEeiLRYqS-r-R-A")]
        [DisplayName("Sub Product")]
        [IsoXmlTag("SubPdct")]
        public required AssetClassSubProductType49Code SubProduct { get; init; } 
        
        
        #nullable disable
        
    }
}
