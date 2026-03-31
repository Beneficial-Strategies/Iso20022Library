// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status8Choice
{
    /// <summary>
    /// Provides the status of a cancellation request.
    /// </summary>
    [IsoId("_w2B8AUABEeCaq78Ig8ATcA")]
    [DisplayName("Cancellation Processing Status")]
    public record CancellationProcessingStatus : Status8Choice_ { }
}
