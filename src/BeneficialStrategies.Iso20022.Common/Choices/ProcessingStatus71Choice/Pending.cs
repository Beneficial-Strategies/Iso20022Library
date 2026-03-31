// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus71Choice
{
    /// <summary>
    /// Modification is pending. It is not known at this time whether modification can be affected.
    /// </summary>
    [IsoId("_mk9BmeGKEeWCAvUNsZ5u6g")]
    [DisplayName("Pending")]
    public record Pending : ProcessingStatus71Choice_ { }
}
