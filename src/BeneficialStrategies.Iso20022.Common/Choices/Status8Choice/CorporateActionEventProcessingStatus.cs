// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status8Choice
{
    /// <summary>
    /// Provides the status of a corporate action or the status of a payment.
    /// </summary>
    [IsoId("_w2B7mUABEeCaq78Ig8ATcA")]
    [DisplayName("Corporate Action Event Processing Status")]
    public record CorporateActionEventProcessingStatus : Status8Choice_ { }
}
