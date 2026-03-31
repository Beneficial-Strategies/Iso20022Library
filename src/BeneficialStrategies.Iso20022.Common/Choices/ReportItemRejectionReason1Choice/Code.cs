// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReportItemRejectionReason1Choice
{
    /// <summary>
    /// Status reason expressed as a code.
    /// </summary>
    [IsoId("_hlx-c73REeO2FLWuu_JIqg")]
    [DisplayName("Code")]
    public record Code : ReportItemRejectionReason1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason the report item is rejected.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required HoldingRejectionReason41Code Value { get; init; }
    }
}
