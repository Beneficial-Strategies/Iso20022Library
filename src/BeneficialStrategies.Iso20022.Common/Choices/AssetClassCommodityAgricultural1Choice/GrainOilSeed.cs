// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityAgricultural1Choice
{
    /// <summary>
    /// Grain oil seed agricultural commodity derivative.
    /// </summary>
    [IsoId("_VQFYZQ2jEeW72qLtWESimw")]
    [DisplayName("Grain Oil Seed")]
    public partial record GrainOilSeed : AssetClassCommodityAgricultural1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_22qz8yY6EeWf-a22WniiQA")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType1Code BaseProduct { get; init; } 
        
        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_22qz8iY6EeWf-a22WniiQA")]
        [DisplayName("Sub Product")]
        [IsoXmlTag("SubPdct")]
        public required AssetClassSubProductType1Code SubProduct { get; init; } 
        
        /// <summary>
        /// Further subproduct type related to instruments that have a non-financial instrument or commodity as underlying.
        /// </summary>
        [IsoId("_22qz8SY6EeWf-a22WniiQA")]
        [DisplayName("Additional Sub Product")]
        [IsoXmlTag("AddtlSubPdct")]
        public required AssetClassDetailedSubProductType1Code AdditionalSubProduct { get; init; } 
        
        
        #nullable disable
        
    }
}
