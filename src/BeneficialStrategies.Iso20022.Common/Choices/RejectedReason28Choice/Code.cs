// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RejectedReason28Choice
{
    /// <summary>
    /// Rejection reason specified as a code.
    /// </summary>
    [IsoId("_jCSj-rKaEemux5trsZcCpw")]
    [DisplayName("Code")]
    public partial record Code : RejectedReason28Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a reason why the instruction has a rejected status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason50Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
