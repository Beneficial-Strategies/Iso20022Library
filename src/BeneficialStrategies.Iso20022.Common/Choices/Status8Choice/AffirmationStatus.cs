// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status8Choice
{
    /// <summary>
    /// Status of affirmation of a trade.
    /// </summary>
    [IsoId("_w2B7ckABEeCaq78Ig8ATcA")]
    [DisplayName("Affirmation Status")]
    public record AffirmationStatus : Status8Choice_ { }
}
