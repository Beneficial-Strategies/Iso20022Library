// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status21Choice
{
    /// <summary>
    /// Status of the transfer cancellation is complete. The cancellation instruction has been accepted and processed, the cancellation is complete.
    /// </summary>
    [IsoId("_MHhOUiYuEeW_ZNn8gbfY7Q")]
    [DisplayName("Complete")]
    public record Complete : Status21Choice_
    {
        /// <summary>
        /// Reason for the cancelled complete status.
        /// </summary>
        [IsoId("_YeeSACYwEeW_ZNn8gbfY7Q")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public required CancellationCompleteReason1Choice_ Reason { get; init; }

        /// <summary>
        /// Additional information about the cancelled complete status reason.
        /// </summary>
        [IsoId("_aJTcJCYwEeW_ZNn8gbfY7Q")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalReasonInformation { get; init; }
    }
}
