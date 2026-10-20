// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status19Choice
{
    /// <summary>
    /// Provides the status of a cancellation request.
    /// </summary>
    [IsoId("_9HwpqTqpEeWyoP0PbocV1Q")]
    [DisplayName("Cancellation Processing Status")]
    public partial record CancellationProcessingStatus : Status19Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CxlPrcgSts")]
        public required CancellationProcessingStatus7Choice_ Value { get; init; }
    }
}
