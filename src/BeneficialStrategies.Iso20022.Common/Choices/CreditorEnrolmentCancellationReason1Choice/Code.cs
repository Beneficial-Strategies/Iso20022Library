// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CreditorEnrolmentCancellationReason1Choice
{
    /// <summary>
    /// Reason, as published in an external reason code list.
    /// </summary>
    [IsoId("_pQ9Sy_DBEemsS_0xy2XRug")]
    [DisplayName("Code")]
    public record Code : CreditorEnrolmentCancellationReason1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the creditor enrolment cancellation reason code, as published in an external creditor enrolment cancellation reason code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalCreditorEnrolmentCancellationReason1Code Value { get; init; }
    }
}
