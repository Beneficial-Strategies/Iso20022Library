// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity6Choice
{
    /// <summary>
    /// Official Economic Statistics commodities.
    /// </summary>
    [IsoId("_1bgUKRZXEe2QNcZTDeoKnQ")]
    [DisplayName("Official Economic Statistics")]
    public partial record OfficialEconomicStatistics : AssetClassCommodity6Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_-mgvAFr0EeWN79Bl6BUd3g")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType14Code BaseProduct { get; init; } 
        
        
        #nullable disable
        
    }
}
