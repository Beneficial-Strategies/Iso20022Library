// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AffirmationStatus11Choice
{
    /// <summary>
    /// Trade has been unaffirmed.
    /// </summary>
    [IsoId("_XzM-0wd3Ee2fOITqoTnSLQ")]
    [DisplayName("Unaffirmed")]
    public record Unaffirmed : AffirmationStatus11Choice_ { }
}
