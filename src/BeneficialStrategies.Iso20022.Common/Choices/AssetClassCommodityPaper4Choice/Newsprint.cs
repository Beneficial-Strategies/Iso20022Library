// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityPaper4Choice
{
    /// <summary>
    /// Newsprint commodity derivative.
    /// </summary>
    [IsoId("_FsdvMxZaEe2QNcZTDeoKnQ")]
    [DisplayName("Newsprint")]
    public partial record Newsprint : AssetClassCommodityPaper4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_MJVE8RZaEe2QNcZTDeoKnQ")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType8Code BaseProduct { get; init; } 
        
        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_MJVE8xZaEe2QNcZTDeoKnQ")]
        [DisplayName("Sub Product")]
        [IsoXmlTag("SubPdct")]
        public AssetClassSubProductType36Code? SubProduct { get; init; } 
        
        
        #nullable disable
        
    }
}
