// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.EventProcessingStatus1Choice
{
    /// <summary>
    /// Specifies that a corporate action event processing has not been fully completed and is therefore pending.
    /// </summary>
    [IsoId("_QxzOatp-Ed-ak6NoX_4Aeg_670695526")]
    [DisplayName("Pending")]
    public record Pending : EventProcessingStatus1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Pdg")]
        public required PendingStatus2Choice_ Value { get; init; }
    }
}
