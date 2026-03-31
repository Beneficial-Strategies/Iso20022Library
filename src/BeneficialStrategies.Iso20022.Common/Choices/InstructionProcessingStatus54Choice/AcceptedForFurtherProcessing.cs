// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus54Choice
{
    /// <summary>
    /// Accepted For Further Processing.
    /// </summary>
    [DisplayName("Accepted For Further Processing")]
    public record AcceptedForFurtherProcessing : InstructionProcessingStatus54Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("AccptdForFrthrPrcg")]
        public required AcceptedStatus9Choice_ Value { get; init; }
    }
}
