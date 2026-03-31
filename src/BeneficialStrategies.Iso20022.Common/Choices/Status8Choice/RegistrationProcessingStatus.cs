// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status8Choice
{
    /// <summary>
    /// Provides the status of the registration processing.
    /// </summary>
    [IsoId("_w2B72kABEeCaq78Ig8ATcA")]
    [DisplayName("Registration Processing Status")]
    public record RegistrationProcessingStatus : Status8Choice_ { }
}
