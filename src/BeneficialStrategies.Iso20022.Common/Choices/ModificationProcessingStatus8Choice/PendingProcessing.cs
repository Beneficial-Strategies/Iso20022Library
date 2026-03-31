// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus8Choice
{
    /// <summary>
    /// Modification is pending processing.
    /// </summary>
    [IsoId("_6QCdPZNLEeWGlc8L7oPDIg")]
    [DisplayName("Pending Processing")]
    public record PendingProcessing : ModificationProcessingStatus8Choice_ { }
}
