// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClosureReason2Choice
{
    /// <summary>
    /// Reason the system is closed/not operating, in a coded form.
    /// </summary>
    [IsoId("_72rN8aMgEeCJ6YNENx4h-w_2072167944")]
    [DisplayName("Code")]
    public partial record Code : ClosureReason2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for system inactivity.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SystemClosureReason1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
