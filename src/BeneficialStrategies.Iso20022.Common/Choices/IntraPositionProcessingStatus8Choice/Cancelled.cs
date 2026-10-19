// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IntraPositionProcessingStatus8Choice
{
    /// <summary>
    /// Instruction has been cancelled.
    /// </summary>
    [IsoId("_65NaMffUEeiNZp_PtLohLw")]
    [DisplayName("Cancelled")]
    public partial record Cancelled : IntraPositionProcessingStatus8Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Canc")]
        public required CancellationStatus25Choice_ Value { get; init; }
    }
}
