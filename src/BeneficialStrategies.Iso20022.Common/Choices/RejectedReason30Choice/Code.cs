// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RejectedReason30Choice
{
    /// <summary>
    /// Standard code to specify the reason why the instruction/cancellation request has a rejected status.
    /// </summary>
    [IsoId("_eKVR2sAUEembi_x1QDJfxw")]
    [DisplayName("Code")]
    public partial record Code : RejectedReason30Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why the identification disclosure response has a rejected status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason52Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
