// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.EventProcessingStatus6Choice
{
    /// <summary>
    /// Corporate action event processing specifying that the funds paid have been reconciled with the funds received from the agent (meaning that there is no more risk of payment to be reversed).
    /// </summary>
    [IsoId("_Szi6RAVREeqjd8n6wD9JVw")]
    [DisplayName("Reconciled")]
    public record Reconciled : EventProcessingStatus6Choice_
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
