// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PendingReason54Choice
{
    /// <summary>
    /// Standard code to specify the reason why the instruction/event has a pending status.
    /// </summary>
    [IsoId("_tZxGIeaEEemtTOaHuc_63w")]
    [DisplayName("Code")]
    public partial record Code : PendingReason54Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Standard code to specify the reason why the instruction/event has a pending status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PendingReason19Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
