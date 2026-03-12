// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DateCode27Choice
{
    /// <summary>
    /// Standard code to indicate the date is unknown.
    /// </summary>
    [IsoId("_ctmkP5KQEeWHWpTQn1FFVg")]
    [DisplayName("Code")]
    public partial record Code : DateCode27Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies when date is unknown.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required DateType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
