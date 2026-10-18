// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IntraPositionProcessingStatus9Choice
{
    /// <summary>
    /// Instruction has been cancelled.
    /// </summary>
    [IsoId("_ZkDCIStUEeyhipY4f42fZQ")]
    [DisplayName("Cancelled")]
    public record Cancelled : IntraPositionProcessingStatus9Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Canc")]
        public required CancellationStatus24Choice_ Value { get; init; }
    }
}
