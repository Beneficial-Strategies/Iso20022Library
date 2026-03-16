// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TerminationReason1Choice
{
    /// <summary>
    /// Termination reason.
    /// </summary>
    [IsoId("_932rsnltEeG7BsjMvd1mEw_1025821698")]
    [DisplayName("Code")]
    public record Code : TerminationReason1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the termination reason.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TerminationReason1Code Value { get; init; }
    }
}
