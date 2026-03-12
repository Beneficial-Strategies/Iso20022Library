// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity2Choice
{
    /// <summary>
    /// Code list for freight type of commodities.
    /// </summary>
    [IsoId("_BzEmOSYyEeWHeosc_5RQEw")]
    [DisplayName("Freight")]
    public partial record Freight : AssetClassCommodity2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Code list for freight related derivative contracts.
        /// </summary>
        [IsoXmlTag("Frght")]
        public required AssetClassSubProductFreight1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
