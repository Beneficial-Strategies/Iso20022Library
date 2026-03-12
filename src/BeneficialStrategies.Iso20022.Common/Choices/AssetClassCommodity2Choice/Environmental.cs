// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity2Choice
{
    /// <summary>
    /// Code list for environmental type of commodities.
    /// </summary>
    [IsoId("_BzEmPiYyEeWHeosc_5RQEw")]
    [DisplayName("Environmental")]
    public partial record Environmental : AssetClassCommodity2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Code list for environmental related derivative contracts.
        /// </summary>
        [IsoXmlTag("Envttl")]
        public required AssetClassSubProductEnvironmentalType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
