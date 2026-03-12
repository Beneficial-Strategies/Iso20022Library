// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TimeToMaturity1Choice
{
    /// <summary>
    /// Provides the time to maturity when no period is provide.
    /// </summary>
    [IsoId("_9Q_E4MVaEeiYpLQka876sg")]
    [DisplayName("Special")]
    public partial record Special : TimeToMaturity1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies blank or not available codes.
        /// </summary>
        [IsoXmlTag("Spcl")]
        public required SpecialPurpose2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
