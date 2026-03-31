// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status22Choice
{
    /// <summary>
    /// Provides the status of the registration processing.
    /// </summary>
    [IsoId("_8QboM5NLEeWGlc8L7oPDIg")]
    [DisplayName("Registration Processing Status")]
    public record RegistrationProcessingStatus : Status22Choice_ { }
}
