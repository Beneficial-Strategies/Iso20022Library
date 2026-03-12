// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TimeToMaturity1Choice
{
    /// <summary>
    /// Provides the period for the time to maturity.
    /// </summary>
    [IsoId("__m-r4MVaEeiYpLQka876sg")]
    [DisplayName("Period")]
    public partial record Period : TimeToMaturity1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the start of the maturity period.
        /// </summary>
        [IsoId("_KfScwMVcEeiYpLQka876sg")]
        [DisplayName("Start")]
        [IsoXmlTag("Start")]
        public MaturityTerm2? Start { get; init; } 
        
        /// <summary>
        /// Specifies the end of the maturity period.
        /// </summary>
        [IsoId("_LNQ9EcVcEeiYpLQka876sg")]
        [DisplayName("End")]
        [IsoXmlTag("End")]
        public MaturityTerm2? End { get; init; } 
        
        
        #nullable disable
        
    }
}
