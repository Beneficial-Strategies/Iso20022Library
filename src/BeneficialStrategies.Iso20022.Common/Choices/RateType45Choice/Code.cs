// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RateType45Choice
{
    /// <summary>
    /// Standard code to specify the type of rate.
    /// </summary>
    [IsoId("_cj-HKZKQEeWHWpTQn1FFVg")]
    [DisplayName("Code")]
    public partial record Code : RateType45Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of rate.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RateType7Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
