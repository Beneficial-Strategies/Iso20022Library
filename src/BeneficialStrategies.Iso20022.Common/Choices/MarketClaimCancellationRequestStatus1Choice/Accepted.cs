// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MarketClaimCancellationRequestStatus1Choice
{
    /// <summary>
    /// Provides status information related to a cancellation request accepted for further processing.
    /// </summary>
    [IsoId("_1TcqZ9x4EeqESbVR5AloZQ")]
    [DisplayName("Accepted")]
    public record Accepted : MarketClaimCancellationRequestStatus1Choice_
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
