// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DistributionTypeFormat8Choice
{
    /// <summary>
    /// Standard code to specify whether the proceeds of the event will be distributed on a rolling basis rather than on a specific date.
    /// </summary>
    [IsoId("_c5VTlZKQEeWHWpTQn1FFVg")]
    [DisplayName("Code")]
    public partial record Code : DistributionTypeFormat8Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether the proceeds of the event will be distributed on a rolling basis rather than on a specific date.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required DistributionType3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
