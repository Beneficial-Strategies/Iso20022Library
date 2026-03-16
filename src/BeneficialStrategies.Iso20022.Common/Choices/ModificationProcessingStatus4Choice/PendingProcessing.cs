// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus4Choice
{
    /// <summary>
    /// The modification is pending processing.
    /// </summary>
    [IsoId("_gvJOKVhgEeS8HfHHd4stCA")]
    [DisplayName("Pending Processing")]
    public record PendingProcessing : ModificationProcessingStatus4Choice_ { }
}
