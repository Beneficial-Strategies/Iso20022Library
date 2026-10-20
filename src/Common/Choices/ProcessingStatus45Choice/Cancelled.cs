// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus45Choice
{
    /// <summary>
    /// Cancellation requested executed.
    /// </summary>
    [IsoId("_i0ct81hgEeS8HfHHd4stCA")]
    [DisplayName("Cancelled")]
    public partial record Cancelled : ProcessingStatus45Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Canc")]
        public required CancellationStatus9Choice_ Value { get; init; }
    }
}
