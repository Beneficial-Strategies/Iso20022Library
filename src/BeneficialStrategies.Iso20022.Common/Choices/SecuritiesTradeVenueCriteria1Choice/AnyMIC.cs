// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTradeVenueCriteria1Choice
{
    /// <summary>
    /// Indicates any other code used to identify the execution venue.
    /// Usage:
    /// Result of the query should include all trades where this filed was populated with a MIC code (but not the trades with ‘XOFF’ or ‘XXXX’).
    /// </summary>
    [IsoId("_ph_4kB3ZEeWNp95x0ENf8w")]
    [DisplayName("Any MIC")]
    public partial record AnyMIC : SecuritiesTradeVenueCriteria1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a market identification code (MIC).
        /// </summary>
        [IsoXmlTag("AnyMIC")]
        public required AnyMIC1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
