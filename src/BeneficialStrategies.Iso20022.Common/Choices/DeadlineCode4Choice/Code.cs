// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DeadlineCode4Choice
{
    /// <summary>
    /// Standard code to specify the reference date of a corporate action.
    /// </summary>
    [IsoId("_cfsslZKQEeWHWpTQn1FFVg")]
    [DisplayName("Code")]
    public partial record Code : DeadlineCode4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the deadline reference of a corporate action.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionDeadline1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
