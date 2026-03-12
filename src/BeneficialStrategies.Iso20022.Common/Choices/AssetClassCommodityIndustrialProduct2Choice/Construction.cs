// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityIndustrialProduct2Choice
{
    /// <summary>
    /// Construction related industrial product commodity derivative.
    /// </summary>
    [IsoId("_OTrSERZZEe2QNcZTDeoKnQ")]
    [DisplayName("Construction")]
    public partial record Construction : AssetClassCommodityIndustrialProduct2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_QZDqMRZZEe2QNcZTDeoKnQ")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType6Code BaseProduct { get; init; } 
        
        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_QZDqMxZZEe2QNcZTDeoKnQ")]
        [DisplayName("Sub Product")]
        [IsoXmlTag("SubPdct")]
        public AssetClassSubProductType33Code? SubProduct { get; init; } 
        
        
        #nullable disable
        
    }
}
