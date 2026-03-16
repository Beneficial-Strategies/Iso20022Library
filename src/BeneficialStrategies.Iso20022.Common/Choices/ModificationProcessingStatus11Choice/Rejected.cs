// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus11Choice
{
    /// <summary>
    /// Modification request has been rejected for further processing.
    /// </summary>
    [IsoId("_ds02MTi8Eeydid5dcNPKvg")]
    [DisplayName("Rejected")]
    public record Rejected : ModificationProcessingStatus11Choice_ { }
}
