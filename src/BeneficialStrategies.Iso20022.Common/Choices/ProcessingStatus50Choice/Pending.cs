// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus50Choice
{
    /// <summary>
    /// Modification is pending. It is not known at this time whether modification can be affected.
    /// </summary>
    [IsoId("_i1LiNznvEeWfSKvvZlhRKg")]
    [DisplayName("Pending")]
    public record Pending : ProcessingStatus50Choice_ { }
}
