// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CreditorEnrolmentStatusReason2Choice
{
    /// <summary>
    /// Reason, as published in an external reason code list.
    /// </summary>
    [IsoId("_fW_fZOIxEeqbls7Gk4-ckA")]
    [DisplayName("Code")]
    public record Code : CreditorEnrolmentStatusReason2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the  creditor enrolment status reason code, as published in an external  creditor enrolment status reason code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalCreditorEnrolmentStatusReason1Code Value { get; init; }
    }
}
