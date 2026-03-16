// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus1Choice
{
    /// <summary>
    /// Cancellation request from your counterparty for this transaction is pending waiting for your cancellation request or consent.
    /// </summary>
    [IsoId("_UVpIkdp-Ed-ak6NoX_4Aeg_408891271")]
    [DisplayName("Cancellation Requested")]
    public record CancellationRequested : ProcessingStatus1Choice_
    {
        /// <summary>
        /// Indicates that there is no reason available or to report.
        /// </summary>
        [IsoId("_UatOwNp-Ed-ak6NoX_4Aeg_137164408")]
        [DisplayName("No Specified Reason")]
        [IsoXmlTag("NoSpcfdRsn")]
        public required NoReasonCode NoSpecifiedReason { get; init; }
    }
}
