// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StandingOrderOrError10Choice
{
    /// <summary>
    /// Business Error.
    /// </summary>
    [DisplayName("Business Error")]
    public partial record BusinessError : StandingOrderOrError10Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("BizErr")]
        public required ErrorHandling5 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
