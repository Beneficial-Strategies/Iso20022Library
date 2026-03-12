// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PendingReason51Choice
{
    /// <summary>
    /// Pending reason specified as a code.
    /// </summary>
    [IsoId("_fOg6EbLLEemDyeh7tbvg1w")]
    [DisplayName("Code")]
    public partial record Code : PendingReason51Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a reason why the instruction is pending.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PendingReason16Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
