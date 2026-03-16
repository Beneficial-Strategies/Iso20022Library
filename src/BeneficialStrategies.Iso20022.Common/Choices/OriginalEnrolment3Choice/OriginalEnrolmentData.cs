// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OriginalEnrolment3Choice
{
    /// <summary>
    /// Original Enrolment Data.
    /// </summary>
    [DisplayName("Original Enrolment Data")]
    public record OriginalEnrolmentData : OriginalEnrolment3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("OrgnlEnrlmntData")]
        public required CreditorEnrolment5 Value { get; init; }
    }
}
