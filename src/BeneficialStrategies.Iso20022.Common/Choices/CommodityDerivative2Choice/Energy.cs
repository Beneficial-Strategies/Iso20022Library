// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CommodityDerivative2Choice
{
    /// <summary>
    /// Details specific to energy derivatives.
    /// </summary>
    [IsoId("_njM5U0-nEeiVsYLJl6hleg")]
    [DisplayName("Energy")]
    public partial record Energy : CommodityDerivative2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Place where the delivery and the cash settlement of the base product occurs. 
        /// </summary>
        [IsoId("_0qs7EU-nEeiVsYLJl6hleg")]
        [DisplayName("Settlement Location")]
        [IsoXmlTag("SttlmLctn")]
        [IsoSimpleType(IsoSimpleType.Max25Text)]
        [StringLength(maximumLength: 25 ,MinimumLength = 1)]
        public required IsoMax25Text SettlementLocation { get; init; } 
        
        
        #nullable disable
        
    }
}
