// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status19Choice
{
    /// <summary>
    /// Provides the status of the registration processing.
    /// </summary>
    [IsoId("_9HwpozqpEeWyoP0PbocV1Q")]
    [DisplayName("Registration Processing Status")]
    public record RegistrationProcessingStatus : Status19Choice_ { }
}
