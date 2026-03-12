// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityEnergy2Choice
{
    /// <summary>
    /// Definition of Oil energy commodity derivative.
    /// </summary>
    [IsoId("_x4yAdbvsEeiLRYqS-r-R-A")]
    [DisplayName("Oil")]
    public partial record Oil : AssetClassCommodityEnergy2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_KZwa4bv4EeiLRYqS-r-R-A")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType2Code BaseProduct { get; init; } 
        
        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_KZwa47v4EeiLRYqS-r-R-A")]
        [DisplayName("Sub Product")]
        [IsoXmlTag("SubPdct")]
        public required AssetClassSubProductType8Code SubProduct { get; init; } 
        
        /// <summary>
        /// Further subproduct type related to instruments that have a non-financial instrument or commodity as underlying.
        /// </summary>
        [IsoId("_KZwa5bv4EeiLRYqS-r-R-A")]
        [DisplayName("Additional Sub Product")]
        [IsoXmlTag("AddtlSubPdct")]
        public required AssetClassDetailedSubProductType32Code AdditionalSubProduct { get; init; } 
        
        
        #nullable disable
        
    }
}
