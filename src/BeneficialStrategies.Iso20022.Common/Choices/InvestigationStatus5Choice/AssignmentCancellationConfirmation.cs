// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InvestigationStatus5Choice
{
    /// <summary>
    /// Indicates whether the cancellation of the assignment is confirmed or rejected.|Usage: If yes, the cancellation of the assignment is confirmed.|If no, the cancellation of the assignment is rejected and the investigation process will continue.
    /// </summary>
    [IsoId("_NRkhqW49EeiU9cctagi5ow")]
    [DisplayName("Assignment Cancellation Confirmation")]
    public partial record AssignmentCancellationConfirmation : InvestigationStatus5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates a &quot;Yes&quot; or &quot;No&quot; type of answer for an element.
        /// </summary>
        [IsoXmlTag("AssgnmtCxlConf")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public required IsoYesNoIndicator Value { get; init; } 
        
        
        #nullable disable
        
    }
}
