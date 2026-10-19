// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IntraPositionProcessingStatus6Choice
{
    /// <summary>
    /// Instruction has been cancelled.
    /// </summary>
    [IsoId("_5SFAVZNLEeWGlc8L7oPDIg")]
    [DisplayName("Cancelled")]
    public partial record Cancelled : IntraPositionProcessingStatus6Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Canc")]
        public required CancellationStatus17Choice_ Value { get; init; }
    }
}
