// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.EventProcessingStatus4Choice
{
    /// <summary>
    /// Specifies that a corporate action event processing has not been fully completed and is therefore pending.
    /// </summary>
    [IsoId("_cel4CZKQEeWHWpTQn1FFVg")]
    [DisplayName("Pending")]
    public record Pending : EventProcessingStatus4Choice_ { }
}
