// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity7Choice
{
    /// <summary>
    /// Official Economic Statistics.
    /// </summary>
    [DisplayName("Official Economic Statistics")]
    public partial record OfficialEconomicStatistics : AssetClassCommodity7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("OffclEcnmcSttstcs")]
        public required AssetClassCommodityOfficialEconomicStatistics1 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
