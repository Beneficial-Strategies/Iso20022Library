// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityFreight4Choice
{
    /// <summary>
    /// Container ship freight commodity derivative.
    /// </summary>
    [IsoId("_Rn91dU8REe2PGo0mhYCh1g")]
    [DisplayName("Container Ship")]
    public partial record ContainerShip : AssetClassCommodityFreight4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_atNisU8REe2PGo0mhYCh1g")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType4Code BaseProduct { get; init; } 
        
        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_atNis08REe2PGo0mhYCh1g")]
        [DisplayName("Sub Product")]
        [IsoXmlTag("SubPdct")]
        public AssetClassSubProductType46Code? SubProduct { get; init; } 
        
        
        #nullable disable
        
    }
}
