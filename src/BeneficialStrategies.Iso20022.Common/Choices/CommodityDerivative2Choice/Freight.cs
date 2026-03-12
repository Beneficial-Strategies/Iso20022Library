// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CommodityDerivative2Choice
{
    /// <summary>
    /// Details specific to freight derivatives.
    /// </summary>
    [IsoId("_njM5UU-nEeiVsYLJl6hleg")]
    [DisplayName("Freight")]
    public partial record Freight : CommodityDerivative2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specification of the size related to the freight sub type. Field to be populated when the base product field is equal to freight.
        /// </summary>
        [IsoId("_nsafsU-nEeiVsYLJl6hleg")]
        [DisplayName("Size")]
        [IsoXmlTag("Sz")]
        [IsoSimpleType(IsoSimpleType.Max25Text)]
        [StringLength(maximumLength: 25 ,MinimumLength = 1)]
        public required IsoMax25Text Size { get; init; } 
        
        /// <summary>
        /// Details the specific route or time charter average. Field to be populated when the base product field is equal to freight.
        /// </summary>
        [IsoId("_nsafs0-nEeiVsYLJl6hleg")]
        [DisplayName("Average Time Charter")]
        [IsoXmlTag("AvrgTmChrtr")]
        [IsoSimpleType(IsoSimpleType.Max25Text)]
        [StringLength(maximumLength: 25 ,MinimumLength = 1)]
        public required IsoMax25Text AverageTimeCharter { get; init; } 
        
        
        #nullable disable
        
    }
}
