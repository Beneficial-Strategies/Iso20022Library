// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InvestigationRequestStatusReason1Choice
{
    /// <summary>
    /// Reason for the investigation request status, in a coded form.
    /// </summary>
    [IsoId("_xWB3s3bnEe2GR4CRzIB77g")]
    [DisplayName("Code")]
    public record Code : InvestigationRequestStatusReason1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the tracker investigation status reason, as published in an external investigation status code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalTrackerInvestigationStatusReason1Code Value { get; init; }
    }
}
