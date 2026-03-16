// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InvestigationStatus2Choice
{
    /// <summary>
    /// Indicates whether the cancellation of the assignment is confirmed or rejected.|Usage: If yes, the cancellation of the assignment is confirmed.|If no, the cancellation of the assignment is rejected and the investigation process will continue.
    /// </summary>
    [IsoId("_T-P8SNp-Ed-ak6NoX_4Aeg_523812698")]
    [DisplayName("Assignment Cancellation Confirmation")]
    public record AssignmentCancellationConfirmation : InvestigationStatus2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates a &quot;Yes&quot; or &quot;No&quot; type of answer for an element.
        /// </summary>
        [IsoXmlTag("AssgnmtCxlConf")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public required IsoYesNoIndicator Value { get; init; }
    }
}
