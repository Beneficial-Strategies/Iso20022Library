// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PositionSetAggregated1Choice
{
    /// <summary>
    /// Detailed aggregated position set report between a pair of counterparties.
    /// </summary>
    [IsoId("_CHENxEwhEeqwfMIOLcNxbw")]
    [DisplayName("Report")]
    public partial record Report : PositionSetAggregated1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Reference date for statistics collection.
        /// </summary>
        [IsoId("_0w29MQ1MEeqV4s5SpzR1dQ")]
        [DisplayName("Reference Date")]
        [IsoXmlTag("RefDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate ReferenceDate { get; init; } 
        
        /// <summary>
        /// Aggregation of outstanding derivatives with similar dimensions. Numerous positions sets that are produced according to the combination of dimensions used to stratify the derivatives, and different metrics are used to represent the aggregations. 
        /// </summary>
        [IsoId("_0w29Mw1MEeqV4s5SpzR1dQ")]
        [DisplayName("Position Set")]
        [IsoXmlTag("PosSet")]
        public PositionSet5? PositionSet { get; init; } 
        
        /// <summary>
        /// Aggregation of outstanding derivatives according to the currency of the position, for use by central banks issuing specific currencies.
        /// </summary>
        [IsoId("_0w29NQ1MEeqV4s5SpzR1dQ")]
        [DisplayName("Currency Position Set")]
        [IsoXmlTag("CcyPosSet")]
        public PositionSet5? CurrencyPositionSet { get; init; } 
        
        /// <summary>
        /// Aggregation of collateral for derivative positions using collateral fields as metrics.
        /// </summary>
        [IsoId("_0w29Nw1MEeqV4s5SpzR1dQ")]
        [DisplayName("Collateral Position Set")]
        [IsoXmlTag("CollPosSet")]
        public PositionSet4? CollateralPositionSet { get; init; } 
        
        /// <summary>
        /// Aggregation of collateral with similar dimensions that relate to the currency position sets, with relevant collateral related metrics.
        /// </summary>
        [IsoId("_0w29OQ1MEeqV4s5SpzR1dQ")]
        [DisplayName("Currency Collateral Position Set")]
        [IsoXmlTag("CcyCollPosSet")]
        public PositionSet4? CurrencyCollateralPositionSet { get; init; } 
        
        
        #nullable disable
        
    }
}
