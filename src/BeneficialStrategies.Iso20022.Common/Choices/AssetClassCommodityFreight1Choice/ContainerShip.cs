// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityFreight1Choice
{
    /// <summary>
    /// Container ship freight commodity derivative.
    /// </summary>
    [IsoId("_AXue4vwgEeW4Wthd0Ze_kA")]
    [DisplayName("Container Ship")]
    public partial record ContainerShip : AssetClassCommodityFreight1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_i535x_wfEeW4Wthd0Ze_kA")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType4Code BaseProduct { get; init; } 
        
        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_i535xfwfEeW4Wthd0Ze_kA")]
        [DisplayName("Sub Product")]
        [IsoXmlTag("SubPdct")]
        public required AssetClassSubProductType46Code SubProduct { get; init; } 
        
        
        #nullable disable
        
    }
}
