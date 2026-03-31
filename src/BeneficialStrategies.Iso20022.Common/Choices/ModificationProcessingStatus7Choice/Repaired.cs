// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus7Choice
{
    /// <summary>
    /// Modification request is accepted but in repair.
    /// </summary>
    [IsoId("_17xaVTp4EeWVrPy0StzzSg")]
    [DisplayName("Repaired")]
    public record Repaired : ModificationProcessingStatus7Choice_ { }
}
