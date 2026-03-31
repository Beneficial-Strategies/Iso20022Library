// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status8Choice
{
    /// <summary>
    /// Provides the processing status of the replacement request.
    /// </summary>
    [IsoId("_w2B79EABEeCaq78Ig8ATcA")]
    [DisplayName("Replacement Processing Status")]
    public record ReplacementProcessingStatus : Status8Choice_ { }
}
