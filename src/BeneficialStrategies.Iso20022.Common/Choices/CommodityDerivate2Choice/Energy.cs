// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CommodityDerivate2Choice
{
    /// <summary>
    /// Details specific to energy derivatives.
    /// </summary>
    [IsoId("_zwLKw2lHEeaLAKoEUNsD9g")]
    [DisplayName("Energy")]
    public partial record Energy : CommodityDerivate2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Place where the delivery and the cash settlement of the base product occurs.
        /// </summary>
        [IsoId("_fDBVYX5zEeasY4u9QTizPQ")]
        [DisplayName("Settlement Location")]
        [IsoXmlTag("SttlmLctn")]
        [IsoSimpleType(IsoSimpleType.Max25Text)]
        [StringLength(maximumLength: 25 ,MinimumLength = 1)]
        public required IsoMax25Text SettlementLocation { get; init; } 
        
        
        #nullable disable
        
    }
}
