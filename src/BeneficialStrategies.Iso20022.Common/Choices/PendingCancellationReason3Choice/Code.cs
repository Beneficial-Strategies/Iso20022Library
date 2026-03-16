// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingCancellationReason3Choice
{
    /// <summary>
    /// Standard code to specify the reason why a cancellation request sent for the related instruction is pending.
    /// </summary>
    [IsoId("_MwdGEUGXEeWqy4niLuXETA")]
    [DisplayName("Code")]
    public record Code : PendingCancellationReason3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Standard code to specify.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PendingCancellationReason4Code Value { get; init; }
    }
}
