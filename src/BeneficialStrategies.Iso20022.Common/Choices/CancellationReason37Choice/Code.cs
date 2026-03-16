// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationReason37Choice
{
    /// <summary>
    /// Specifies the reason why the related instruction is cancelled, or the related cancellation request is executed.
    /// </summary>
    [IsoId("_65NbE_fUEeiNZp_PtLohLw")]
    [DisplayName("Code")]
    public record Code : CancellationReason37Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for the cancellation status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CancelledStatusReason16Code Value { get; init; }
    }
}
