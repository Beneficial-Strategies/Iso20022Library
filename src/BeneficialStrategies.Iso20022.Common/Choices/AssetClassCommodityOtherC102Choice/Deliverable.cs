// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityOtherC102Choice
{
    /// <summary>
    /// Other C10 deliverable commodity derivative.
    /// </summary>
    [IsoId("_lcXQUXvyEeanCNPcMT7sSg")]
    [DisplayName("Deliverable")]
    public partial record Deliverable : AssetClassCommodityOtherC102Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_2G-McXvyEeanCNPcMT7sSg")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType11Code BaseProduct { get; init; } 
        
        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_2G-Mc3vyEeanCNPcMT7sSg")]
        [DisplayName("Sub Product")]
        [IsoXmlTag("SubPdct")]
        public AssetClassSubProductType47Code? SubProduct { get; init; } 
        
        
        #nullable disable
        
    }
}
